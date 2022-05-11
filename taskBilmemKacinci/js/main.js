var input = document.getElementById("textInput");
input.addEventListener("keyup",function(){
    if(!isNaN(input.value)){
     input.remove("input");
    }
    else{
        input.style.borderColor="black";
    }
})