const {Router} = require('express');

const router = Router();


router.get('/', (req,res) => {
    res.send("here you can find products");
});


router.get('/:userId', (req,res) => {
    console.log(req.params.userId);
    res.send(req.params);
});

module.exports = router;