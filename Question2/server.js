//server js file in express js? 
var express = require('express'),
    path = require('path'),
    app = express();

const bodyParser = require('body-parser');
const homeRoutes=require('./routes/home');
app.use(bodyParser.json());
// app.get('/',function(req,res){
//    res.sendFile(path.join(__dirname + '/public/index.html')); 
// });
app.use(homeRoutes);

app.listen(8080,()=>{
    console.log("running on 8080 ")
});



