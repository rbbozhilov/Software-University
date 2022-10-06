const {Router} = require('express');

const router = Router();

router.get('/', (req,res) => {
    res.send('aloha');
});

router.post('/',(req,res) => {
    console.log("can you hear me");
    res.end();
});


module.exports = router;




