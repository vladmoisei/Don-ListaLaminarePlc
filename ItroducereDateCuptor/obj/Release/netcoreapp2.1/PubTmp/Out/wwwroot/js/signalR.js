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
    // Retrive data (list of blums) from server
    
    // Convertesc in JSON
    var data = JSON.parse(listaDeTrimisInJavaScript);
    // Actualizare numar bare date afara
    document.getElementById("nrBareDateAfara").innerHTML = nrBareDateAfara;
    // Clear lista afisata inainte
    var corpTabel = document.getElementById('corpTabel');
    corpTabel.innerHTML = "";
    // Pe fiecare rand adaug element primit de la functie Hub
    data.forEach(function (item, index) {
        //alert(index);
        //console.log("Lungime: " + item.Lungime);
        //console.log("Normalizare: " + item.Normalizare);
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
        var tdSectiune = document.createElement("td");
        tdSectiune.innerHTML = item.Sectiune;
        var tdLungime = document.createElement("td");
        tdLungime.innerHTML = item.Lungime;
        var tdNormalizare = document.createElement("td");
        tdNormalizare.innerHTML = item.Normalizare;
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
        // Modific backgound colour la casuta normalizare, pentru a o evidentia mai bine
        IsNormalised(tdNormalizare);

        tr.appendChild(tdId);
        tr.appendChild(tdDiametru);
        tr.appendChild(tdSarja);
        tr.appendChild(tdFurnizor);
        tr.appendChild(tdCalitate);
        tr.appendChild(tdSectiune);
        tr.appendChild(tdLungime);
        tr.appendChild(tdNormalizare);
        tr.appendChild(tdDatAfara);
        tr.appendChild(tdRetur);
        tr.appendChild(tdOraDatAfara);
        //tr.append(tdId, tdDiametru, tdSarja, tdFurnizor, tdCalitate, tdSectiune, tdLungime, tdNormalizare, tdDatAfara, tdRetur, tdOraDatAfara);
        corpTabel.appendChild(tr);
    });

    function CreareDataHTML(item, index) {
        var tr = document.createElement("tr");
        tr.textContent = item.Id;
        document.getElementById('corpTabel').appendChild(tr);
    }

    // Functie verificare daca se normalizeaza si schimba culoare backGround
    function IsNormalised(elem) {
        if (elem.innerHTML === "N") {
            elem.classList.add("background_violet");
        }
    }
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