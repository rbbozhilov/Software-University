function Solution(number,arg1,arg2,arg3,arg4,arg5) {
    let currentNum = Number(number);
    let array = [arg1,arg2,arg3,arg4,arg5];
    let counter = 0;

    for ( let i=0; i<5;i++) {


        if ( array[counter] == 'chop') {
            currentNum /=2;
        } else if ( array[counter] == 'dice') {
            currentNum = Math.sqrt(currentNum);

        } else if(array[counter] == 'spice') {
            currentNum +=1;

        } else if(array[counter] == 'bake') {
            currentNum *=3;

        } else if(array[counter] == 'fillet') {
            currentNum -=0.2 * currentNum;

        }
        console.log(currentNum);

       counter++;

    }
}


Solution('9', 'dice', 'spice', 'chop', 'bake', 'fillet');