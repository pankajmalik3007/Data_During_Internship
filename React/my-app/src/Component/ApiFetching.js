
// import React, { useState, useEffect } from "react";
// import "./ApiFetching.css";
// import CartPage from "./CartPage";


// function ApiFetching({ updateCartQuantity }) {
//   const [data, setData] = useState([]);
//   const [cart, setCart] = useState([]);
//   const [isLightGreenTheme, setIsLightGreenTheme] = useState(true);
//   const [selectedItems, setSelectedItems] = useState([]);


//   useEffect(() => {
//     const fetchData = async () => {
//       try {
//         const response = await fetch("https://dummyjson.com/products");
//         const result = await response.json();
//         setData(result.products);
//       } catch (error) {
//         console.error("Error While Fetching Data", error);
//       }
//     };
//     fetchData();
//   }, []);

//   const addToCart = (item) => {
//     const updatedCart = [...selectedItems];
//     const existingItemIndex = updatedCart.findIndex((cartItem) => cartItem.id === item.id);
  
//     if (existingItemIndex !== -1) {
//       updatedCart[existingItemIndex].quantity++;
//     } else {
//       updatedCart.push({
//         ...item,
//         quantity: 1,
//         title: item.title,
//         description: item.description,
//         image: item.thumbnail, // Assuming thumbnail is the URL for the product image
//       });
//     }
  
//     setSelectedItems(updatedCart);
//     updateCartQuantity(1);
//   };
//   const removeProductFromCart = (item) => {
//     const updatedCart = [...cart];
//     const existingItemIndex = updatedCart.findIndex((cartItem) => cartItem.id === item.id);

//     if (existingItemIndex !== -1) {
//       updatedCart[existingItemIndex].quantity--;

//       if (updatedCart[existingItemIndex].quantity === 0) {
//         updatedCart.splice(existingItemIndex, 1);
//       }

//       setCart(updatedCart);
//       updateCartQuantity(-1);
//     }
//   };

//   const toggleTheme = () => {
//     setIsLightGreenTheme((prevTheme) => !prevTheme);
//   };

//   return (
//     <div className={`container mt-3 ${isLightGreenTheme ? "bg-lightgreen" : "bg-lightyellow"}`}>
//       <h3 id="quantity">Total Quantity in Cart: {cart.reduce((total, item) => total + item.quantity, 0)}</h3>
      
//       <h1>List Of Products</h1>
//       <div className="row">
//         {data.map((item) => (
//           <div key={item.id} className="col-md-4 mb-4">
//             <div className="card">
//               <img
//                 src={item.thumbnail}
//                 className="card-img-top"
//                 alt={item.title}
//                 style={{ width: "200px", height: "180px", objectFit: "cover" }}
//               />
//               <div className="card-body">
//                 <h5 className="card-title">{item.title}</h5>
//                 <p className="card-text">{item.description}</p>
//                 <button className="btn btn-primary mr-2" onClick={() => addToCart(item)}>
//                   Add to Cart
//                 </button>
//                 <button className="btn btn-danger" onClick={() => removeProductFromCart(item)}>
//                   Remove from Cart
//                 </button>
//                 <p className="mt-2">Quantity: {cart.find((cartItem) => cartItem.id === item.id)?.quantity || 0}</p>
//               </div>
//             </div>
//           </div>
//         ))}
//       </div>
//       <button className="btn btn-primary mt-3" onClick={toggleTheme}>
//         Toggle Theme
//       </button>
//     </div>
//   );
// }

// export default ApiFetching;




import React, { useEffect, useState } from "react";
import "bootstrap/dist/css/bootstrap.min.css"; // Import Bootstrap CSS
import "./ApiFetching.css";
function ApiFetching() {
  const [data, setData] = useState([]);
  const [cart, setCart] = useState([]);
  const [totalQuantity, setTotalQuantity] = useState(0);
  const [totalPrice, setTotalPrice] = useState(0); 
  const [isDarkTheme, setIsDarkTheme] = useState(false);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch("https://dummyjson.com/products");
        const result = await response.json();
        setData(result.products);
      } catch (error) {
        console.error("Error While Fetching Data", error);
      }
    };
    fetchData();
  }, []);

  useEffect(() => {
    
    const calculateTotalQuantityAndPrice = () => {
      const totalQuantity = cart.reduce((acc, cartItem) => {
        return acc + cartItem.quantity;
      }, 0);

      const totalPrice = cart.reduce((acc, cartItem) => {
        return acc + cartItem.price * cartItem.quantity;
      }, 0);

      setTotalQuantity(totalQuantity);
      setTotalPrice(totalPrice);
    };

    calculateTotalQuantityAndPrice();
  }, [cart, data]);

  const addToCart = (product) => {
    const existingProductIndex = cart.findIndex((item) => item.id === product.id);
    if (existingProductIndex !== -1) {
     
      const updatedCart = [...cart];
      updatedCart[existingProductIndex].quantity += 1;
      setCart(updatedCart);
    } else {
     
      const updatedCart = [...cart, { ...product, quantity: 1 }];
      setCart(updatedCart);
    }

   
    localStorage.setItem("cart", JSON.stringify(cart));
  };

  const removeFromCart = (productId) => {
    const existingProductIndex = cart.findIndex((item) => item.id === productId);
    if (existingProductIndex !== -1) {
      const updatedCart = [...cart];
      if (updatedCart[existingProductIndex].quantity > 1) {
       
        updatedCart[existingProductIndex].quantity -= 1;
      } else {
        
        updatedCart.splice(existingProductIndex, 1);
      }
      setCart(updatedCart);
    }

    
    localStorage.setItem("cart", JSON.stringify(cart));
  };

  const toggleTheme = () => {
    setIsDarkTheme(!isDarkTheme);
  };

  return (
    <div className={`product-cart ${isDarkTheme ? "dark-theme" : "light-theme"}`}>
      <h3 id="quantity" className="mt-3">Total Product in Cart: {totalQuantity}</h3>
      <h3 id="totalPrice">Total Price: Rs.{totalPrice.toFixed(2)}</h3>
      <button className="btn btn-primary mb-3" onClick={toggleTheme}>
        Change Theme
      </button>
      <h2 className="mb-4">Product List</h2>
      <div className="row">
        {data.map((product) => (
          <div key={product.id} className="col-md-4 mb-4">
            <div className="card product-item">
              <img src={product.thumbnail} className="card-img-top product-image" alt="Thumbnail" />
              <div className="card-body">
                <h5 className="card-title">{product.title}</h5>
                <p className="card-text">Description: {product.description}</p>
                <p className="card-text">Price: Rs.{product.price.toFixed(2)}</p>
                <span className="product-quantity">
                  Quantity: {(cart.find((item) => item.id === product.id) || {}).quantity || 0}
                </span>
                <br />
                <button className="btn btn-success mr-2" onClick={() => addToCart(product)}>
                  Add to Cart
                </button>
                <button className="btn btn-danger" onClick={() => removeFromCart(product.id)}>
                  Remove From Cart
                </button>
              </div>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
  
}

export default ApiFetching;

