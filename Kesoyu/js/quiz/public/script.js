console.log("dziala")

const pytanie = document.querySelector("#pytanie");
const odp1 = document.querySelector("#odp_1");
const odp2 = document.querySelector("#odp_2");
const odp3 = document.querySelector("#odp_3");
const odp4 = document.querySelector("#odp_4");

function uzupelnijPytanie(dane){
    pytanie.innerHTML = dane.pytanie;
    odp1.innerHTML = dane.odpowiedz[0];
    odp2.innerHTML = dane.odpowiedz[1];
    odp3.innerHTML = dane.odpowiedz[2];
    odp4.innerHTML = dane.odpowiedz[3];

}

function pokazNastepnePytanie(){
    //fetch(url, opcja) - zwraca obietnicę - promise
    fetch('/quiz_pytanie').then(odp => odp.json()).then(dane =>{
        uzupelnijPytanie(dane);
    })
}
pokazNastepnePytanie();