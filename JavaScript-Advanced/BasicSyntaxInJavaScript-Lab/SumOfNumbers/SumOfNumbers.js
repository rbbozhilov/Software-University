function SumOfNumbers(firstNumber,secondNumber) {
    let result = 0;
    let first = Number(firstNumber);
    let second = Number(secondNumber);

    for (let i=first ; i <= second ; i++ ) {
        result +=i;
    }

    console.log(result);
}

SumOfNumbers('-8','20');