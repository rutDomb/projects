const currentUserSession = sessionStorage.getItem('user');
const currentUser = JSON.parse(currentUserSession);
document.getElementById('userText').innerHTML = currentUser.userName;
const searchParams = new URLSearchParams(location.search);
const productCode = searchParams.get('productCode');
const thisProduct = document.getElementById('thisProduct');
$.ajax({
    url: './Data/store.json',
    success: (data) => {
        const { product } = data;
        store.products = product;
        const currentProduct = data.product.find(pr => pr.code === productCode);
        sessionStorage.setItem('currentProduct', JSON.stringify(currentProduct));
        const titleP = document.getElementById('titleP');
        const nameP = document.createElement('h2');
        nameP.id = 'nameP';
        nameP.innerHTML = currentProduct.prouductName;
        const priceP = document.createElement('h3');
        priceP.id = 'priceP';
        priceP.innerHTML = currentProduct.price;
        const UnitsInStock = document.getElementById('UnitsInStock');
        UnitsInStock.innerHTML = currentProduct.UnitsInStock;
        titleP.append(nameP);
        titleP.append(priceP);
        const imgP = document.createElement('img');
        imgP.id = 'imgP';
        imgP.src = `/${currentProduct.url}`;
        thisProduct.append(imgP);
    }
})

const add = document.getElementById('add');
let p = document.querySelector('p');
// בעת לחיצה על כפתןר הפלוס
add.onclick = () => {
    const currentProduct = JSON.parse(sessionStorage.getItem('currentProduct'));
    let num = parseInt(p.innerHTML);
    num = num + 1;
    if (num <= currentProduct.UnitsInStock) {
        p.innerHTML = num;
        let currentAmount = p.innerHTML;
        currentProduct.Amount = p.innerHTML;
    }
}

// בעת לחיצה על כפתור המינוס
const less = document.getElementById('less');
less.onclick = () => {
    if (p.innerHTML > 1)
        p.innerHTML = p.innerHTML - 1;
}


const amount = document.getElementById('amount');
const AddToBasket = document.getElementById('AddToBasket');
// בעת לחיצה על כפתור הוספה לסל
AddToBasket.onclick = () => {
    const currentUser = JSON.parse(sessionStorage.getItem('user'));
    const currentProduct = JSON.parse(sessionStorage.getItem('currentProduct'));
    currentProduct.Amount += parseInt(amount.innerHTML);
    let find = false;
    if (currentUser.basket.length === 0) {
        currentUser.basket.push(currentProduct);
    }
    else {
        currentUser.basket.forEach(p => {
            if (p.code === currentProduct.code) {
                find = true;
                let amount1 = p.Amount;
                amount1 += parseInt(amount.innerHTML);
                p.Amount = amount1;
            }
        });
        if (find === false) {
            currentUser.basket.push(currentProduct);
        }
    }
    const arrUsers = JSON.parse(localStorage.getItem('arrUsers'));
    arrUsers.forEach(user => {
        if (user.password == currentUser.password)
            user.basket.push(currentProduct);
    });
    localStorage.setItem('arrUsers', JSON.stringify(arrUsers));
    document.getElementById('basketDiv').style.display = 'block';
    document.getElementById('overlay').style.display = 'block';
    sessionStorage.setItem('currentProduct', JSON.stringify(currentProduct));
    sessionStorage.setItem('user', JSON.stringify(currentUser));  
    setbasketProduct(currentUser.basket);
    document.getElementById('forPayment').style.display = 'block';
    document.getElementById('forPayment').style.marginLeft = '40px'
    updateSum();
}



    



