const express=require('express');
const app= express();
const port=8080;
app.get('/',(req,res)=>{
    res.sendFile("./public/index.html",{root:__dirname});
})

app.listen(port,()=>{
    console.log(`running on ${port}`);
})
