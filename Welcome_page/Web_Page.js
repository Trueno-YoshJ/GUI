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

          
  
  