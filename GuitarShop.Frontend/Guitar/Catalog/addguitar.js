class AddOneGuitar{
    async addGuitar(){
        let input_1 = document.getElementById("myName").value;
        let input_2 = document.getElementById("mySize").value;
        let input_3 = document.getElementById("myNumberOfStrings").value;
        let input_4 = document.getElementById("myColor").value;
        let input_5 = document.getElementById("myPrice").value;
        let input_6 = document.getElementById("myPhotoUrl").value;
        let input_7 = document.getElementById("myCategoryId").value;
        let data = new FormData();
        data.append("json", JSON.stringify({name: input_1, size:input_2, numberOfStrings:input_3, color:input_4, price:input_5, photoUrl:input_6, categoryId:input_7}));
        await fetch('https://localhost:44312/api/Guitar/AddGuitar', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: data
            }).then(rawResponse => console.log(rawResponse));
    }
}

