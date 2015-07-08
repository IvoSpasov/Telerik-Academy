function onButtonClick(event, arguments) {
    var browserName = window.navigator.appCodeName,
        isMozilla = browserName === "Mozilla";

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}