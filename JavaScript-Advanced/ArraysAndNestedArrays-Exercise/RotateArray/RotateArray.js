function solution(currentArray,step) {

    if(currentArray.length >= 2) {
    
    for(let i=0;i<step;i++) {

        let popped = currentArray.pop();

        currentArray.unshift(popped);

    }

    }
    console.log(currentArray.join(' '));
}

solution(['Banana','Orange','Coconut','Apple'],15);