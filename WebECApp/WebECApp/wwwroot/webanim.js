
var menuitems= document.getElementById("ECmenu");

menuitems.style.maxHeight = "0px";

function menudrop(){
    if (menuitems.style.maxHeight == "0px")
    {
        menuitems.style.maxHeight = "200px";
    }
    else
    {
        menuitems.style.maxHeight = "0px";
    }
}


// java for product img
var productimg = document.getElementById("productimg");
var smallimg = document.getElementsByClassName("smallimg");

smallimg[0].onclick = function () {
    productimg.src = smallimg[0].src;
}
smallimg[1].onclick = function () {
    productimg.src = smallimg[1].src;
}
smallimg[2].onclick = function () {
    productimg.src = smallimg[2].src;
}
smallimg[3].onclick = function () {
    productimg.src = smallimg[3].src;
}
smallimg[4].onclick = function () {
    productimg.src = smallimg[4].src;
}
smallimg[5].onclick = function () {
    productimg.src = smallimg[5].src;
}


// auto Image slider



//-----------------video controlls----------------
