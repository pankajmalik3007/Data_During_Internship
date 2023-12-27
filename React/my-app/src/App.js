
import React, { useState } from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Layout from './Component/Layout';
import Home from './Component/Home';
import About from './Component/About';
import NoPage from './Component/NoPage';
import ApiFetching from './Component/ApiFetching';
import CartPage from './Component/CartPage';
const App = () => {
  const [cartQuantity, setCartQuantity] = useState(0);
  const updateCartQuantity = (quantity) => {
  setCartQuantity(cartQuantity + quantity);
  };
  return (
    <div>
      <Router>
        <Routes>
          <Route path="/" element={<Layout cartQuantity={cartQuantity} />}>
            <Route index element={<Home />} />
            <Route path="Home" element={<Home />} />
            <Route path="About" element={<About />} />
            
            <Route
              path="/products"
              element={<ApiFetching updateCartQuantity={updateCartQuantity} cartQuantity={cartQuantity} />}
            />
              <Route path="CartPage" element={<CartPage cart={cartQuantity} />} /> 

            <Route path="*" element={<NoPage />} />
          </Route>
        </Routes>
      </Router>

    </div>
  );
};
export default App;