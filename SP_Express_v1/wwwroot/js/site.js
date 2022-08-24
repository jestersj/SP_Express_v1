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




/////Password requirements
const passwordInput = document.getElementById('passwordReg'); //input for password
const passwordCheck = document.getElementById('passwordReg2');//input for checking password
const regBtn = document.getElementById('regBtn'); //Button

const passEr1 = document.getElementById('passEr1');
const passEr2 = document.getElementById('passEr2');
const passEr3 = document.getElementById('passEr3');
const passEr4 = document.getElementById('passEr4');
const passEr5 = document.getElementById('passEr5');
const passEr6 = document.getElementById('passEr6');


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
        passEr1.innerHTML = '<p class="text-uppercase">Нужна минимум одна заглавная буква</p>'

    }
    
    
    //Presence of lowercase letter
    let low = 0;
    passwordInput.value.split('').map(el => {
        if (el === el.toLowerCase() && /\D/.test(el)) {
            low++;
        }
    })
    if (low > 0) {
        passEr6.innerHTML = ''

    }
    else {
        passEr6.innerHTML = '<p class="text-uppercase">Нужна минимум одна незаглавная буква</p>'

    }
    
    
    //Length
    if (passwordInput.value.split('').length < 8) {
        passEr2.innerHTML = '<p class="text-uppercase">В пароле должно быть минимум 8 символов</p>'

    } else {
        passEr2.innerHTML = ''

    }
    
    //Presence of number
    let nums = 0;
    passwordInput.value.split('').map(el => {
        if (/\d/.test(el)) {
            nums++;
        }
    })
    if (nums>0) {
        passEr3.innerHTML = ''
    } else {
        passEr3.innerHTML = '<p class="text-uppercase">Нужна минимум одна цифра</p>'
    }
    
    //Presence of latin letter
    let letters = 0;
    passwordInput.value.split('').map(el => {
        if (/\w/.test(el)) {
            letters++;
        }
    })
    if (letters>0) {
        passEr4.innerHTML = ''
    } else {
        passEr4.innerHTML = '<p class="text-uppercase">Нужна минимум одна буква латинского алфавита</p>'
    }
    
    //Absence of non-latin letter
    let nonLatin = 0;
    passwordInput.value.split('').map(el => {
        if (/\W/.test(el)) {
            nonLatin++;
        }
    })
    if (nonLatin===0) {
        passEr5.innerHTML = ''
    } else {
        passEr5.innerHTML = '<p class="text-uppercase">Можно использовать только буквы латиницы</p>'
    }
    
    //Accordance to all requirements
    regBtn.disabled = !(nonLatin===0);
}


function show_hide_password(target, id){
    const input = document.getElementById(id);
    if (input.getAttribute('type') === 'password') {
        target.classList.add('view');
        input.setAttribute('type', 'text');
    } else {
        target.classList.remove('view');
        input.setAttribute('type', 'password');
    }
    return false;
}
