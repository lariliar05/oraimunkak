function elso(){
    document.querySelector("#eredmeny").innerHTML += "elso fuggveny <br>"
}
function masodik(){
    document.querySelector("#eredmeny").innerHTML += "masodik fuggveny <br>"
}
function harmadik(){
    alert("uzenet")
}
document.querySelector("#btn1").addEventListener("click", elso)
document.querySelector("#btn1").addEventListener("click", masodik)
document.querySelector("#btn1").addEventListener("click", harmadik)

document.querySelector("#btn2").addEventListener("mousecover", function(){
    document.querySelector("#eredmeny").innerHTML += "mousecover <br>"
})
document.querySelector("#btn2").addEventListener("mousecover", function(){
    document.querySelector("#eredmeny").innerHTML += "mousecover <br>"
})
document.querySelector("#btn2").addEventListener("click", function(){
    document.querySelector("#eredmeny").innerHTML += "click <br>"
})

function terulet(a,b){
    //let t = a * b
    //return t
    return a*b
}
console.log(terulet(3, 4))

document.querySelector("#terulet").addEventListener("click", function(){
    document.querySelector("#eredmeny").innerHTML = terulet(3, 4)
})