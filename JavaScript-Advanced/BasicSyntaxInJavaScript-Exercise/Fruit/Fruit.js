function BuyFruit(fruit,grams,coast) {
    let kilograms = grams / 1000;
    let neededMoney = kilograms * coast;

    console.log('I need $%s to buy %s kilograms %s.',neededMoney.toFixed(2),kilograms.toFixed(2),fruit);


}

BuyFruit('apple', 1563, 2.35);