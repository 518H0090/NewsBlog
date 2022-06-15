import React from "react";
import { Link } from "react-router-dom";

export default function Nav() {
  return (
    <nav className="navbar navbar-expand-lg bg-light">
      <div className="container-fluid">
        <span className="navbar-brand ms-md-5 bg-info text-white p-2 border border-2 border-info rounded-pill ">
          TrungHieuIT1204
        </span>
        <button
          className="navbar-toggler"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target="#navbarNavAltMarkup"
          aria-controls="navbarNavAltMarkup"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span className="navbar-toggler-icon"></span>
        </button>
        <div
          className="collapse navbar-collapse me-md-5 d-md-flex justify-content-end"
          id="navbarNavAltMarkup"
        >
          <div className="navbar-nav">
            <span className="nav-link active" aria-current="page">
              <Link to="/" style={{ textDecoration: "none" }}>
                Home
              </Link>
            </span>
            <span className="nav-link text-decoration-none">
              <Link to="/login" style={{ textDecoration: "none" }}>
                Login
              </Link>
            </span>
            <span className="nav-link text-decoration-none">
              <Link to="/register" style={{ textDecoration: "none" }}>
                Register
              </Link>
            </span>
          </div>
        </div>
      </div>
    </nav>
  );
}
