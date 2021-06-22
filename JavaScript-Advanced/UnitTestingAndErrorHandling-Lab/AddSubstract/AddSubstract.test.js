const createCalculator = require('../AddSubstract');
const assert = require('chai').assert;

describe('Testing functions of calculator', () => {


    it('Should be Object', () => {


        let currentObject = createCalculator();

        assert.isObject(currentObject);


    });

    it('Should be fine with add function', () => {


        let currentObject = createCalculator();

        currentObject.add(5);
        currentObject.add(5);
        let actualResult = currentObject.get();
        let expectedResult = 10;

        assert.equal(actualResult,expectedResult);


    });

    it('Should be fine with add function1', () => {


        let currentObject = createCalculator();

        currentObject.add(5);
        let actualResult = currentObject.get();
        let expectedResult = 5;

        assert.equal(actualResult,expectedResult);


    });


    it('It should subtract', () => {

        let currentObject = createCalculator();

        currentObject.add(5);
        currentObject.subtract(6);
        let actualResult = currentObject.get();
        let expectedResult = -1;

        assert.equal(actualResult,expectedResult);

    })

    it('It should subtract1', () => {

        let currentObject = createCalculator();

        currentObject.add(5);
        currentObject.add(5);
        currentObject.add(5);
        currentObject.subtract(5);
        currentObject.subtract(10);
        let actualResult = currentObject.get();
        let expectedResult = 0;

        assert.equal(actualResult,expectedResult);

    });

    it('get value', () => {

        let currentObject = createCalculator();

        let actualResult = currentObject.get();

        assert.equal(actualResult,0);
      


    });

    it('Sum number and string', () => {

        let currentObject = createCalculator();

         currentObject.add(5);
         currentObject.add('55');
         let expectedResult = 60;
         let actualResult = currentObject.get();

        assert.equal(actualResult,expectedResult);
      


    });


    it('substract number and string', () => {

        let currentObject = createCalculator();

         currentObject.subtract(5);
         currentObject.subtract('55');
         let expectedResult = -60;
         let actualResult = currentObject.get();

        assert.equal(actualResult,expectedResult);
      


    });

});