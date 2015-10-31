// Write a function to count the number of div elements on the web page

(function () {
    'use strict';
    function countDivs() {
        var divs = document.getElementsByTagName('div');
        return divs.length;
    }

    console.log('The number of divs in the page is: ' + countDivs());
})();