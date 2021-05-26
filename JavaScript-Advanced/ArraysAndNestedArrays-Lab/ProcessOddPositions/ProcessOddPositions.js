function solution(array) {
    
    let finalArr = [];

    for(let i = 0 ; i<array.length ; i++) {
        if (i%2 != 0) {
            finalArr.push(array[i] * 2 );
        }
    }

    return finalArr.reverse();
}

console.log(solution([10,15,20,25]));