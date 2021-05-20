function solution(arr) {
    arr = arr.map(x => Number(x));
    let first = arr[0];
    let last = arr[arr.length-1];
    let sum = 0;

    if(arr.length != 1) {
        sum = first + last;
    } else {
        sum = first;
    }

    console.log(sum);
}

solution([]);