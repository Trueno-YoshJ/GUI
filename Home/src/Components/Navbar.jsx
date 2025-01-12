import { Link } from "react-router-dom"
import './Navbar.css'

export function Navbar(){
    return(
        <div className = "navbar" >
        <Link to ="/">
            <button>Home</button>
        </Link>
        <Link to ="/page1">
            <button>Page1</button>
        </Link>
        <Link to ="/log in">
            <button>Login</button>
        </Link>
        </div>
    )
}