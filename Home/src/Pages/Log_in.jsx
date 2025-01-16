import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import "../Components/Login.css";
import { addUser, findUser, findUserByEmail } from "../Components/User";
import loginImage from "../images/login.jpg";

export function Login() {
  const [formType, setFormType] = useState("login"); 
  const [formData, setFormData] = useState({ email: "", password: "", username: "" });
  const navigate = useNavigate();

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleLogin = (e) => {
    e.preventDefault();
    const userExists = findUser(formData.email, formData.password);
    if (userExists) {
      localStorage.setItem("isLoggedIn", "true");
      navigate("/");
    } else {
      alert("Invalid email or password. Please try again.");
    }
  };

  const handleSignUp = (e) => {
    e.preventDefault();
    const userExists = findUserByEmail(formData.email);
    if (userExists) {
      alert("User already exists with this email.");
      return;
    }
    const newUser = { email: formData.email, password: formData.password, username: formData.username };
    addUser(newUser);
    localStorage.setItem("isLoggedIn", "true");
    navigate("/");
  };

  return (
    <div className="auth-container">
      <div className="auth-block">
        <h2>{formType === "login" ? "Login" : "Sign Up"}</h2>
        <form onSubmit={formType === "login" ? handleLogin : handleSignUp}>
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
      <div className="image-block">
        <img src={loginImage} alt="Login Illustration" className="auth-image" />
      </div>
    </div>
  );
}
