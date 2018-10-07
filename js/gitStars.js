var descriptionTexts = document.getElementsByName("descText");
var data = {}

var Http = new XMLHttpRequest();
var url='https://api.github.com/repos/LordMascachapas/Hackaton_exercises/stargazers';
Http.open("GET", url);
Http.send();
Http.onreadystatechange=(e)=>{
    data = JSON.parse(Http.responseText);
    for(i = 0; i < descriptionTexts.length; i++){
        if (data.length == 0) {
            descriptionTexts[i].innerHTML = "¡¡¡ Este repositorio no tiene estrellas /(7_7)\\ !!!";
        } else {
            descriptionTexts[i].innerHTML = "Este repositorio tiene " + data.length + " estrellas :D";
        }
    }
}