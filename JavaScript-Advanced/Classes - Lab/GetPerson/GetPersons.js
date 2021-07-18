
function arrInstance() {

class Person {

    constructor(firstName,lastName,age,email) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.email = email;
    }


    toString() {
        return `${this.firstName} ${this.lastName} (age: ${this.age}, email: ${this.email})`;
    }
}
let arrOfIstances = [];
arrOfIstances.push(new Person('Anna','Simpson',22,'anna@yahoo.com'));
arrOfIstances.push(new Person('SoftUni'));
arrOfIstances.push(new Person('Stephan','Johnson',25));
arrOfIstances.push(new Person('Gabriel','Peterson',24,'g.p@gmail.com'));


return arrOfIstances;
}
