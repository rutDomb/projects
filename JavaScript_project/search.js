const currentUserSession = sessionStorage.getItem('user');
const currentUser = JSON.parse(currentUserSession);
document.getElementById('userText').innerHTML = currentUser.userName;
const arrProducts = JSON.parse(sessionStorage.getItem('arrProducts'));

// פונקציה המציגה את המוצרים על המסך
const setProduct = (filter) => {
    const searchBy=document.getElementById('searchBy');
    const searchBySession=sessionStorage.getItem('searchBy')
    searchBy.innerHTML=searchBySession;
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
};
setProduct(arrProducts);

$.ajax({
    url: './data/store.json',
    success: (data) => {
        const { product } = data;
        store.products = product;
    }
});




