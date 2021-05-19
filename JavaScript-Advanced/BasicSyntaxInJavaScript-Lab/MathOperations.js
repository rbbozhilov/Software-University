function Operations(firstNumber,secondNumber,operator) {
    let result = 0;
    switch(operator)
    {
        case '+': result = firstNumber + secondNumber; break;
        case '-': result = firstNumber - secondNumber; break;
        case '*': result = firstNumber * secondNumber; break;
        case '/': result = firstNumber / secondNumber; break;
        case '%': result = firstNumber % secondNumber; break;
        case '**': result = firstNumber ** secondNumber; break;
    }
  
    console.log(result);

}

Operations(5, 6, '+');