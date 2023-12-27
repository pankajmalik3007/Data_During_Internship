
import React, { useState } from "react";
import { Outlet, NavLink } from "react-router-dom";

const Layout = ({ cartQuantity: propCartQuantity }) => {
  const [cartQuantity, setCartQuantity] = useState(propCartQuantity);

  const updateCartQuantity = (quantity) => {
    setCartQuantity(cartQuantity + quantity);
  };

  return (
    <>
      <nav className="navbar navbar-expand-lg navbar-light bg-success">
        <div className="container">
          <button
            className="navbar-toggler"
            type="button"
            data-bs-toggle="collapse"
            data-bs-target="#navbarNav"
            aria-controls="navbarNav"
            aria-expanded="false"
            aria-label="Toggle navigation"
          >
            <span className="navbar-toggler-icon"></span>
          </button>
          <div className="collapse navbar-collapse" id="navbarNav">
            <ul className="navbar-nav ms-auto">
            <li className="nav-item">
          <NavLink className="nav-link" activeClassName="active" to="/Home">
            Home
          </NavLink>
        </li>
        <li className="nav-item">
          <NavLink className="nav-link" activeClassName="active" to="/About">
            About
          </NavLink>
        </li>
        <li className="nav-item">
          <NavLink className="nav-link" activeClassName="active" to="/Products">
            Products
          </NavLink>
        </li>
        <li className="nav-item">
          <NavLink className="nav-link" activeClassName="active" to="/CartPage">
            Cart
          </NavLink>
        </li>
             </ul>
          </div>
        </div>
      </nav>
      <Outlet updateCartQuantity={updateCartQuantity} />
      
    </>
  );
};

export default Layout;

