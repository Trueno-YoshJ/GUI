import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import "../Components/Login.css";
import loginImage from "../images/login.jpg";
import toplogo from "../images/toplogo.png";

export function Login() {
  const [formType, setFormType] = useState("login");
  const [formData, setFormData] = useState({ email: "", password: "", username: "" });
  const navigate = useNavigate();

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    localStorage.setItem("isLoggedIn", "true");
    navigate("/");
  };

  return (
    <div className="auth-container">
      <div className="auth-block">
        <h2>{formType === "login" ? "Login" : "Sign Up"}</h2>
        <form onSubmit={handleSubmit}>
          {formType === "signup" && (
            <div>
              <label>Username</label>
              <input
                type="text"
                name="username"
                placeholder="Enter your name"
                value={formData.username}
                onChange={handleChange}
                required
              />
            </div>
          )}
          <div>
            <label>Email</label>
            <input
              type="email"
              name="email"
              placeholder="Enter your email"
              value={formData.email}
              onChange={handleChange}
              required
            />
          </div>
          <div>
            <label>Password</label>
            <input
              type="password"
              name="password"
              placeholder="Enter the password"
              value={formData.password}
              onChange={handleChange}
              required
            />
          </div>
          <button type="submit">{formType === "login" ? "Login" : "Sign Up"}</button>
        </form>
        <p className="toggle-text">
          {formType === "login" ? (
            <>
              Don't have an account?{" "}
              <span
                className="toggle-link"
                onClick={() => setFormType("signup")}
              >
                Sign Up
              </span>
            </>
          ) : (
            <>
              Already have an account?{" "}
              <span
                className="toggle-link"
                onClick={() => setFormType("login")}
              >
                Login
              </span>
            </>
          )}
        </p>
      </div>
      <div className = "main-Logo">
          <img src = {toplogo} alt = "Logo" />
      </div>
      <div className="image-block">
        <img src={loginImage} alt="Login Illustration" className="auth-image" />
      </div>
    </div>
  );
}
