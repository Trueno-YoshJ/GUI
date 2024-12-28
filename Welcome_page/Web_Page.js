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

          
  
  