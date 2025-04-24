const sum=document.getElementById('sum');
sum.innerHTML=sessionStorage.getItem('sum');
const toPay=document.getElementById('toPay');

// בעת לחיצה על כפתור לתשלום
document.getElementById('myForm').addEventListener('submit', function(event) {
    if (this.checkValidity()) {
        event.preventDefault();
        document.getElementById('popup').style.display='block';
        const currentUser=sessionStorage.getItem('user');
    }
});

// בעת לחיצה על כפור אישור בפופאפ
document.getElementById('finishPay').onclick=()=>{
    const currentUser=JSON.parse(sessionStorage.getItem('user'));
    currentUser.basket=[];
    sessionStorage.setItem('user', JSON.stringify(currentUser))
    const arrUsers = JSON.parse(localStorage.getItem('arrUsers'));
    const index = arrUsers.findIndex(u => u.password === currentUser.password);
    arrUsers.splice(index, 1);
    arrUsers.push(currentUser);
    localStorage.setItem('arrUsers', JSON.stringify(arrUsers));
    location.href='./home.html'
}

const Approval=document.getElementById('Approval');