//menu icon
document.querySelector('.menu-icon').addEventListener('click', function () {
    const dropdownMenu = document.querySelector('.dropdown-menu');
    dropdownMenu.style.display = dropdownMenu.style.display === 'block' ? 'none' : 'block';
});
  

document.addEventListener('click', function (event) {
  const menuIcon = document.querySelector('.menu-icon');
  const dropdownMenu = document.querySelector('.dropdown-menu');
  
  if (!menuIcon.contains(event.target)) {
    dropdownMenu.style.display = 'none';
  }
});
//New Design icons
const imageContainers = document.querySelectorAll('.image-container');

imageContainers.forEach(container => {
    const image = container.querySelector('.image');
    const textOverlay = container.querySelector('.text-overlay');

    container.addEventListener('mouseenter', () => {
        image.style.transform = 'scale(1.1)'; 
        image.style.opacity = '0.8';
        textOverlay.style.display = 'block';
    });

    container.addEventListener('mouseleave', () => {
        image.style.transform = 'scale(1)'; 
        image.style.opacity = '1'; 
        textOverlay.style.display = 'none';
    });
});
//feedback form
const modal = document.getElementById("feedbackModal");
const feedbackLink = document.getElementById("feedbackLink");
const closeModalBtn = document.getElementById("closeModalBtn");

feedbackLink.onclick = function () {
    modal.style.display = "block";
    modal.classList.add('show');
}

closeModalBtn.onclick = function () {
    modal.style.display = "none";
    modal.classList.remove('show');
}
t
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
        modal.classList.remove('show'); 
    }
}

const feedbackForm = document.getElementById("feedbackForm");
feedbackForm.addEventListener("submit", function (e) {
    e.preventDefault();

    const name = document.getElementById("name").value;
    const email = document.getElementById("email").value;
    const feedback = document.getElementById("feedback").value;

    console.log("Name:", name);
    console.log("Email:", email);
    console.log("Feedback:", feedback);

    modal.style.display = "none";
    modal.classList.remove('show');

    alert("Thank you for your feedback!");
});
