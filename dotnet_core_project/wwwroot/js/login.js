const uri = '/login';
console.log("in loginnnnn");
const dom = {
    name: document.getElementById('name'),
    password: document.getElementById('password'),
    submitBtn: document.getElementById('bthSubmit')
}
dom.submitBtn.onclick = (event) => {
    event.preventDefault();
    const user = {Id:0, Username: dom.name.value, Password: (dom.password.value).toString() }
    console.log(user);
    fetch(uri, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)
        })
        .then(response => {
            console.log("nnbfgnj");
            if (!response.ok) {
                // אם התגובה לא תקינה, הצג הודעה בהתאם
                if (response.status === 400) {
                    alert("Bad Request: Check the format of the data sent.");
                } else if (response.status === 401) {
                    alert("Unauthorized: The username or password is incorrect.");
                }
                throw new Error(`HTTP error! Status: ${response.status}`);
            }
            return response.json();
        })
        .then(res => {
                if (dom.name.value == "ruti" && dom.password.value == "455542")
                    localStorage.setItem("link", true);
                else
                    localStorage.setItem("link", false);
                localStorage.setItem("token", res.token);
                console.log(res);
                localStorage.setItem("userId", res.id);
                location.href = "../index.html";
            })
        .catch(error => console.error('Unable to add item', error));
}