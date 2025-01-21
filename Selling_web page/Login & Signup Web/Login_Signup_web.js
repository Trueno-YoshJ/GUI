 
 const signUpContainer = document.getElementById('sign-up');
 const logInContainer = document.getElementById('log-in');

 
 document.querySelectorAll('.link a').forEach(link => {
     link.addEventListener('click', event => {
         event.preventDefault();

         
         signUpContainer.classList.add('hidden');
         logInContainer.classList.add('hidden');

         
         setTimeout(() => {
             const target = document.querySelector(link.getAttribute('href'));
             if (target) {
                 target.classList.remove('hidden');
             }
         }, 600); 
     });
 });