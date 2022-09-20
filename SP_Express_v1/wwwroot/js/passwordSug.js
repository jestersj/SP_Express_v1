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
        if (el.match(/\D/) && el === el.toUpperCase()) {
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
        if (el.match(/\D/) && el === el.toLowerCase()) {
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
        if (el.match(/\D/) && /\w/.test(el)) {
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
    // regBtn.disabled = !(nonLatin===0);
}
