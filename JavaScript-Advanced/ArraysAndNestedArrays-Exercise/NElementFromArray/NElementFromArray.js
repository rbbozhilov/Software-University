function solution(currentArray,step) {


    let finalArray = [];
    let currentStep = 0;

    for(let i = 0 ; i < currentArray.length; i++ ) {


        if(i==0) {
            finalArray.push(currentArray[i]);
            continue;
        }
        currentStep++;

        if(currentStep==step) {
            finalArray.push(currentArray[i]);
            currentStep = 0;
        }

    }

    return finalArray;
}

console.log(solution(['5','20','31','4','20'],2));