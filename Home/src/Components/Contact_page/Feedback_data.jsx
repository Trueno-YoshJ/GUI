import React, { useState } from "react";

export const FeedbackContext = React.createContext();

const FeedbackData = ({ children }) => {
  const [feedbacks, setFeedbacks] = useState([
    { id: 1, customer: "John Doe", comment: "Great quality furniture!", rating: 5 },
    { id: 2, customer: "Jane Smith", comment: "Loved the design and finish!", rating: 4 },
  ]);

  const addFeedback = (newFeedback) => {
    setFeedbacks([
      ...feedbacks,
      { id: feedbacks.length + 1, ...newFeedback, rating: Number(newFeedback.rating) },
    ]);
  };

  return (
    <FeedbackContext.Provider value={{ feedbacks, addFeedback }}>
      {children}
    </FeedbackContext.Provider>
  );
};

export default FeedbackData;
