function solution(currentArray) {


    currentArray = currentArray.sort((a,b) => a.localeCompare(b));

    for(let i = 0 ; i<currentArray.length ; i++) {
        console.log('%s.%s',i+1,currentArray[i]);
    }


}

solution(['John','Bob','Christina','Ema']);