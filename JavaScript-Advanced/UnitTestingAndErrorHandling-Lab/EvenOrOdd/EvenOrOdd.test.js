const assert = require('chai').assert;
const isOddOrEven = require('../EvenOrOdd');


describe('Testing odd or even number it is', () => {

    it('Should be odd number', () => {

        let currentString = 'Pesho';
        let actualResult = isOddOrEven(currentString);
        let expectedResult = 'odd';

        assert.equal(actualResult,expectedResult);


    });

    it('Should be even number', () => {

        let currentString = 'Peshoo';
        let actualResult = isOddOrEven(currentString);
        let expectedResult = 'even';

        assert.equal(actualResult,expectedResult);


    });

    it('Should be even number', () => {

        

        assert.isUndefined(isOddOrEven(5));


    });


});