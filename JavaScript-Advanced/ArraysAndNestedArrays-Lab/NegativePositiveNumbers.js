function solution(arr) {
    
    let finalArr = [];

    for( let element of arr) {


        if(element>=0) {
            finalArr.push(element);
        } else {
            finalArr.unshift(element);
        }
        

    }


    console.log(finalArr.join('\n'));

}

solution([3,-2,0,-1]);