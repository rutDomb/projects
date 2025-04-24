
const search = document.getElementById('Search');
const inputSearch = document.getElementById('inputSearch');
const Psearch = document.getElementById('Psearch');
const X = document.getElementById('X');
const firstLine = document.getElementById('firstLine');


// כאשר לוחצים על איקון החיפוש
search.onclick = () => {
    const existingInput = inputSearch.querySelector('input');
    if (existingInput) existingInput.remove();

    const existingImg1 = Psearch.querySelector('.img1Div img');
    if (existingImg1) existingImg1.parentElement.remove();

    const existingImg2 = X.querySelector('.img2Div img');
    if (existingImg2) existingImg2.parentElement.remove();
    const input = document.createElement('input');
    input.placeholder = 'חפש את...';
    inputSearch.append(input);
    inputSearch.classList.add('input');
    input.id = "textSearch";
    const img1Div = document.createElement('div');
    const buttom = document.createElement('button')
    img1Div.classList.add('img1Div');
    const img1 = document.createElement('img');
    img1.src = 'pictures/חיפוש2.png';
    img1Div.append(buttom);
    buttom.append(img1);
    buttom.id = "searchButtom";
    Psearch.append(img1Div);
    const img2Div = document.createElement('div');
    img2Div.classList.add('img2Div');
    const img2 = document.createElement('img');
    img2.src = 'pictures/איקס.png';
    img2Div.append(img2);
    X.append(img2Div);
    firstLine.classList.add('black')
    document.getElementById('overlay').style.display = 'block';
    const searchButtom = document.getElementById('searchButtom');
    const textSearch = document.getElementById('textSearch')
    // כאשר לוחצים על כפתור החיפוש ב input
    searchButtom.onclick = () => {
        displayConfig.searchBy = textSearch.value;
        filter = filteredPoductsName(store.products, displayConfig.searchBy);
        sessionStorage.setItem('searchBy', displayConfig.searchBy)
        sessionStorage.setItem('arrProducts', JSON.stringify(filter))
        const input = document.querySelector('input');
        input.remove();
        const img1 = document.querySelector('.img1Div');
        img1.remove();
        const img2 = document.querySelector('.img2Div');
        img2.remove();
        firstLine.classList.remove('black');
        document.getElementById('overlay').style.display = 'none';
        location.href = './search.html'
        setProduct1(filter);

    }
}

// כאשר לוחצים על כפתור האיקס של החיפוש
X.onclick = () => {
    console.log('MMMM');
    const input = document.querySelector('input');
    input.remove();
    const img1 = document.querySelector('.img1Div');
    img1.remove();
    const img2 = document.querySelector('.img2Div');
    img2.remove();
    firstLine.classList.remove('black');
    document.getElementById('overlay').style.display = 'none';
}

const allProducts = document.getElementById('allProducts');
const categorys = document.querySelectorAll('.category');
const searchCategory = '';
const displayConfig = {
    searchBy: '',
    sortBy: ''
}
const store = {
    products: [],
    Header: []
}

const header = {
    products: []
};


const ajaxFunc = (category) => {
    $.ajax({
        url: './data/store.json',
        success: (data) => {
            const { product } = data;
            store.products = product
            const { Header } = data;
            store.Header = Header;
            if (category === '') {
                filter = filteredPoducts(store.products, 'חדש_באתר');
                sessionStorage.setItem('arrProducts', JSON.stringify(filter))
                window.location.href = "./home.html";
            }
            else {
                if (category === 'כל המוצרים' || category === 'אורגנית לתכשיטים' || category === 'מתנות לחורף') {
                    filter = filteredPoducts(store.products, '');
                    filterHeader = filteredPoducts(store.Header, 'כל המוצרים');
                }
                else {
                    filter = filteredPoducts(store.products, category);
                    filterHeader = filteredPoducts(store.Header, category);
                }
                sessionStorage.setItem('headerPicture', JSON.stringify(filterHeader))
                sessionStorage.setItem('arrProducts', JSON.stringify(filter))
                window.location.href = "./allCtegory.html";

            }
        }
    });
}

// פונקציה שמראה את המוצרים על המסך מקובץ json
const setProduct1 = (filter) => {
    allProducts.innerHTML = '';
    filter.forEach(p => {
        const firstPicture = document.createElement('div')
        const { category, prouductName, price, url, code, UnitsInStock } = p;
        const div = document.createElement('div');
        const buttonPicture = document.createElement('a');
        buttonPicture.href = `./product.html?productCode=${code}`
        div.append(buttonPicture);
        div.id = "textPicture";
        div.classList.add('picture')
        buttonPicture.innerHTML = `<img src="/${url}" class="buttonPictureClass"><p>${prouductName}<br>${price}</p>`;
        allProducts.append(div);
    })
}

// כאשר לוחצים על אחד מהקטגוריות נשים,גברים וכו
categorys.forEach(e => {
    e.onclick = () => {
        const searchCategory = e.innerHTML;
        if (searchCategory === 'צפייה בעוד')
            ajaxFunc('חדש');
        else
            ajaxFunc(searchCategory);
    }
});

// פונקציה המחזירה את המוצרים שקיים בהם הערך לחיפוש
const filteredPoductsName = (products, SearchPoductsName) => {
    return products.filter(product => product.prouductName.includes(SearchPoductsName))
}

// פונקציה המחזירה את המוצרים ששייכים לקטגוריה המבוקשת
const filteredPoducts = (products, searchCategory) => {
    return products.filter(product => product.category.includes(searchCategory))
}

// פונקציה המופעלת בעת לחיצה על אייקון העגלה בראש העמוד
const basket = document.getElementById('basket');
const basketProducts = document.getElementById('basketProducts');
basket.onclick = () => {
    document.getElementById('basketDiv').style.display = 'block';
    document.getElementById('overlay').style.display = 'block';
    const user = JSON.parse(sessionStorage.getItem('user'));
    if (user.basket.length === 0) {
        const basketEmpty = document.getElementById('basketEmpty')
        basketEmpty.innerHTML = 'עגלת הקניות שלך ריקה';
        document.getElementById('forPayment').style.display = 'none';
        updateSum();
    }
    else {
        basketEmpty.innerHTML = '';
        const currentUserSession = sessionStorage.getItem('user');
        const currentUser = JSON.parse(currentUserSession);
        setbasketProduct(currentUser.basket);
        document.getElementById('forPayment').style.display = 'block';
        document.getElementById('forPayment').style.marginLeft = '40px'
        updateSum();
    }
}

// פונקציה המופעלת בעת לחיצה על האיקס שבעגלה-סגירת העגלה 
const basketX = document.getElementById('basketX');
basketX.onclick = () => {
    document.getElementById('basketDiv').style.display = 'none';
    document.getElementById('overlay').style.display = 'none';
}

// פונקציה המציגה את המוצרים בתוך העגלה
const setbasketProduct = (arr) => {
    basketProducts.innerHTML = '';
    let index = 0;
    arr.forEach(p => {
        const product = document.createElement('div')
        const { category, prouductName, price, url, code, UnitsInStock, Amount } = p;
        const buttonProduct = document.createElement('button');
        buttonProduct.id = 'buttonProduct'
        product.id = "product";
        const a = document.createElement('a')
        buttonProduct.innerHTML = `<img src="/${url}" id="pictureProduct">`;
        a.append(buttonProduct)
        a.href = `./product.html?productCode=${code}`
        const Details = document.createElement('div');
        Details.id = 'DetailsB'
        const titleP = document.createElement('p');
        titleP.innerHTML = `${prouductName}<br>${price}`
        Details.append(titleP);
        const countB = document.createElement('div');
        const addB = document.createElement('button');
        const lessB = document.createElement('button');
        const PB = document.createElement('p');
        addB.id = 'addB';
        lessB.id = 'lessB';
        addB.innerHTML = '+';
        PB.innerHTML = parseInt(p.Amount);
        PB.id = 'number';
        lessB.innerHTML = '-';
        // בעת לחיצת כפתור הפלוס
        addB.onclick = () => {
            const currentUser = JSON.parse(sessionStorage.getItem('user'));
            // const currentProduct = JSON.parse(sessionStorage.getItem('currentProduct'));
            let num = parseInt(PB.innerHTML);
            num = num + 1;
            if (num <= p.UnitsInStock) {
                PB.innerHTML = num;
                p.Amount = num;
                const product = currentUser.basket.find(pro => pro.code === p.code);
                product.Amount = p.Amount;
                sessionStorage.setItem('user', JSON.stringify(currentUser));
                const arrUsers = JSON.parse(localStorage.getItem('arrUsers'));
                const index = arrUsers.findIndex(u => u.password === currentUser.password);
                arrUsers.splice(index, 1);
                arrUsers.push(currentUser);
                localStorage.setItem('arrUsers', JSON.stringify(arrUsers));
                setbasketProduct(currentUser.basket);
                updateSum();
            }
        }
        // בעת לחיצת כפתור המינוס
        lessB.onclick = () => {
            if (PB.innerHTML > 1) {
                const currentUser = JSON.parse(sessionStorage.getItem('user'));
                PB.innerHTML = PB.innerHTML - 1;
                p.Amount -= 1;
                const product = currentUser.basket.find(pro => pro.code === p.code);
                product.Amount = p.Amount;
                sessionStorage.setItem('user', JSON.stringify(currentUser));
                const arrUsers = JSON.parse(localStorage.getItem('arrUsers'));
                const index = arrUsers.findIndex(u => u.password === currentUser.password);
                arrUsers.splice(index, 1);
                arrUsers.push(currentUser);
                localStorage.setItem('arrUsers', JSON.stringify(arrUsers));
                setbasketProduct(currentUser.basket);
                updateSum();
            }

        }
        countB.append(lessB);
        countB.append(PB);
        countB.append(addB);
        countB.id = "countB";
        Details.append(countB);
        const removeProduct = document.createElement('button');
        removeProduct.innerHTML = "הסרה";
        // בעת לחיצה על הסרת מוצר מהעגלה
        removeProduct.onclick = () => {
            const currentUser = JSON.parse(sessionStorage.getItem('user'));
            remove(p.code, currentUser.basket)
        }
        removeProduct.classList.add('delete')
        removeProduct.id = 'removeProduct';
        Details.append(removeProduct);
        product.append(a);
        product.append(Details);
        basketProducts.append(product);
        index += 1;
    });
};

// בעת לחיצה על כפתור התשלום בעגלה
const forPayment = document.getElementById('forPayment');
forPayment.onclick = () => {
    const countPay = document.getElementById('countPay')
    sessionStorage.setItem('sum', countPay.innerHTML);
    location.href = './toPay.html'
}


// פונקציה המוחקת מוצר מהעגלה
const remove = (code, arrBasket) => {
    const currentUser = JSON.parse(sessionStorage.getItem('user'));
    const indexProduct = arrBasket.findIndex(item => item.code === code);
    const product = currentUser.basket.find(pro => pro.code === code);
    product.Amount = 0; 
    sessionStorage.setItem('currentProduct',JSON.stringify(product)) 
    currentUser.basket.splice(indexProduct, 1);
    sessionStorage.setItem('user', JSON.stringify(currentUser))
    const arrUsers = JSON.parse(localStorage.getItem('arrUsers'));
    const index = arrUsers.findIndex(u => u.password === currentUser.password);
    arrUsers.splice(index, 1);
    arrUsers.push(currentUser);
    localStorage.setItem('arrUsers', JSON.stringify(arrUsers));
    setbasketProduct(currentUser.basket);
    updateSum();
}

// פונקציה המעדכנת את המחיר לתשלום 
const updateSum = () => {
    const countPay = document.getElementById('countPay');
    let sum = 0;
    const currentUser = JSON.parse(sessionStorage.getItem('user'));
    if (currentUser) {
        if (currentUser.basket.length >= 0) {
            currentUser.basket.forEach(p => {
                let numeString = p.price.replace('₪', '').trim() * parseInt(p.Amount);
                sum = sum + parseFloat(numeString);
            });
            countPay.innerHTML = ` ₪${sum.toFixed(2)}  `
        }
    }
}

// בעת לחיצה על כפתור הרשמות למועדון
const afterenrollmentFooter = document.getElementById('afterenrollmentFooter')
const enrollmentfooter = document.getElementById('enrollmentfooter');
enrollmentfooter.onclick = () => {
    document.getElementById('EmailFooter').style.display = 'none';
    document.getElementById('enrollmentfooter').style.display = 'none';
    afterenrollmentFooter.style.display = 'block';
    const Email = document.getElementById('Email');
    if (Email)
        document.getElementById('Email').style.display = 'none';
    const enrollment = document.getElementById('enrollment');
    if (enrollment)
        document.getElementById('enrollment').style.display = 'none';
    const afterenrollment = document.getElementById('afterenrollment');
    if (afterenrollment)
        afterenrollment.style.display = 'block';
}



















































