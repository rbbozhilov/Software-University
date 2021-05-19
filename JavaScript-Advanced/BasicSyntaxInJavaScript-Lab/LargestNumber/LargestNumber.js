function solution(firstNumber,secondNumber,thirdNumber) {
    let largerNumber = 0;
    if (firstNumber>secondNumber && firstNumber>thirdNumber) {
        largerNumber = firstNumber;
    } else if (secondNumber>firstNumber && secondNumber>thirdNumber) {
        largerNumber = secondNumber;
    } else {
        largerNumber = thirdNumber;
    }
    
    console.log('The largest number is ${largestNumber}.');
}

solution(1,2,5);