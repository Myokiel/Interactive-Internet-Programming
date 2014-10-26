var dynamicObject = {};
dynamicObject.Name = "Whosonfirst";
dynamicObject.size = "Whatsonsecond";
dynamicObject.NewName = "I now have a new name";


function ToggleNewPicture() {

    var footimages = document.getElementsByClassName("footsteps-image");
    var progimages = document.getElementsByClassName("programming-image");


    if (footimages.length > 0) {
        footimages[0].className = "programming-image";
    }
    else if (progimages.length > 0) {
        progimages[0].className = "footsteps-image";
    }


}
function ToggleHighlight() {

    var images = document.getElementsByClassName("familysquirrel-image");
    var hImages = document.getElementsByClassName("familysquirrel-highlight");


    if (images[0] != null) {
        images[0].className = "familysquirrel-highlight";
    }
    else {
        hImages[0].className = "familysquirrel-image";
    }


}


function MouseOver(big) {
    big.className = "list-item-bigger";
}
function MouseOut(big) {
    big.className = "";
}


var newNameUpdate = function (page, input, message) {
    message.innerHTML = dynamicObject.NewName;
    page.removeChild(input);
};
function TextInputChanged(input) {
    var page = document.getElementsByClassName("m-yoke")[0];
    var message = document.getElementsByClassName("footer")[0];
    newNameUpdate(page, input, message);
}