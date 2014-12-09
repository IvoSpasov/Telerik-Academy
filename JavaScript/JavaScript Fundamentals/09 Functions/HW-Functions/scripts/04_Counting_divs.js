// 04 Write a function to count the number of divs on the web page

function countDivs() {
    var divs = document.getElementsByTagName('div');
    var divsCount = divs.length;
    console.log('The number of divs is: ' + divsCount);
}

countDivs();