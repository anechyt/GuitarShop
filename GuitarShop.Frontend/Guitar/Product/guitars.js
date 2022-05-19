class Guitars {
    async getResponce(){
        let htmlcatalog = '';
        let responce = await fetch('https://localhost:44312/api/Guitar/getallguitars')
        let content = await responce.json()

        content.forEach(({name,color, price, photoUrl}) => {
            htmlcatalog += `
                <li class="guitars-element">
                    <span class="guitars-element__name">${name}</span>
                    <span class="guitars-element__color">${color}</span>
                    <img class="guitars-element__img" src="${photoUrl}">
                    <span class="guitars-element__price"> 🦄 ${price.toLocaleString()} Единорогов</span>
                    <button class="guitars-element__btn">Добавить в корзину</button>
                </li>
            `;
        });

        const html = `
            <ul class="guitars-container">
                ${htmlcatalog}
            </ul>
        `;

        ROOT_GUITARS.innerHTML = html;
    
    }
}

const guitarpage = new Guitars();
guitarpage.getResponce();