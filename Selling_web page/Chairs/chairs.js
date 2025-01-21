//items window size changer
function updateGridLayout() {
    const container = document.querySelector('.container');
    const windowWidth = window.innerWidth;

    if (windowWidth <= 600) {
        container.style.gridTemplateColumns = 'repeat(1, 1fr)';
    } else if (windowWidth <= 900) {
        container.style.gridTemplateColumns = 'repeat(2, 1fr)';
    } else if (windowWidth <= 1200) {
        container.style.gridTemplateColumns = 'repeat(3, 1fr)';
    } else {
        container.style.gridTemplateColumns = 'repeat(4, 1fr)';
    }
}

updateGridLayout();

window.addEventListener('resize', updateGridLayout);

//Add to Cart
let cart = [];

        function addToCart(itemName, itemPrice) {
            cart.push({ name: itemName, price: itemPrice });
            alert(`${itemName} has been added to the cart!`);
        }

        function viewCart() {
            const cartModal = document.getElementById("cartModal");
            const cartItemsDiv = document.getElementById("cartItems");
            cartItemsDiv.innerHTML = ""; 

            if (cart.length === 0) {
                cartItemsDiv.innerHTML = "<p>Your cart is empty.</p>";
            } else {
                cart.forEach((item, index) => {
                    const itemDiv = document.createElement("div");
                    itemDiv.classList.add("cart-item");
                    itemDiv.innerHTML = `
                        ${item.name} - $${item.price.toFixed(2)} 
                        <button class="remove-btn" onclick="removeFromCart(${index})">Remove</button>
                    `;
                    cartItemsDiv.appendChild(itemDiv);
                });
            }

            cartModal.style.display = "flex";
        }

        function removeFromCart(index) {
            cart.splice(index, 1);
            viewCart(); 
        }

        function closeCart() {
            const cartModal = document.getElementById("cartModal");
            cartModal.style.display = "none";
        }

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