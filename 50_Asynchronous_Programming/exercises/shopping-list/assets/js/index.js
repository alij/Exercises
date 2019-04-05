let groceries = [];

const button = document.getElementsByClassName('loadingButton');
button.addEventListener('click', function() {
    loadGroceries();
    button.disable = true;
})

function loadGroceries() {

    fetch('assets/data/shopping-list.json')
        .then((response) => {
            return response.json;
        })
        .then((data) => {
            groceries = data;
            displayGroceries();
        })
        .catch((err) => console.log(err));
}

function displayGroceries() {



    reviews.forEach((item) => {
        
        const li = getElementByTag('li');
        li.innerText = item.name + item.completed;
        
        

    })
}

