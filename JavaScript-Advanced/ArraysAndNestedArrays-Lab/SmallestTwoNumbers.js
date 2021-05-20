function solution(arr) {
    arr.sort((a,b) => a-b);
    let finalArr = arr.slice(0,2);

    console.log(finalArr);
}

solution([20,10,3,4,-2,15])
