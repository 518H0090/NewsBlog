import React from "react";
import "../styles/Register.css";

export default function Register() {
  return (
    <main className="form-signin w-100 m-auto">
      <form>
        <h1 className="h3 mb-3 fw-normal">Please Fill in the form</h1>

        <div className="form-floating">
          <input
            type="text"
            className="form-control"
            id="floatingInput"
            placeholder="Type your name"
          />
          <label for="floatingInput">Your Name</label>
        </div>

        <div className="form-floating">
          <input
            type="email"
            className="form-control"
            id="floatingInput"
            placeholder="name@example.com"
          />
          <label for="floatingInput">Email address</label>
        </div>
        <div className="form-floating">
          <input
            type="password"
            className="form-control"
            placeholder="Password"
          />
          <label for="floatingPassword">Password</label>
        </div>

        <button className="w-100 btn btn-lg btn-primary" type="submit">
          Sign up
        </button>
        <p className="mt-5 mb-3 text-muted">&copy; 2022</p>
      </form>
    </main>
  );
}
