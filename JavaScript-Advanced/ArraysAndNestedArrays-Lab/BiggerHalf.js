function solution(arr) {

    arr = arr.sort((a,b) => a-b);
    let length = arr.length;
    arr = arr.slice(length/2,length);
    arr = arr.join(', ');
    console.log('[%s]',arr);


}

solution([3,19,14,7,2,19,6]);