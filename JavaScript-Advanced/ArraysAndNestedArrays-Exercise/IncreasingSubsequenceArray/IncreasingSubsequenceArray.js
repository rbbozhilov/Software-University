function solution(currentArray) {


    let finalArray = [];
    let maxNumber = Number.MIN_VALUE;

    for(let element of currentArray) {
        if(element>=maxNumber) {
            finalArray.push(element);
            maxNumber = element;
        }
    }



    return finalArray;
}

console.log(solution([1,3,8,4,10,12,3,2,24]));