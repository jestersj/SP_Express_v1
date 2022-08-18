// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//Маска ввода
window.addEventListener("DOMContentLoaded", function() {
    [].forEach.call( document.querySelectorAll('.tel'), function(input) {
    var keyCode;
    function mask(event) {
        event.keyCode && (keyCode = event.keyCode);
        var pos = this.selectionStart;
        if (pos < 3) event.preventDefault();
        var matrix = "+7 (___) ___ ____",
            i = 0,
            def = matrix.replace(/\D/g, ""),
            val = this.value.replace(/\D/g, ""),
            new_value = matrix.replace(/[_\d]/g, function(a) {
                return i < val.length ? val.charAt(i++) || def.charAt(i) : a
            });
        i = new_value.indexOf("_");
        if (i != -1) {
            i < 5 && (i = 3);
            new_value = new_value.slice(0, i)
        }
        var reg = matrix.substr(0, this.value.length).replace(/_+/g,
            function(a) {
                return "\\d{1," + a.length + "}"
            }).replace(/[+()]/g, "\\$&");
        reg = new RegExp("^" + reg + "$");
        if (!reg.test(this.value) || this.value.length < 5 || keyCode > 47 && keyCode < 58) this.value = new_value;
        if (event.type == "blur" && this.value.length < 5)  this.value = ""
    }

    input.addEventListener("input", mask, false);
    input.addEventListener("focus", mask, false);
    input.addEventListener("blur", mask, false);
    input.addEventListener("keydown", mask, false)

  });

});


//Страница регистрации
const regChoice = document.getElementById('regChoice');

const individualBtn = document.getElementById('individualBtn');
const legalBtn = document.getElementById('legalBtn');

const ind = document.getElementById('ind');
const legal = document.getElementById('legal');

individualBtn.addEventListener("click", ()=> {
    regChoice.style.display = 'none';
    ind.style.display = 'flex';
})
legalBtn.addEventListener("click", ()=> {
    regChoice.style.display = "none";
    legal.style.display = "flex";
})


const back1 = document.getElementById('back1');
const back2 = document.getElementById('back2');

back1.addEventListener("click", ()=> {
    regChoice.style.display = "flex";
    ind.style.display = "none";
})
back2.addEventListener("click", ()=> {
    regChoice.style.display = "flex";
    legal.style.display = "none";
})