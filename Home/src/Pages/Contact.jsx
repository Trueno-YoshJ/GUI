import React, { useState } from "react";
import FeedbackBlock from "../Components/Contact_page/Feedback_block";
import FeedbackData from "../Components/Contact_page/Feedback_data";
import FeedbackForm from "../Components/Contact_page/Feedback_form";
import '../Components/Contact_page/Feedback_page.css'
import logo from "../images/toplogo.png";
import top_image from "../images/feedback.jpg";

export function Contact() {
  return (
    <>
      <img src = {logo} id ="logo" alt = "logo"/>
      <img src = {top_image} id = "top_image1" alt = "top_image"/>
      <FeedbackData>
        <div className="container">
          <FeedbackForm />
          <FeedbackBlock />
        </div>
      </FeedbackData>
      </>
  );
}
