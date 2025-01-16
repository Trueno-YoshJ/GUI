import { HashRouter as Router, Routes, Route, Navigate } from "react-router-dom";
import { Home } from "./Pages/home";
import { Page1 } from "./Pages/Page1";
import { Layout } from "./Layout";
import { Login } from "./Pages/Log_in";
import { Contact } from "./Pages/Contact";

function PrivateRoute({ children }) {
  const isLoggedIn = localStorage.getItem("isLoggedIn") === "true";
  return isLoggedIn ? children : <Navigate to="/login" />;
}

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/login" element={<Login />} />
        <Route
          element={
            <PrivateRoute>
              <Layout />
            </PrivateRoute>
          }
        >
          <Route path="/" element={<Home />} />
          <Route path="/page1" element={<Page1 />} />
          <Route path="/page2" element={<Contact />} />
        </Route>
      </Routes>
    </Router>
  );
}

export default App;
