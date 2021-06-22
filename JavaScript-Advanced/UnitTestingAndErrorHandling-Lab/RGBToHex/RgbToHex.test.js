const rgbToHexColor = require('../RgbToHex');
const assert = require('chai').assert;

describe('Testing functionality of the convertor', () => {



    it('Should return undefined red is less 0 ', () => {


        assert.isUndefined(rgbToHexColor(-1,5,10));


    });

    it('Should return undefined red is more then 255 ', () => {


        assert.isUndefined(rgbToHexColor(256,5,10));


    });


    it('Should return undefined red is not number ', () => {


        assert.isUndefined(rgbToHexColor('eee',5,10));


    });


    it('Should return undefined green is less 0 ', () => {


        assert.isUndefined(rgbToHexColor(5,-1,10));


    });

    it('Should return undefined green is more then 255 ', () => {


        assert.isUndefined(rgbToHexColor(5,256,10));


    });


    it('Should return undefined green is not number ', () => {


        assert.isUndefined(rgbToHexColor(5,'rrr',10));


    });


    it('Should return undefined blue is less 0 ', () => {


        assert.isUndefined(rgbToHexColor(5,10,-1));


    });

    it('Should return undefined blue is more then 255 ', () => {


        assert.isUndefined(rgbToHexColor(5,10,256));


    });


    it('Should return undefined blue is not number ', () => {


        assert.isUndefined(rgbToHexColor(5,56,'ere3'));


    });

    it('Should be correct', () => {


        let actualResult = rgbToHexColor(10,55,70);
        let red = 10;
        let green = 55;
        let blue = 70;
        let expectedResult = "#" +
        ("0" + red.toString(16).toUpperCase()).slice(-2) +
        ("0" + green.toString(16).toUpperCase()).slice(-2) +
        ("0" + blue.toString(16).toUpperCase()).slice(-2);


        assert.equal(actualResult,expectedResult);


    })


    it('Should be correct again', () => {


        let actualResult = rgbToHexColor(105,15,67);
        let red = 105;
        let green = 15;
        let blue = 67;
        let expectedResult = "#" +
        ("0" + red.toString(16).toUpperCase()).slice(-2) +
        ("0" + green.toString(16).toUpperCase()).slice(-2) +
        ("0" + blue.toString(16).toUpperCase()).slice(-2);


        assert.equal(actualResult,expectedResult);


    })



    it('Should return undefined everything is not undefined', () => {


        assert.isUndefined(rgbToHexColor(-55,'rrr',270));


    });



    it('Should return undefined everything is not undefined', () => {


        assert.isUndefined(rgbToHexColor(-55,2566,-1));


    });

    it('Should be correct again23', () => {


        let actualResult = rgbToHexColor(0,255,255);
        let red = 0;
        let green = 255;
        let blue = 255;
        let expectedResult = "#" +
        ("0" + red.toString(16).toUpperCase()).slice(-2) +
        ("0" + green.toString(16).toUpperCase()).slice(-2) +
        ("0" + blue.toString(16).toUpperCase()).slice(-2);


        assert.equal(actualResult,expectedResult);


    })

});