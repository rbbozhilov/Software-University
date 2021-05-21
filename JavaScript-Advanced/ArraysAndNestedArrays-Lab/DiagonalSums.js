function solution(arr) {

    let firstDiagonal = 0;
    let secondDiagonal = 0;

    for (let i=0; i<arr.length; i++) {

        firstDiagonal += arr[i][i];
        
        secondDiagonal += arr[i][arr[i].length - i - 1];

    }

    console.log(firstDiagonal + ' '+ secondDiagonal);
}

solution([[3,5,17],[-1,7,14],[1,-8,89]]);