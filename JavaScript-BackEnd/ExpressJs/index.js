const express = require('express');
const productController = require('./productController');
const homeController = require('./homeController');
const app = express();




app.use('/', homeController);
app.use('/product',productController);

app.listen(3000);