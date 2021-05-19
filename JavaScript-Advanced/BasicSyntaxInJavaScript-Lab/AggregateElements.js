function Solution(arrayInput) {
    console.log(ArraySum(arrayInput));
    console.log(Concate(arrayInput));

}


function ArraySum(arrayInput) {
    let result = 0;

   for ( let i = 0; i < arrayInput.length ; i++) {

     result +=arrayInput[i];

   }

   return result;
}

function Concate(arrayInput) {

    let result = '';
    for(let i = 0 ; i < arrayInput.length; i++){

        result +=arrayInput[i];
    
    }

    return result;
}

Solution([2,4,8,16]);