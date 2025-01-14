import React, { useState } from 'react';

export function SalesProgressBar() {

  const monthlyGoal = 40000;

  const [currentSales, setCurrentSales] = useState(25000);

  const progress = (currentSales / monthlyGoal) * 100;

  const progressBarContainerStyle = {
    width: '250px',
    backgroundColor: '#e0e0e0',
    borderRadius: '5px',
    overflow: 'hidden',
    margin: '20px 0',
  };

  const progressBarStyle = {
    width: `${progress}%`,
    height: '30px',
    backgroundColor: progress >= 100 ? 'green' : 'orange',
    transition: 'width 0.3s ease',
  };

  return (
    <div>
      <div style={progressBarContainerStyle}>
        <div style={progressBarStyle}></div>
      </div>
      <div style={{ marginTop: '10px' }}>
        <strong>{Math.min(progress, 100).toFixed(1)}% of goal achieved</strong>
      </div>
      <div style={{ marginTop: '10px' }}>
        <button onClick={() => setCurrentSales(currentSales + 1000)}>Add $1000</button>
      </div>
    </div>
  );
}
