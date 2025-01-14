import React, { useState, useContext } from "react";
import { FeedbackContext } from "./Feedback_data";

const FeedbackForm = () => {
  const { addFeedback } = useContext(FeedbackContext);
  const [newFeedback, setNewFeedback] = useState({
    customer: "",
    comment: "",
    rating: "",
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setNewFeedback({ ...newFeedback, [name]: value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    if (newFeedback.customer && newFeedback.comment && newFeedback.rating) {
      addFeedback(newFeedback);
      setNewFeedback({ customer: "", comment: "", rating: "" });
    }
  };

  return (
    <form onSubmit={handleSubmit} style={{ marginBottom: "20px" }}>
      <h2>Submit Feedback</h2>
      <div style={{ marginBottom: "10px" }}>
        <input
          type="text"
          name="customer"
          placeholder="Customer Name"
          value={newFeedback.customer}
          onChange={handleChange}
          style={{ padding: "8px", width: "300px" ,backgroundColor:"white"}}
          required
        />
      </div>
      <div style={{ marginBottom: "10px" }}>
        <textarea
          name="comment"
          placeholder="Comment"
          value={newFeedback.comment}
          onChange={handleChange}
          style={{ padding: "8px", width: "300px", height: "100px",backgroundColor:"white" }}
          required
        />
      </div>
      <div style={{ marginBottom: "10px" }}>
        <input
          type="number"
          name="rating"
          placeholder="Rating (1-5)"
          value={newFeedback.rating}
          onChange={handleChange}
          min="1"
          max="5"
          style={{ padding: "8px", width: "300px" ,backgroundColor:"white"}}
          required
        />
      </div>
      <button type="submit">
        Submit
      </button>
    </form>
  );
};

export default FeedbackForm;
