// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.getElementById("butonAscundere").addEventListener("click", function (event) {
    event.preventDefault();
    document.getElementById("formularButoane").classList.add("hidden");
});