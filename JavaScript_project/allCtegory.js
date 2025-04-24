const currentUserSession = sessionStorage.getItem('user');
const currentUser = JSON.parse(currentUserSession);
document.getElementById('userText').innerHTML = currentUser.userName;
const arrProducts = JSON.parse(sessionStorage.getItem('arrProducts'))
// פונקציה המציגה את המוצרים על המסך
const setProduct = (filter) => {
    const arrLeanth=document.getElementById('arrLeanth')
    arrLeanth.textContent = parseInt(filter.length);
    allProducts.innerHTML = '';
    filter.forEach(p => {
        const firstPicture = document.createElement('div')
        const { category, prouductName, price, url, code, UnitsInStock } = p;
        const div = document.createElement('div');
        const buttonPicture = document.createElement('a');
        buttonPicture.href=`./product.html?productCode=${code}`
        div.append(buttonPicture)
        div.id = "textPicture";
        div.classList.add('picture')
        buttonPicture.innerHTML = `<img src="/${url}" class="buttonPictureClass"><p>${prouductName}<br>${price}</p></a>`;
        allProducts.append(div);
    })
}

setProduct(arrProducts);
$.ajax({
    url: './data/store.json',
    success: (data) => {
        const { product } = data;
        store.products = product;
        const { Header } = data;
        store.Header = Header;
    }
});
const secondLine = document.getElementById('secondLine');
const headerPicture = JSON.parse(sessionStorage.getItem('headerPicture'));
// פונקציה המציגה את התמונות הראשיות על המסך
const setHeader = (headerPicture) => {
    secondLine.innerHTML = '';
    headerPicture.forEach(p => {
        const { img, Caption, category } = p;
        const firstPicture = document.createElement('div');
        firstPicture.id = "PictureHeader";
        firstPicture.classList.add('pictureHeader');
        if (category !== 'כל המוצרים' && category !== 'חדש')
            firstPicture.innerHTML = `<img src="${img}">`;
        const text = document.createElement('h2')
        text.innerHTML = `<h2>${Caption}</h2>`;
        if (category === 'כל המוצרים' || category === 'חדש') {
            text.id = 'titleBlack';
        }
        else {
            text.id = 'titlewhite'
        }
        firstPicture.append(text);
        secondLine.append(firstPicture);
    })
}
setHeader(headerPicture);

// פונקציה המעדכנת את המחיר לתשלום 
const countPay = document.getElementById('countPay')
if (currentUser) {
    if (currentUser.basket.length > 0) {
        currentUser.basket.forEach(p => {
            let numeString = p.price.replace('₪', '').trim();
            sum = sum + parseFloat(numeString);;
        });
        countPay.innerHTML = `₪ לתשלום  ${sum.toFixed(2)} `
    }
}




