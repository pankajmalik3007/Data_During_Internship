// import React from "react";

// function CartPage({ selectedItems }) {
//   return (
//     <div className="container mt-3">
//       <h1>Cart</h1>
//       {selectedItems.length === 0 ? (
//         <p>Your cart is empty.</p>
//       ) : (
//         <ul>
//           {selectedItems.map((item) => (
//             <li key={item.id} className="d-flex align-items-center">
//               <img src={item.image} alt={item.title} style={{ width: "50px", marginRight: "10px" }} />
//               <div>
//                 <h6>{item.title}</h6>
//                 <p>Description: {item.description}</p>
//                 <p>Price: {item.price !== undefined ? `$${item.price.toFixed(2)}` : "N/A"}</p>
//                 <p>Quantity: {item.quantity}</p>
//               </div>
//             </li>
//           ))}
//         </ul>
//       )}
//     </div>
//   );
// }

// export default CartPage;






import React, { useState, useEffect } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import './CartPage.css';

function CartPage() {
  
  const storedCart = JSON.parse(localStorage.getItem('cart')) || [];
  const [cart, setCart] = useState(storedCart);

  useEffect(() => {
   
    setCart(storedCart);
  }, [storedCart]);

  const removeFromCart = (productId) => {
    const updatedCart = cart.map((product) => {
      if (product.id === productId) {
        
        return { ...product, quantity: product.quantity - 1 };
      }
      return product;
    });

   
    const filteredCart = updatedCart.filter((product) => product.quantity > 0);

    setCart(filteredCart);
   
    localStorage.setItem('cart', JSON.stringify(filteredCart));
  };

 
  const total = cart.reduce((acc, product) => {
    return acc + product.price * product.quantity;
  }, 0);

  return (
//     <div>
//       <h2>Cart Page</h2>
//       <h3>Total Cart Price: Rs.{total.toFixed(2)}</h3>
//       <div className="cart-items">
//         {cart.length === 0 ? (
            
//           <p>Your cart is empty.</p>
//         ) : (
//           cart.map((product) => (
//             <div key={product.id} className="cart-item">
//               <h3>{product.title}</h3>
//               <p>Price: Rs.{product.price.toFixed(2)}</p>
//               <p>Description: {product.description}</p>
//               <p>Quantity: {product.quantity}</p>
//               <p>Total Price: Rs.{product.price * product.quantity.toFixed(2)}</p>
//               <a href={product.thumbnail}>
//                 <img src={product.thumbnail} alt="Thumbnail" />
//               </a>
//               <button onClick={() => removeFromCart(product.id)}>Remove From Cart</button>
//             </div>
//           ))
//         )}
//       </div>
    
//     </div>
//   );
// }

// export default CartPage;

<div className="container mt-3">
<h2>Cart Page</h2>
<h3>Total Cart Price: Rs.{total.toFixed(2)}</h3>
<div className="row">
  {cart.length === 0 ? (
    <div className="col">
      <p>Your cart is empty.</p>
    </div>
  ) : (
    cart.map((product) => (
      <div key={product.id} className="col-md-4 mb-3">
        <div className="card">
          <img src={product.thumbnail} className="card-img-top" alt={product.title} />
          <div className="card-body">
            <h5 className="card-title">{product.title}</h5>
            <p className="card-text">Price: Rs.{product.price.toFixed(2)}</p>
            <p className="card-text">Description: {product.description}</p>
            <p className="card-text">Quantity: {product.quantity}</p>
            <p className="card-text">Total Price: Rs.{(product.price * product.quantity).toFixed(2)}</p>
            <button className="btn btn-danger" onClick={() => removeFromCart(product.id)}>
              Remove From Cart
            </button>
          </div>
        </div>
      </div>
    ))
  )}
</div>
</div>
);
}

export default CartPage;