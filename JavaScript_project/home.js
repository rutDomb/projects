const form = document.querySelector('form');
const userText = document.getElementById('userText');
const formX = document.getElementById('formX');
const enter = document.getElementById('enter');
const newAccount = document.getElementById('newAccount');
// איתחול מערך משתמשים ריק
if (localStorage.getItem('arrUsers') === null) {
    const arr = [];
    const arrUsers = JSON.stringify(arr);
    localStorage.setItem('arrUsers', arrUsers);
}

// עידכון שם משתמש בראש העמוד
const currentUserSession = sessionStorage.getItem('user');
if (currentUserSession) {
    const currentUser = JSON.parse(currentUserSession);
    document.getElementById('userText').innerHTML = currentUser.userName;
}

// בעת לחיצה על האיס בפואפ הרישום
formX.onclick = () => {
    closePopup();
}
const error = document.getElementById('error')
// בעת לחיצה על אחד מהכפתורים בפואפפ הרישום
form.onsubmit = (form) => {
    form.preventDefault();
    const arrUsers2 = JSON.parse(localStorage.getItem('arrUsers'));
    sessionStorage.setItem('exist', true);
    const currentUser = {
        userName: form.target['userName'].value,
        password: form.target['password'].value,
        basket: []
    }
    // אם מערך המשתמשים ריק הוספת המשתמש הנוכחי למערך ועידכון המערך
    if (arrUsers2.length === 0) {
        arrUsers2.push(currentUser);
        localStorage.setItem('arrUsers', JSON.stringify(arrUsers2));
    }
    else {
        localStorage.setItem('newUser', false);
        arrUsers2.forEach(user => {
            // אם קיים משתמש במערך אם סיסמא דומה אבל שם שונה
            if (user.password === currentUser.password && user.userName !== currentUser.userName) {
                error.innerHTML = 'הסיסמא כבר קיימת ,הכנס סיסמא חדשה';
                localStorage.setItem('newUser', true);
                sessionStorage.setItem('exist', false);
            }
            // אם קיים משתמש במערך עם אותו שם וסיסמא
            if (user.password === currentUser.password && user.userName === currentUser.userName) {
                localStorage.setItem('newUser', true);
                sessionStorage.setItem('user', JSON.stringify(user));
                document.getElementById('userText').innerHTML = currentUser.userName;
                sessionStorage.setItem("exist", true);
                closePopup();
            }

        });
        // אם שתי התנאים להי"ל לא התקימו-משתמש חדש
        const newUser = localStorage.getItem('newUser');
        if (newUser === "false") {
            arrUsers2.push(currentUser);
            localStorage.setItem('arrUsers', JSON.stringify(arrUsers2));
            sessionStorage.setItem("user", JSON.stringify(currentUser));
            document.getElementById('userText').innerHTML = currentUser.userName;
            sessionStorage.setItem("exist", true);
            closePopup();
        }
    }

}
const currentUserSession2 = sessionStorage.getItem('user');
const currentUser = JSON.parse(currentUserSession2);


// בעת גלילת העמוד ישנה צבע ה header
window.addEventListener('scroll', function () {
    const content = document.querySelector('.firstLine');
    if (window.scrollY > 0) {
        content.classList.add('change-bg');
    } else {
        content.classList.remove('change-bg');
    }
});

// פונקציה לפתיחת הפופאפ
function showPopup() {
    const popupShown = sessionStorage.getItem('exist');
    if (!popupShown) {
        document.getElementById('popUp').style.display = 'block';
        document.getElementById('overlay').style.display = 'block';
    }
}

// פונקציה לסגירת הפופאפ
function closePopup() {
    document.getElementById('popUp').style.display = 'none';
    document.getElementById('overlay').style.display = 'none';
}

// לאחר שניה מפתיחת האתר יפתח פופאפ רישום
setTimeout(showPopup, 1000);

// בעת לחיצה על כותרת חדש באתר 
sessionStorage.setItem('title2', false)
const title1 = document.getElementById('title1');
if (title1) {
    title1.onclick = () => {
        leftArrow.style.display = 'block';
        leftArrow.style.marginLeft = '-1300px'
        rightArrow.style.display = 'none';
        title1.classList.add('line');
        title2.classList.remove('line');
        filter = filteredPoducts(store.products, 'חדש_באתר');
        setProduct(filter);
    }
}

// בעת לחיצה על כותרת טרנדים
const title2 = document.getElementById('title2');
if (title2) {
    title2.onclick = () => {
        leftArrow.style.display = 'none';
        rightArrow.style.display = 'none';
        sessionStorage.setItem('title2', true)
        title2.classList.add('line');
        title1.classList.remove('line')
        title1.classList.remove('title1')
        filter = filteredPoducts(store.products, 'טרנדים');
        setProduct(filter);
    }
}


$.ajax({
    url: './data/store.json',
    success: (data) => {
        const { product } = data;
        store.products = product
        const title2 = sessionStorage.getItem('title2')
        if (title2 === false)
            filter = filteredPoducts(store.products, 'טרנדים');
        else
            filter = filteredPoducts(store.products, 'חדש_באתר');
        setProduct(filter)
    }
});

const rightArrow = document.getElementById('rightArrow')
const leftArrow = document.getElementById('leftArrow');
// בעת לחיצה על חץ שמאלה
leftArrow.onclick = () => {
    filter = filteredPoducts(store.products, 'עוד_חדש');
    setProduct(filter)
    leftArrow.style.display = 'none';
    rightArrow.style.display = 'block';
}
// בעת לחיצה על חץ לימין
rightArrow.onclick = () => {
    filter = filteredPoducts(store.products, 'חדש_באתר');
    setProduct(filter)
    leftArrow.style.display = 'block';
    leftArrow.style.marginLeft = '-1300px'
    rightArrow.style.display = 'none';
}

// בעת לחיצה על הרשמות למועדון
const afterenrollment = document.getElementById('afterenrollment')
const enrollment = document.getElementById('enrollment');
enrollment.onclick = () => {
    document.getElementById('Email').style.display = 'none';
    document.getElementById('enrollment').style.display = 'none';
    afterenrollment.style.display = 'block';
    document.getElementById('EmailFooter').style.display = 'none';
    document.getElementById('enrollmentfooter').style.display = 'none';
    afterenrollmentFooter.style.display = 'block';
}

// פונקציה המציגה את המוצרים על המסך
const setProduct = (filter) => {
    allProducts.innerHTML = '';
    filter.forEach(p => {
        const firstPicture = document.createElement('div')
        const { category, prouductName, price, url, code, UnitsInStock } = p;
        const div = document.createElement('div');
        const buttonPicture = document.createElement('a');
        buttonPicture.href = `./product.html?productCode=${code}`
        div.append(buttonPicture)
        div.id = "textPicture";
        div.classList.add('picture')
        buttonPicture.innerHTML = `<img src="/${url}" class="buttonPictureClass"><p>${prouductName}<br>${price}</p></a>`;
        allProducts.append(div);
    })
}
setProduct(arrProducts)

// פונקציה המעדכנת את המחיר לתשלום בעגלה
const countPay = document.getElementById('countPay');
if (currentUser) {
    if (currentUser.basket.length > 0) {
        currentUser.basket.forEach(p => {
            let numeString = p.price.replace('₪', '').trim();
            sum = sum + parseFloat(numeString);;
        });
        countPay.innerHTML = `₪ לתשלום  ${sum.toFixed(2)} `
    }
}

const imgProduct = document.getElementById('imgProduct');
const circle1 = document.getElementById('circle1');
const circle2 = document.getElementById('circle2');
const circle3 = document.getElementById('circle3');
circle1.onclick = () => {
    circle1.style.color = 'black';
}
circle2.onclick = () => {
    circle2.style.display = 'none';
    imgProduct.innerHTML = `<img src="pictures/בקבוק עמוד הבית.webp">`
}
circle3.onclick = () => {
    circle3.style.color = 'black';
}