window.addEventListener('load', solve);

function solve() {
    let buttonAdd = document.querySelector('form #add');

    buttonAdd.addEventListener('click', (e) => {

        e.preventDefault();

        let modelElement = document.querySelector('form #model');
        let modelValue = modelElement.value;

        let yearElement = document.querySelector('form #year');
        let yearValue = Number(yearElement.value);

        let descriptionElement = document.querySelector('form #description');
        let descriptionValue = descriptionElement.value;

        let priceElement = document.querySelector('form #price');
        let priceValue = Number(priceElement.value).toFixed(2);

      

        if(modelValue == '' || yearValue <=0 || priceValue <= 0 || descriptionValue == '' || descriptionValue == 0) {
            return;
        }

        let getFurnitureListElement = document.querySelector('#furniture-list');
        let trClass = document.createElement('tr');
        trClass.setAttribute('class','info');
        let firstTd = document.createElement('td');
        firstTd.textContent = modelValue;
        trClass.appendChild(firstTd);

        let secondTd = document.createElement('td');
        secondTd.textContent = priceValue;
        trClass.appendChild(secondTd);

        let thirdTd = document.createElement('td');
        let buttonMore = document.createElement('button');
        buttonMore.setAttribute('class','moreBtn');
        buttonMore.textContent = 'More Info';
        thirdTd.appendChild(buttonMore);

        let buttonBuy = document.createElement('button');
        buttonBuy.setAttribute('class','buyBtn');
        buttonBuy.textContent = 'Buy it';
        thirdTd.appendChild(buttonBuy);

        trClass.appendChild(thirdTd);

        getFurnitureListElement.appendChild(trClass);

        let trotherClass = document.createElement('tr');
        trotherClass.setAttribute('class','hide');
        let tdYear = document.createElement('td');
        tdYear.textContent = `Year: ${yearValue}`;
        trotherClass.appendChild(tdYear);


        let tdOther = document.createElement('td');
        tdOther.setAttribute('colspan','3');
        tdOther.textContent = `Description: ${descriptionValue}`;
        trotherClass.appendChild(tdOther);





        getFurnitureListElement.appendChild(trotherClass);

        modelElement.value = '';
        yearElement.value = '';
        descriptionElement.value = '';
        priceElement.value = '';

        let getMoreInfoButton = document.querySelector('.moreBtn');

        getMoreInfoButton.addEventListener('click', (e) => {

            e.preventDefault();
            let currentNode = document.querySelector('.hide');

            if(e.target.textContent == 'More Info'){

                e.currentTarget.textContent = 'Less Info';
                currentNode.style.display = 'contents';


            } else {
                e.currentTarget.textContent = 'More Info';
                currentNode.style.display = 'none';
            }
           
           


        })

        let buyButton = document.querySelector('.buyBtn');

        buyButton.addEventListener('click',(b) => {

            b.preventDefault();

            let currentFurniture = b.target.parentElement.parentElement.parentElement;
            let tdTotalPrice = document.querySelector('.total-price');
            let takeOldPrice = Number(tdTotalPrice.textContent);
            let newPrice = Number(b.target.parentElement.parentElement.querySelector('td:nth-child(2)').textContent);

            tdTotalPrice.textContent = (takeOldPrice + newPrice).toFixed(2);

            
            currentFurniture.remove();


        })


    

    })
}
