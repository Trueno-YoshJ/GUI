 // Get references to the containers
 const signUpContainer = document.getElementById('sign-up');
 const logInContainer = document.getElementById('log-in');

 // Add event listeners for the links
 document.querySelectorAll('.link a').forEach(link => {
     link.addEventListener('click', event => {
         event.preventDefault();

         // Hide both containers temporarily
         signUpContainer.classList.add('hidden');
         logInContainer.classList.add('hidden');

         // Wait for the transition to complete before showing the next container
         setTimeout(() => {
             const target = document.querySelector(link.getAttribute('href'));
             if (target) {
                 target.classList.remove('hidden');
             }
         }, 600); // Matches the CSS transition duration
     });
 });