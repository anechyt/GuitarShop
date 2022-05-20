class Catalog {
    async getResponce(){
        let htmlcatalog = '';
        let responce = await fetch('https://localhost:44312/api/Category/getallcategory')
        let content = await responce.json()

        content.forEach(({id, name, photoUrl}) => {
            htmlcatalog += `
                <li class="catalog-element">
                    <span class="catalog-element__name">${name}</span>
                    <img class="catalog-element__img" src="${photoUrl}">
                    <button id="${id}" class="catalog-element__btn">Перейти</button>
                </li>
            `;
            
        });

        const html = `
            <ul class="catalog-container">
                ${htmlcatalog}
            </ul>
        `;
        ROOT_CATALOG[0].innerHTML = html;
        ROOT_CATALOG_ELEMENT[0].addEventListener('click', function (e) {
            const guitarpage = new Guitars();
            guitarpage.getResponce();
        });
        ROOT_CATALOG_ELEMENT[1].addEventListener('click', function (e) {
            const guitarpage = new GuitarsUkulele();
            guitarpage.getResponce();
        });
        ROOT_CATALOG_ELEMENT[2].addEventListener('click', function (e) {
            const guitarpage = new GuitarsElectric();
            guitarpage.getResponce();
        });
    }
}

const catalogpage = new Catalog();
catalogpage.getResponce();

