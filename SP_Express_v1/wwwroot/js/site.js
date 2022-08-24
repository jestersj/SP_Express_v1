﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
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

//Password requirements
const passwordInput = document.getElementById('passwordReg'); //input for password
const regBtn = document.getElementById('regBtn'); //Button

const passEr1 = document.getElementById('passEr1');
const passEr2 = document.getElementById('passEr2');

passwordInput.oninput = ()=> {
    //Presence of uppercase letter
    let upp = 0;
    passwordInput.value.split('').map(el => {
        if (el === el.toUpperCase()) {
            upp++
        }
    })
    if (upp > 0) {
        passEr1.innerHTML = ''

    }
    else {
        passEr1.innerHTML = '<li><p class="text-uppercase">Нужна минимум одна заглавная буква</p></li><br>'

    }
    //lenth
    if (passwordInput.value.split('').length < 8) {
        passEr2.innerHTML = '<li><p class="text-uppercase">В пароле должно быть минимум 8 символов</p></li><br>'

    } else {
        passEr2.innerHTML = ''

    }
    //Accordance to all requirements
    regBtn.disabled = !(upp > 0 &&
        passwordInput.value.split('').length > 8);


}

