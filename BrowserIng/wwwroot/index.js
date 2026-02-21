var _stg = window.localStorage;
var _UserID = "";

const genRandHex = size => 
[...Array(size)]
.map(() => Math.floor(Math.random() * 16).toString(16))
.join('');

(function($)
{

$(document).ready(function() {
    $('.slider').slider();
    $('.parallax').parallax();
    $('.dropdown-trigger').dropdown({
            inDuration: 300,
              outDuration: 225,
              constrain_width: false, // Does not change width of dropdown to that of the activator
              hover: true, // Activate on hover, not click
              alignment: 'left', // Aligns dropdown (works with constrain_width)
              gutter: 0, // Spacing from edge
              belowOrigin: true // Displays dropdown below the button
    });
    $('.scrollspy').scrollSpy();
    $(".dropdown-button").dropdown();
    $(".button-collapse").sideNav();
    $('select').material_select();
    $('.datepicker').pickadate({
        selectMonths: true, // Creates a dropdown to control month
        selectYears: 15 // Creates a dropdown of 15 years to control year
    });
    $('.modal-trigger').leanModal();
    $('.carousel').carousel();
    $('.collapsible').collapsible();
    fnProcessUserID();
    
});

function fnProcessUserID()
{
    _UserID =  fnGetUserID();
    if(Boolean(_UserID)) 
    {
     console.log("Existing UserID. TODO:// get stored data from server (RefID, etc)");
    } 
    else
    {
     _UserID = genRandHex(64);
     console.log("New UserID. TODO:// Send and store serverside");
     // TODO:// Send and store serverside
    } 
       
    console.log(_UserID);
    fnSetUserID(_UserID);
}

function fnGetUserID()
{
    try 
    {
        return _stg.getItem('UserID');
    }
    catch (e) { console.error('Couldnt get UserID'); } 
    return null;
}

function fnSetUserID(s)
{   
    try { _stg.setItem('UserID', s); } 
    catch (e) { console.error('Couldnt store current UserID');  }
}


})(jQuery); 

// https://bitwiseshiftleft.github.io/sjcl/ for crypto

/*
function createCookie(name, value, days) {
    var expires;

    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
        expires = "; expires=" + date.toGMTString();
    } else {
        expires = "";
    }
    document.cookie = encodeURIComponent(name) + "=" + encodeURIComponent(value) + expires + "; path=/";
}

function readCookie(name) {
    var nameEQ = encodeURIComponent(name) + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) === ' ')
            c = c.substring(1, c.length);
        if (c.indexOf(nameEQ) === 0)
            return decodeURIComponent(c.substring(nameEQ.length, c.length));
    }
    return null;
}

function eraseCookie(name) {
    createCookie(name, "", -1);
}
*/