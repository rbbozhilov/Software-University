function solution(input) {
    const dictionary = {};

    for(let item of input) {
        let takeArguments = item.split(' <-> ');
        let townName = takeArguments[0];
        let townPopulation = Number(takeArguments[1]);

        if(dictionary[townName] != undefined) {
            dictionary[townName] += townPopulation;
        } else {
            dictionary[townName] = townPopulation;
        }

    }

    const entries = Object.entries(dictionary);

    for(let [key , value] of entries) {
        console.log('%s : %s',key,value);
    }


}

solution(['Sofia <-> 1000','Montana <-> 2000','New York <-> 3000','Sofia <-> 2000']);


