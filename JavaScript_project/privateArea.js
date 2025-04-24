const currentUserSession = sessionStorage.getItem('user');
const currentUser = JSON.parse(currentUserSession);
document.getElementById('userText').innerHTML = currentUser.userName;


$.ajax({
    url: './data/store.json',
    success: (data) => {
        const { product } = data;
        store.products = product;
    }
});

document.getElementById('NameUserSpan').innerHTML=currentUser.userName;
document.getElementById('passwordSpan').innerHTML=currentUser.password;
