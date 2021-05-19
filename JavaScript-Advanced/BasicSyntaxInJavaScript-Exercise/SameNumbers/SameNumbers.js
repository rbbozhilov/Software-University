function CheckNumbers(number) {
    let isSame = true;
    let stringer = number.toString();
    let sum = 0;

    for(let i = 0; i < stringer.length; i++) {
        sum += Number(stringer[i]);
    }

    for(let i = 0; i<stringer.length ; i++) {


        if (i+1 == stringer.length) {
            break;
        }

        if (stringer[i] != stringer[i+1]) {
            isSame = false;
            break;
        }

    }

    console.log(isSame);
    console.log(sum);

}

CheckNumbers(1234);