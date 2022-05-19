class Catalog {
    async getResponce(){
        let htmlcatalog = '';
        let responce = await fetch('https://localhost:44312/api/Category/getallcategory')
        let content = await responce.json()

        content.forEach(({name, photoUrl}) => {
            htmlcatalog += `
                <li class="catalog-element">
                    <span class="catalog-element__name">${name}</span>
                    <img class="catalog-element__img" src="${photoUrl}">
                    <button class="catalog-element__btn">Перейти</button>
                </li>
            `;
        });

        const html = `
            <ul class="catalog-container">
                ${htmlcatalog}
            </ul>
        `;

        ROOT_CATALOG[0].innerHTML = html;
    
    }
}

const catalogpage = new Catalog();
catalogpage.getResponce();