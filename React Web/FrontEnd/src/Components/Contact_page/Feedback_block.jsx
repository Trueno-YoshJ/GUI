import React, { useContext } from "react";
import { FeedbackContext } from "./Feedback_data";

const FeedbackBlock = () => {
  const { feedbacks } = useContext(FeedbackContext);

  return (
    <div style={{ padding: "20px", fontFamily: "Arial, sans-serif" }}>
      <h2>Customer Feedback Overview</h2>
      {feedbacks.length > 0 ? (
        <table
          style={{
            width: "100%",
            borderCollapse: "collapse",
            marginBottom: "20px",
          }}
        >
          <thead>
            <tr style={{ backgroundColor: "#f4f4f4", textAlign: "left" }}>
              <th style={{ padding: "10px", border: "1px solid #ddd" }}>Customer Name</th>
              <th style={{ padding: "10px", border: "1px solid #ddd" }}>Feedback</th>
              <th style={{ padding: "10px", border: "1px solid #ddd" }}>Rating</th>
            </tr>
          </thead>
          <tbody>
            {feedbacks.map((feedback) => (
              <tr key={feedback.id}>
                <td style={{ padding: "10px", border: "1px solid #ddd" }}>{feedback.customer}</td>
                <td style={{ padding: "10px", border: "1px solid #ddd" }}>{feedback.comment}</td>
                <td style={{ padding: "10px", border: "1px solid #ddd" }}>{feedback.rating}/5</td>
              </tr>
            ))}
          </tbody>
        </table>
      ) : (
        <p>No feedback available yet.</p>
      )}
    </div>
  );
};

export default FeedbackBlock;
