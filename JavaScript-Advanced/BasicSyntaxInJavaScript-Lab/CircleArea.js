function CircleArea(parameter) {
    let type = typeof(parameter);
    let result = 0;

    if(type == 'number'){
        result = Math.pow(parameter,2) * Math.PI;
        console.log(result.toFixed(2));
    } else {
        console.log('We can not calculate the circle area, because we receive a %s.',type);
    }
    
}

