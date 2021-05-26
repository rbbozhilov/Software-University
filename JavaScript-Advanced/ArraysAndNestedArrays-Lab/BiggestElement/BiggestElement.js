function solution(arr) {
    
    let bigestElement = Number.MIN_SAFE_INTEGER;


    for (let row of arr) {
        for(let number of row) {
            if(number > bigestElement) {
                bigestElement = number;
            }
        }
    }
    
    return bigestElement;

}


console.log(solution([[20,50,10],[8,33,145]]));
