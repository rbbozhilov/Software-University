function solution(commands) {

    let finalArray = [];
    let counter = 1;

    for(let i=0 ; i<commands.length ; i++) {

        if(commands[i] == 'add') {
            finalArray.push(counter);
        } else if (commands[i]== 'remove') {

            if(finalArray.length != 0) {
                finalArray.pop();
            }

        }

        counter++;
    }


    if(finalArray.length == 0 ) {
        finalArray[0] = 'Empty';
    }

    for(let i = 0 ; i<finalArray.length ; i++) {
        console.log(finalArray[i]);
    }
    

}


solution(['add','add','add','add','add']);
