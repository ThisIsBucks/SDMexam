const path= require('path');
const express=require('express');
const { dirname } = require('path');
const router = express.Router();


router.get('/',(req,res)=>{
    res.sendFile(path.join(__dirname , '../public/index.html'));
});

router.get('/about',(req,res)=>{
    res.sendFile(path.join(__dirname , '../public/about.html'));
});

router.get('/user',(req,res)=>{
    res.sendFile(path.join(__dirname ,'../public/user.html'));

});
module.exports = router ;