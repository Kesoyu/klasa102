const express = require('express');
const app = express();

const host = '127.0.0.1';
const port = 5555;
const www = __dirname + '\\public';

app.listen(port, ()=>{console.log(`listening on port ${host}:${port}`);});

app.use(express.static(www));

let przekazanePytania=0;
const pytania = [
    {pytanie: "asd", odpowiedz:["jeden","dwa","trzey","czterty"], poprawna_odpowiedz:0},
    {pytanie: "dsa", odpowiedz:["jeden","dwa","trzey","czterty"], poprawna_odpowiedz:3},
    {pytanie: "ska", odpowiedz:["jeden","dwa","trzey","czterty"], poprawna_odpowiedz:1}
]

app.get('/quiz_pytanie', (req,res)=>{
    const kolejne_pytanie = pytania[przekazanePytania];
    let pytanie = pytania[przekazanePytania].pytanie;
    let odpowiedz = pytania[przekazanePytania].odpowiedz;
    res.json({
        pytanie,odpowiedz
    })
    console.log(pytanie,odpowiedz);
});

const obietnica = new Promise((resolve,reject)=>{
    const wylosowana = Math.random().toFixed(2);
    if(wylosowana>0.5)
        resolve(wylosowana)
    else
        reject(wylosowana)
})
obietnica.then(wylosowana=>{
    console.log("wylosowana liczba"+wylosowana)
}).catch(wylosowana => {
    console.log("obietnica nie spełniopnads"+wylosowana);
});