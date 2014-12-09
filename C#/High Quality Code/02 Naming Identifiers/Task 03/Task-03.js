// 03 Refactor the following examples to produce code with well-named identifiers in JavaScript

//function _ClickON_TheButton(THE_event, argumenti) {
//    var moqProzorec = window;
//    var brauzyra = moqProzorec.navigator.appCodeName;
//    var ism = brauzyra == "Mozilla";
//    if (ism) {
//        alert("Yes");
//    }
//    else {
//        alert("No");
//    }
//}

function clickOnTheButton(event, buttonArguments) {
    'use strict';
    var browserName = window.navigator.appCodeName,
        isMozilla = browserName === "Mozilla";
    if (isMozilla) {
        alert("Yes");
    }
    else
    {
        alert("No");
    }
}