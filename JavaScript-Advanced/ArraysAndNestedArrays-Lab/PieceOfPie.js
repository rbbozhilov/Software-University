function solution(arr,firstFlavor,secondFlavor) {
    let firstIndex = arr.indexOf(firstFlavor);
    let secondIndex = arr.indexOf(secondFlavor);
    
    return arr.slice(firstIndex,secondIndex+1);

}
