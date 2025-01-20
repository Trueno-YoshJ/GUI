import React from "react";
import { Link } from "react-router-dom";
import "./Topbar.css"
import toplogo from '../images/toplogo.png';
import { Bar } from 'react-chartjs-2'; 
import { Chart as ChartJS } from "chart.js/auto";
import { SalesProgressBar } from "../Components/Salesbar";
import topimage from '../images/title_image.png'

export function Home() {
    const data = {
        labels: ['Week1', 'Week2', 'Week3','Week4'], 
        datasets: [
            {
                label: 'Sales',  
                data: [20000, 30000, 28000,32000],  
                backgroundColor: 'rgba(31, 210, 210, 0.2)', 
                borderColor: 'rgba(75, 192, 192, 1)',  
                borderWidth: 1, 
            },
        ],
    };
    const pageStyle = {
        display: 'flex',
        flexDirection: 'column',
        justifyContent: 'center',
        alignItems: 'center',
        height: '30vh',
        textAlign: 'center',
        position:'relative',
      };


    return (
        <>
            <img src = {topimage} id ="topimage" alt = "bar_image"/>
            <div className="Head">
                <img src={toplogo} id="logo" alt="Logo" />
                {/* <h1>Dashboard</h1> */}
                <h2>fuygiuhio</h2>
                {/* <Link to="/">Home </Link>
                <Link to="/page1">Page1</Link> */}
                <div className="blocks">
                    <div className="sale-progression">
                        <h3>Sales Progression</h3>
                        <p><strong>Current Status:</strong> 62.5% of target reached</p>
                        <p><strong>Sales Progress:</strong> $35,000</p>
                        <p><strong>Next Milestone:</strong> $40,000 target in the next month</p>
                        <p><strong>Remaining Time:</strong> 5 days left</p>
                        <p><strong>Last Update:</strong> January 8, 2025</p>
                    </div>
                    <div className="stock-summary">
                        <h3>Stock Summary</h3>
                        <p><strong>Current Stock:</strong> 95.45%</p>
                        <p><strong>Stock value:</strong> $375,000</p>
                        <p><strong>Stock Turnover Rate:</strong> 4.5</p>
                        <p><strong>Damaged stock:</strong> 4.55%</p>
                        <p><strong>Last Update:</strong> January 8, 2025</p>
                    </div>
                    <div className="sales-graph">
                        <Bar data={data} />
                        <div style={pageStyle}>
                            <h2>Monthly Sales Goal</h2>
                            <SalesProgressBar /> 
                        </div>
                    </div>
                </div>
                <div className="stock-level">
                    
                </div>
            </div>
        </>
    );
}
