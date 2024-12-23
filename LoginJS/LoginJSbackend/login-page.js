function doLogin(username, password) {
        var xhttp = new XMLHttpRequest();

        xhttp.onreadystatechange = function () {
            if (xhttp.readyState == XMLHttpRequest.DONE) {
                if (xhttp.status == 200) {
                    console.info("Response: " + xhttp.responseText);

                    const obj = JSON.parse(xhttp.responseText);

                    console.info("JSON status message: " + obj.status);
                    console.info("JSON merged message: " + obj.merged);
                    if (obj.status === "SUCCESS" && obj.merged === username+password) {
                         
                        // If the credentials are valid, show an alert box and reload the page
                        alert("You have successfully logged in.");
                        location.reload();
                        return;
                    }

                    // Otherwise, make the login error message show (change its oppacity)
                    loginErrorMsg.style.opacity = 1;
                }
                else if (xhttp.status == 400) {
                    console.info('There was an error 400');
                }
                else {
                    console.info('Server error: something else other than 200 was returned');
                }
                return false;
            }
        };

        xhttp.open("GET", "http://localhost:5047/login?username=" + username + "&password=" + password, true);
        xhttp.send();
}


const loginForm = document.getElementById("login-form");
const loginButton = document.getElementById("login-form-submit");
const loginErrorMsg = document.getElementById("login-error-msg");

// When the login button is clicked, the following code is executed
loginButton.addEventListener("click", (e) => {
    // Prevent the default submission of the form
    e.preventDefault();
    // Get the values input by the user in the form fields
    const username = loginForm.username.value;
    const password = loginForm.password.value;

    doLogin(username, password);
})

