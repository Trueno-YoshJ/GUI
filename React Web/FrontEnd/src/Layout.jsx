import { Navbar } from "./Components/Navbar"
import { Outlet } from "react-router-dom"
import './Layout.css'

export function Layout(){
    return(
        <>
        <Navbar/>
        <main>
            <Outlet/>
        </main>
        </>
    )
}