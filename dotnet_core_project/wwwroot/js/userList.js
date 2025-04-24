const uri = "/user";
const uriC="/ShopClothes"

let users=[];
let data;
const checkToken=()=>{
    fetch(uri,{
        method:'GET',
        headers:{
            'Accept': 'application/json',
            'Content-Type': 'application/json',
            'Authorization':`Bearer ${localStorage.getItem("token")}`
        },
    })
    .then(respones=>respones.json())
    .then(getUsers())
    .catch(error=>{
        sessionStorage.setItem("check",error);
        console.log(error);
        location.href="./login.html"
    });
}

const getUsers=()=>{
    fetch(uri, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${localStorage.getItem("token")}`
        },
    })
    .then(response=>response.json())
    .then(data=>_displayUsers(data))
    .catch(error=>console.error('Unable to get items.', error))

}

const addUser=()=>{
    const addNameTextbox=document.getElementById('add-name');
    const addPasswordTextbox=document.getElementById('add-password');

    const user={
        Id:users.length+1,
        Username:addNameTextbox.value.trim(),
        Password:addPasswordTextbox.value.trim()
    };
    users.push(user);
    data=users;

    fetch(uri,{
        method:'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json',
            'Authorization':`Bearer ${localStorage.getItem("token")}`
        },
        body:JSON.stringify(user)
    })
    .then(respones=> respones.json())
    .then(()=>{
        
        getUsers();
        addNameTextbox.value='';
        addPasswordTextbox.value='';
        console.log("rutiiiii");
    })
    .catch(error => console.error('Unable to add user.', error));
}

const deleteUser=(id)=>{
    localStorage.setItem('id',id);
    fetch(`${uri}/${id}`,{
        method: 'DELETE',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json',
            'Authorization':`Bearer ${localStorage.getItem("token")}`
        },
    })
    .then(()=>getUsers())
    .catch(error => console.error('Unable to delete item.', error));
    // fetch(uriC, {
    //     method: 'GET',
    //     headers: {
    //         'Accept': 'application/json',
    //         'Content-Type': 'application/json',
    //         'Authorization': `Bearer ${localStorage.getItem("token")}`
    //     },
    // })
    // .then(response => response.json())
    // .then(data => _deleteItems(data))
    // .catch(error => console.error('Unable to get items.', error));
}

const _deleteItems=(data)=>{
    UserId=localStorage.getItem("id");
    data.forEach(item => {
        if(item.userId==UserId)
        {
            fetch(`${uriC}/${item.id}`, {
                method: 'DELETE',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': `Bearer ${localStorage.getItem("token")}`
                },
            })
            .then(() => getUsers())
            .catch(error => console.error('Unable to delete item.', error));
            console.log(JSON.stringify(data));
        }
    });
}

const _displayCount=(userCount)=>{
    const name=(userCount==1)?'users':'users Kinds';
    document.getElementById('counter').innerText=`${userCount} ${name}`;
}



const _displayUsers=(data)=>{
  console.log("jvhvhchc");
  const tbody=document.getElementById('users');
  tbody.innerHTML='';
  _displayCount(data.length);
  const button=document.createElement('button');
  data.forEach(user => {
        console.log(user);
        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteUser(${user.id})`);

        let tr = tbody.insertRow();
        let td1 = tr.insertCell(0);
        let textId = document.createTextNode(user.id);
        td1.appendChild(textId);

       
        let td2 = tr.insertCell(1);
        let textNodeName = document.createTextNode(user.username);
        td2.appendChild(textNodeName);
      
        let td3 = tr.insertCell(2);
        let textNodePassword = document.createTextNode(user.password);
        td3.appendChild(textNodePassword);

        let td4 = tr.insertCell(3);
        td4.appendChild(deleteButton);
  });

  users=data;
}

getUsers();


