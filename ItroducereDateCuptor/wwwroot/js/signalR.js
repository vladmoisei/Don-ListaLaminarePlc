// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// JavaScript Code used for SignalR


//alert("Merge! din signalR javascript");
"use strict";
// Construire conexiune Hub SignalR on Server
var connection = new signalR.HubConnectionBuilder().withUrl("/ListaHub").build();

// Receive functie apelata dupa server
connection.on("show_data", function (listaDeTrimisInJavaScript, nrBareDateAfara) {
    var data = JSON.parse(listaDeTrimisInJavaScript);
    // Actualizare numar bare date afara
    document.getElementById("nrBareDateAfara").innerHTML = nrBareDateAfara;
    // Clear lista afisata inainte
    var corpTabel = document.getElementById('corpTabel');
    corpTabel.innerHTML = "";
    // Pe fiecare rand adaug element primit de la functie Hub
    data.forEach(function (item, index) {
        //alert(index);
        // Creare rand element
        var tr = document.createElement("tr");
        // Creare camp pentru fiecare element obiect
        var tdId = document.createElement("td");
        tdId.innerHTML = item.Id;
        var tdDiametru = document.createElement("td");
        tdDiametru.innerHTML = item.Diametru;
        var tdSarja = document.createElement("td");
        tdSarja.innerHTML = item.Sarja;
        var tdFurnizor = document.createElement("td");
        tdFurnizor.innerHTML = item.Furnizor;
        var tdCalitate = document.createElement("td");
        tdCalitate.innerHTML = item.Calitate;
        var tdDatAfara = document.createElement("td");
        tdDatAfara.innerHTML = item.IsDatAfara;
        // Afisez checkbox in loc de true or false
        if (tdDatAfara.innerHTML === "true") {
            tdDatAfara.innerHTML = '<input checked="checked" class="check-box" disabled="disabled" type="checkbox">';
        } else {
            tdDatAfara.innerHTML = '<input class="check-box" disabled="disabled" type="checkbox">';
        }         
        var tdRetur = document.createElement("td");
        tdRetur.innerHTML = item.IsRetur;
        // Afisez checkbox in loc de true or false
        if (tdRetur.innerHTML === "true") {
            tdRetur.innerHTML = '<input checked="checked" class="check-box" disabled="disabled" type="checkbox">';
        } else {
            tdRetur.innerHTML = '<input class="check-box" disabled="disabled" type="checkbox">';
        }         
        var tdOraDatAfara = document.createElement("td");
        tdOraDatAfara.innerHTML = item.DataOraLaminare;
        // Afisez checkbox in loc de true or false
        if (item.IsDatAfara || item.IsRetur) {
            tr.classList.add("background_green");
        }        
        tr.append(tdId, tdDiametru, tdSarja, tdFurnizor, tdCalitate, tdDatAfara, tdRetur, tdOraDatAfara);
        corpTabel.appendChild(tr);
    });

    //tr.textContent = listaDeAfisat.length;
    //console.log(tr.textContent);
    //document.getElementById('corpTabel').appendChild(tr);

    //listaDeAfisat.forEach(CreareDataHTML);

    function CreareDataHTML(item, index) {
        var tr = document.createElement("tr");
        tr.textContent = item.Id;
        document.getElementById('corpTabel').appendChild(tr);
    }
    //var lista = JSON.parse(listaDeAfisat);
    //console.log(listaDeAfisatt);
    //var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    //var encodedMsg = user + " says " + msg;
    //var li = document.createElement("li");
    //li.textContent = encodedMsg;
    //document.getElementById("messagesList").appendChild(li);
});

//connection.on("ReceiveMessage", function (user, message) {
//    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
//    var encodedMsg = user + " says " + msg;
//    var li = document.createElement("li");
//    li.textContent = encodedMsg;
//    document.getElementById("messagesList").appendChild(li);
//});

connection.start().then(function () {
    console.log("connected");
});

//$.connection.start().then(function () {
//    console.log("connected");
//});

//$.connection.start()
//    .done(function () { console.log("Merge din hub!"); })
//    .fail(function () { alert("Error!"); });