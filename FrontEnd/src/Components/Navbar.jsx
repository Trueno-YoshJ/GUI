import { Link, useNavigate } from "react-router-dom";
import "./Navbar.css";

export function Navbar() {
  const navigate = useNavigate();

  const handleLogout = () => {
    localStorage.removeItem("isLoggedIn");
    navigate("/login");
  };

  return (
    <div className="navbar">
      <Link to="/">
        <button>Home</button>
      </Link>
      <Link to="/page1">
        <button>Inventory</button>
      </Link>
      <Link to="/page2">
        <button>Feedback</button>
      </Link>
      <button onClick={handleLogout}>Logout</button>
    </div>
  );
}
