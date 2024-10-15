document.getElementById('registerForm').addEventListener('submit', function(event) {
    const regPassword = document.getElementById('regPassword').value;
    const confirmPassword = document.getElementById('confirmPassword').value;
    const username = document.getElementById('name').value; // Hozzáadva a felhasználónév

    const passwordError = document.getElementById('passwordError');
    const confirmPasswordError = document.getElementById('confirmPasswordError');

    passwordError.textContent = '';
    confirmPasswordError.textContent = '';

    const passwordRegex = /^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$/;

    let valid = true;

    if (!passwordRegex.test(regPassword)) {
        passwordError.textContent = 'A jelszónak legalább 6 karakterből kell állnia, és tartalmaznia kell 1 betűt és 1 számot.';
        valid = false;
    }

    if (regPassword !== confirmPassword) {
        confirmPasswordError.textContent = 'A jelszavak nem egyeznek.';
        valid = false;
    }

    if (valid) {
        event.preventDefault(); // Megakadályozzuk az űrlap elküldését
        window.location.href = `welcome.html?username=${encodeURIComponent(username)}`; // Átirányítás a welcome.html oldalra
    }
});
