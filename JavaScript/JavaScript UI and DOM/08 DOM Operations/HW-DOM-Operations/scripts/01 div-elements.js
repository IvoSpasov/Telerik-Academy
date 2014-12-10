function createRandomDivs() {

    var divElement,
        divWidth,
        divHeight,
        strongElement,
        numberofDivs = 50,
        dFrag = document.createDocumentFragment();

    for (var i = 0; i < numberofDivs; i += 1) {
        divElement = document.createElement('div');
        divWidth = getRandomInt(20, 100);
        divHeight = getRandomInt(20, 100);

        divElement.style.width = divWidth + 'px';
        divElement.style.height = divHeight + 'px';
        divElement.style.backgroundColor = getRandomColor();
        divElement.style.color = getRandomColor();
        divElement.style.position = 'absolute';
        divElement.style.left = getRandomInt(0, window.innerWidth - divWidth - 50) + 'px';
        divElement.style.top = getRandomInt(0, window.innerHeight - divHeight - 50) + 'px';
        divElement.style.borderWidth = getRandomInt(1, 20) + 'px';
        divElement.style.borderStyle = 'solid';
        divElement.style.borderColor = getRandomColor();
        divElement.style.borderRadius = getRandomInt(0, 50) + 'px';

        strongElement = document.createElement('strong');
        strongElement.innerHTML = 'div';
        divElement.appendChild(strongElement);

        dFrag.appendChild(divElement);
    }

    document.body.appendChild(dFrag);    
}

function getRandomInt(min, max) {
    if (min === max) {
        return min;
    }
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function getRandomColor() {
    var r = getRandomInt(0, 255),
        g = getRandomInt(0, 255),
        b = getRandomInt(0, 255),
        color = 'rgb(' + r + ', ' + g + ', ' + b + ')';
    return color;
}

createRandomDivs();