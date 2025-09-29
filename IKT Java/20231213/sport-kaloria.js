function szamol() {
    let kpo = document.querySelector('.kpo').innerHTML
    let perc = document.querySelector('input[type="number"]').value
    let cal = document.querySelector('.cal')
    cal.value = (kpo * perc / 60).toFixed()
}
document.querySelector('input[type="number"]').onchange = szamol

function szamol(x) {
    let kpo = document.querySelectorAll('.kpo')[x].innerHTML
    let perc = document.querySelectorAll('input[type="number"]')[x].value
    let cal = document.querySelectorAll('.cal')[x]
    cal.value = (kpo * perc / 60).toFixed()
}

for (let i = 0; i < 10; i++) {
    document.querySelectorAll('input[type="number"]')[i].onchange=function () {
        szamol(i)
    }
}

function torles(){
    let inputok = document.querySelectorAll("input")
    
}


