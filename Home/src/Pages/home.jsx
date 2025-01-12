import React from "react";
import { Link } from "react-router-dom";
import './Topbar.css';
import toplogo from './toplogo.png';
import { Bar } from 'react-chartjs-2'; 
import { Chart as ChartJS } from "chart.js/auto";

export function Home() {
    const data = {
        labels: ['A', 'B', 'C'], 
        datasets: [
            {
                label: 'Revenue',  
                data: [200, 300, 400],  
                backgroundColor: 'rgba(75, 192, 192, 0.2)', 
                borderColor: 'rgba(75, 192, 192, 1)',  
                borderWidth: 1, 
            },
        ],
    };

    return (
        <>
            <div className="Head">
                <img src={toplogo} id="logo" alt="Logo" />
                {/* <h1>Dashboard</h1> */}
                <h2>fuygiuhio</h2>
                {/* <Link to="/">Home </Link>
                <Link to="/page1">Page1</Link> */}
                <div className="blocks">
                    <div className="sale-progression">
                        <h3>Sales Progression</h3>
                        <p><strong>Current Status:</strong> 75% of target reached</p>
                        <p><strong>Sales Progress:</strong> $75,000</p>
                        <p><strong>Next Milestone:</strong> $80,000 target in the next week</p>
                        <p><strong>Remaining Time:</strong> 5 days left</p>
                        <p><strong>Last Update:</strong> January 8, 2025</p>
                    </div>
                    <div className="stock-summary">
                        <h3>Stock Summary</h3>
                        <p><strong>Current Stock:</strong> 95.45%</p>
                        <p><strong>Stock value:</strong> $475,000</p>
                        <p><strong>Stock Turnover Rate:</strong> 4.5</p>
                        <p><strong>Damaged stock:</strong> 4.55%</p>
                        <p><strong>Last Update:</strong> January 8, 2025</p>
                    </div>
                    <div className="sales-graph">
                        <Bar data={data} />
                    </div>
                </div>
                <div className="stock-level">
                    
                </div>
            </div>
        </>
    );
}
