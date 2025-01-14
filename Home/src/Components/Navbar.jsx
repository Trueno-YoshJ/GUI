import { Link } from "react-router-dom"
import './Navbar.css'

export function Navbar(){
    return(
        <div className = "navbar" >
        <Link to ="/">
            <button>Home</button>
        </Link>
        <Link to ="/page1">
            <button>Inventory</button>
        </Link>
        <Link to ="/page2">
            <button>Feedback</button>
        </Link>
        </div>
    )
}