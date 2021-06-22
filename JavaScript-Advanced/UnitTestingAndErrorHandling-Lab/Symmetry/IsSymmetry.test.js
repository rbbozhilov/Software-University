const isSymmetric = require('../IsSymmetry');
const assert = require('chai').assert;

describe('Testing array is it symmetric', () => {

    it('Should be symetric', () => {

        assert.isTrue(isSymmetric([1,2,3,2,1]));
    })

    it('Should not  be symetric', () => {

        assert.isFalse(isSymmetric([1,2,3,4,1]));
    })

    it('Should return false  because of different type', () => {

        assert.isFalse(isSymmetric([1,'edasds',3,4,1]));
    })

    it('Should return false  because of different type', () => {

        assert.isFalse(isSymmetric('eerr'));
    })

    it('Should return falsee  because of different type', () => {

        assert.isFalse(isSymmetric(-1));
    })

    it('should be true', () => {

        assert.isTrue(isSymmetric([1]));

    })


    it('should nott  be symmetric', () => {

        assert.isFalse(isSymmetric([1,'1']));


    });

});



