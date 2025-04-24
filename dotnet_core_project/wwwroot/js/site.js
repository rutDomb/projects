let uriCloth= "/ShopClothes";
let uriUser="/user"
const userName=document.getElementById("userName")
let clothes = [];
let users=[];

console.log(localStorage.getItem("link"));
if (localStorage.getItem("link")==='true') {
    document.getElementById('listUsers').style.display = 'block';
    document.getElementById('editUser').style.display = 'none';
}


const getItems=()=> {
    fetch(uriCloth, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${localStorage.getItem("token")}`
        },
    })
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => {
            console.log(error);
            location.href = "./login.html"
        });
}

const addC=document.getElementById('addC')
const addNameTextbox = document.getElementById('add-name');
addC.onclick=()=>{
    const item = {
                UserId:localStorage.getItem("userId"),
                isToWinter: false,
                name: addNameTextbox.value.trim()
            };
        
            fetch(uriCloth, {
                    method: 'POST',
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json',
                        'Authorization': `Bearer ${localStorage.getItem("token")}`
                    },
                    body: JSON.stringify(item)
                })
                .then(response => response.json())
                .then(() => {
                    getItems();
                    addNameTextbox.value = '';
                })
                .catch(error => console.error('Unable to add item.', error));
}


const deleteItem=(id)=>{
    fetch(`${uriCloth}/${id}`, {
            method: 'DELETE',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Authorization': `Bearer ${localStorage.getItem("token")}`
            },
        })
        .then(() => getItems())
        .catch(error => console.error('Unable to delete item.', error));
}

const displayEditForm=(id)=> {
    const item = clothes.find(item => item.id === id);
    
    document.getElementById('edit-name').value = item.name;
    document.getElementById('edit-id').value = item.id;
    document.getElementById('edit-iswool').checked = item.iswool;
    document.getElementById('clothForm').style.display = 'block';
}

const updateItem=()=> {
    const itemId = document.getElementById('edit-id').value;
    const item = {
        UserId:localStorage.getItem("userId"),
        id: parseInt(itemId, 10),
        iswool: document.getElementById('edit-iswool').checked,
        name: document.getElementById('edit-name').value.trim(),
    };
    fetch(`${uriCloth}/${itemId}`, {
            method: 'PUT',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Authorization': `Bearer ${localStorage.getItem("token")}`
            },
            body: JSON.stringify(item)
        })
        .then(() => getItems())
        .catch(error => console.error('Unable to update item.', error));

    closeInput('clothForm');
    console.log(clothes);
    return false;
}

const closeInput=(formToClose)=> {
    document.getElementById(formToClose).style.display = 'none';
}

const _displayCount=(itemCount)=> {
    const name = (itemCount === 1) ? 'cloth' : 'cloth kinds';

    document.getElementById('counter').innerText = `${itemCount} ${name}`;
}

const _displayItems=(data)=> {
    const tBody = document.getElementById('clothes');
    tBody.innerHTML = '';
    
    _displayCount(data.length);

    const button = document.createElement('button');

    data.forEach(item => {
        let isToWinterCheckbox = document.createElement('input');
        isToWinterCheckbox.type = 'checkbox';
        isToWinterCheckbox.checked = item.iswool;
        console.log(item);
        isToWinterCheckbox.disabled = true;  
        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${item.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteItem(${item.id})`);

        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        td1.appendChild(isToWinterCheckbox);

        let td2 = tr.insertCell(1);
        let textNode = document.createTextNode(item.name);
        td2.appendChild(textNode);

        let td3 = tr.insertCell(2);
        td3.appendChild(editButton);

        let td4 = tr.insertCell(3);
        td4.appendChild(deleteButton);
    });

    clothes = data;
}

const createUser=(response)=>{
   user=response;
   userName.innerHTML=user.username;
}

const editUser=()=>{
   document.getElementById('edit-id-user').value=user.id;
   document.getElementById('edit-name-user').value=user.username;
   document.getElementById('edit-password-user').value=user.password;
   document.getElementById('editUserFrom').style.display='block';
}

const updateUser=()=>{
    const newUser = {
        id:document.getElementById('edit-id-user').value.trim(),
        username:document.getElementById('edit-name-user').value.trim(),
        password: document.getElementById('edit-password-user').value.trim(),
        isAdmit: user.isAdmit,
    };
    fetch(`${uriUser}/${user.id}`, {
            method: 'PUT',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Authorization': `Bearer ${localStorage.getItem("token")}`
            },
            body: JSON.stringify(newUser)
        })
        .then(() =>{
            user=newUser;
            userName.innerHTML=user.username;
        })
        .catch(error => console.error('Unable to update user.', error));

    closeInput('editUserFrom');
    return false;
}

const getUser=()=>{
    const userId=localStorage.getItem("userId");
    fetch(`${uriUser}/${userId}`,{
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${localStorage.getItem("token")}`
        }
    })
        .then(response => response.json())
        .then(response => createUser(response))
        .catch(error =>
            console.log(error));
   
}
let user;
getUser();
// console.log(clothes);














