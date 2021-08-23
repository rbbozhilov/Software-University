let assert = require('chai').assert;
let cinema = require('../cinema');

describe('Tests' ,function()  {

    it('should return no movies', function()  {


        let movieArr = [];

        let expect = 'There are currently no movies to show.';

        let actual = cinema.showMovies(movieArr);

        assert.equal(actual,expect);


    })

    it('should return moviese', function() {


        let movieArr = ['grill','mocha','chai'];

        let expect = 'grill, mocha, chai';

        let actual = cinema.showMovies(movieArr);

        assert.equal(actual,expect);


    })

    it('should return moviesee2', function() {


        let movieArr = ['grill'];

        let expect = 'grill';

        let actual = cinema.showMovies(movieArr);

        assert.equal(actual,expect);


    })



    it('ticket price Premiere',function() {


       let expect = 12.00;

       let actual = cinema.ticketPrice('Premiere');

       assert.equal(expect,actual);



    })

    it('ticket price Normal',function() {


        let expect = 7.50;
 
        let actual = cinema.ticketPrice('Normal');
 
        assert.equal(expect,actual);
 
 
 
     })

     it('ticket price Discount', function() {


        let expect = 5.50;
 
        let actual = cinema.ticketPrice('Discount');
 
        assert.equal(expect,actual);
 
 
 
     })

     it('ticket price Throw', function() {


        assert.throw(() => cinema.ticketPrice('gosho'));
 
 
 
     })


     it('first place is string',function() {


        let expect = "Unsuccessful change of seats in the hall.";

        let actual = cinema.swapSeatsInHall('string',2);

        assert.equal(expect,actual);
 
 
 
     })

     it('second place is string', function() {


        let expect = "Unsuccessful change of seats in the hall.";

        let actual = cinema.swapSeatsInHall(5,'string');

        assert.equal(expect,actual);
 
 
 
     })
     
     it('both places is string', function() {


        let expect = "Unsuccessful change of seats in the hall.";

        let actual = cinema.swapSeatsInHall('string','string');

        assert.equal(expect,actual);
 
 
 
     })

     it('first place is negative', function() {


        let expect = "Unsuccessful change of seats in the hall.";

        let actual = cinema.swapSeatsInHall(0,5);

        assert.equal(expect,actual);
 
 
 
     })

     it('first place is negative1', function() {


        let expect = "Unsuccessful change of seats in the hall.";

        let actual = cinema.swapSeatsInHall(-1,5);

        assert.equal(expect,actual);
 
 
 
     })

     it('first place is much then 20', function() {


        let expect = "Unsuccessful change of seats in the hall.";

        let actual = cinema.swapSeatsInHall(21,5);

        assert.equal(expect,actual);
 
 
 
     })

     it('second place is negativeer', function() {


        let expect = "Unsuccessful change of seats in the hall.";

        let actual = cinema.swapSeatsInHall(5,0);

        assert.equal(expect,actual);
 
 
 
     })

     it('second place is negativeer2', function() {


        let expect = "Unsuccessful change of seats in the hall.";

        let actual = cinema.swapSeatsInHall(5,-1);

        assert.equal(expect,actual);
 
 
 
     })

     it('both place is negativeer32', function() {


        let expect = "Unsuccessful change of seats in the hall.";

        let actual = cinema.swapSeatsInHall(0,-1);

        assert.equal(expect,actual);
 
 
 
     })

     it('both place are same', function() {


        let expect = "Unsuccessful change of seats in the hall.";

        let actual = cinema.swapSeatsInHall(1,1);

        assert.equal(expect,actual);
 
 
 
     })

     it('second place more then 20', function() {


        let expect = "Unsuccessful change of seats in the hall.";

        let actual = cinema.swapSeatsInHall(1,21);

        assert.equal(expect,actual);
 
 
 
     })

     it('both  same ee place more then 20', function() {


        let expect = "Unsuccessful change of seats in the hall.";

        let actual = cinema.swapSeatsInHall(20,20);

        assert.equal(expect,actual);
 
 
 
     })

     it('Success change', function() {


        let expect = "Successful change of seats in the hall.";

        let actual = cinema.swapSeatsInHall(1,20);

        assert.equal(expect,actual);
 
 
 
     })

     it('Success change2', function() {


        let expect = "Successful change of seats in the hall.";

        let actual = cinema.swapSeatsInHall(1,15);

        assert.equal(expect,actual);
 
 
 
     })


     it('Success change3', function() {


        let expect = "Successful change of seats in the hall.";

        let actual = cinema.swapSeatsInHall(2,1);

        assert.equal(expect,actual);
 
 
 
     })


});