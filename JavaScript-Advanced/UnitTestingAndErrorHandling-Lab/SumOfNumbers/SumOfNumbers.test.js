const sum = require('../SumOfNumbers');
const assert = require('chai').assert;


describe('Testing sum from array', () => {


    it('Should return correct answer with posiitve numbers', () => {

        let currentArr = [1,2,3,4,5];
        let expectedResult = 15;

        let actulaSum = sum(currentArr);

        assert.strictEqual(actulaSum,expectedResult);

    });

    it('Should return false', () => {
        let currentArr = [1,2];
        let expectedResult = 6;

        let actualSum = sum(currentArr);

        assert.notEqual(actualSum,expectedResult);
    })

    it('Should be correct with negative numbers ', () => {
        let currentArr = [-1,-2,-3,-4];
        let expectedResult = -10;

        let actualSum = sum(currentArr);

        assert.equal(actualSum,expectedResult);
    })

    it('Should be fine with negatives',() => {


        let currentArr = [-2,-3,-4];
        
        assert.notEqual(sum(currentArr),-200);

    });


});

