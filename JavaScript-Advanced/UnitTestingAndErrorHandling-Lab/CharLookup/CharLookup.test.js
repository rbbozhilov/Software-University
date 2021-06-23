const assert = require('chai').assert;
const lookupChar = require('../CharLookup');

describe('Testing function for getting char by index', () => {


    it('Should return undefined is not string', () => {

        assert.isUndefined(lookupChar(43,5));


    });

    it('Should return undefined is not number', () => {

        assert.isUndefined(lookupChar('string',2.5));


    });

    it('Should return undefined is not number1', () => {

        assert.isUndefined(lookupChar('string','eho'));


    });

    it('should not be correct index4 ', () => {

        assert.equal(lookupChar('pesho',7),'Incorrect index');


    });

    it('should not be correct index2 ', () => {

        assert.equal(lookupChar('tisho',5),'Incorrect index');


    });

    it('should not be correct index6 ', () => {

        assert.equal(lookupChar('goshko',-1),'Incorrect index');


    });

    it('should be correct', () => {

        assert.equal(lookupChar('Dimo',0),'D');
        assert.equal(lookupChar('gosho',4),'o');
        assert.equal(lookupChar('D1imo',1),'1');
        assert.equal(lookupChar('Di3mo',2),'3');


    });
  

});