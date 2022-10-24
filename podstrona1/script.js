var counter = 0;

document.getElementById('wykonaj_dodawanie').addEventListener('click', function(){
    counter += 1;

    var liczba1 = Number(document.getElementById('pierwsza_liczba').value);
    var liczba2 = Number(document.getElementById('druga_liczba').value);
    var wynik = liczba1 + liczba2;

    document.getElementById('pole_wynikowe').value = wynik;

    document.getElementById('wyniki').innerHTML += "<span>" + counter + ". " + wynik + "</span><br>";
});


