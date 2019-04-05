let users = [];
let mainUser;
const baseURL = "https://randomuser.me/api?results=10";

function loadUsers() {
    fetch(baseURL)
        .then((response) => {
            return response.json();
        })
        .then((data) => {
            users = data;
            mainUser = users.results[0];
            displayUsers();
            displayMainUser();
        })
        .catch((err) => console.log(err));
}

function displayUsers() {
    console.log("Displaying Users...");
    const container = document.querySelector('#otherUsers tbody');
    users.results.forEach((user) => {

        if (user != mainUser) {
            let tr = document.createElement('tr');
            let th1 = document.createElement('td');
            let th2 = document.createElement('td');
            let th3 = document.createElement('td');
            let th4 = document.createElement('td');
            let image = document.createElement('img');

            image.src = user.picture.thumbnail;
            th2.innerText = user.name.first;
            th3.innerText = user.email;
            th4.innerText = user.phone;

            th1.appendChild(image);
            tr.appendChild(th1);
            tr.appendChild(th2);
            tr.appendChild(th3);
            tr.appendChild(th4);
            container.appendChild(tr);
        }
    })
}

function displayMainUser() {
    const userPhoto = document.getElementById('user-photo').src = mainUser.picture.large;
    const userBigName = document.getElementById('name').innerText = `${ mainUser.name.first } ${ mainUser.name.last }`;
    const userName = document.getElementById('fullName').innerText = `${ mainUser.name.title } ${ mainUser.name.first } ${ mainUser.name.last }`;
    const userDOB = document.getElementById('dob').innerText = mainUser.dob.date;
    const userJoined = document.getElementById('joined').innerText = mainUser.registered.date;
    const userPhone = document.getElementById('phone').innerText = mainUser.phone;
    const userAddress = document.getElementById('address').innerText = mainUser.location.street;
    const userEmail = document.getElementById('email').innerText = mainUser.email;
    const userUsername = document.getElementById('username').innerText = mainUser.login.username;
    const userPassword = document.getElementById('password');
    for (let i = 0; i < mainUser.login.password.length; i++) {
        userPassword.innerText += '*';
    }
}

function removeUsers() {
    const container = document.querySelector('#otherUsers tbody');
    container.innerText = '';
}

document.addEventListener('DOMContentLoaded', () => {
    loadUsers();
    const refreshButton = document.getElementById('refreshButton');
    refreshButton.addEventListener('click', () => {
        users = [];
        removeUsers();
        loadUsers();
    });
});

