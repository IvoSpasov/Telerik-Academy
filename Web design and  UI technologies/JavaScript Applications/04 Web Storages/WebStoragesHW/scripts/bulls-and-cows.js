(function () {
    'use strict';
    if (!Storage.prototype.setObject) {
        Storage.prototype.setObject = function setObject(key, obj) {
            var jsonObj = JSON.stringify(obj);
            this.setItem(key, jsonObj);
        };

    }
    if (!Storage.prototype.getObject) {
        Storage.prototype.getObject = function getObject(key) {
            var jsonObj = this.getItem(key),
                obj = JSON.parse(jsonObj);
            return obj;
        };
    }
}());

(function () {
    'use strict';

    var number,
        BullsAndCows,
        scoreboard,
        guessNumber,
        guessCount,
        tryButton;

    number = (function () {
        function generateRandomDigit(min, max) {
            if (!max) {
                max = min;
                min = 0;
            }
            var digit = Math.floor(Math.random() * (max - min)) + min;
            return digit;
        }

        function generateGuessNumber() {
            // the guess number will be number array
            var NUMBER_LENGTH = 4,
                guessNumber = [],
                usedDigits = [],
                digit,
                isFirstDigit = true;

            while (guessNumber.length < NUMBER_LENGTH) {
                if (isFirstDigit) {
                    digit = generateRandomDigit(1, 9);
                    isFirstDigit = false;
                }
                else {
                    digit = generateRandomDigit(9);
                }

                if (!usedDigits[digit]) {
                    guessNumber.push(digit);
                    usedDigits[digit] = true;
                }
            }

            return guessNumber;
        }

        return {
            generateGuessNumber: generateGuessNumber
        };
    }());

    BullsAndCows = (function () {
        function BullsAndCows() {
            this.bulls = 0;
            this.cows = 0;
            this.bullsGotHit = [];
        }

        BullsAndCows.prototype.countBulls = function (guessNumber, tryNumber) {
            var i;

            for (i = 0; i < guessNumber.length; i += 1) {
                if (guessNumber[i] === parseInt(tryNumber[i], 10)) {
                    this.bulls += 1;
                    this.bullsGotHit[i] = true;
                }
            }

            return this.bulls;
        };

        BullsAndCows.prototype.countCows = function (guessNumber, tryNumber) {
            var i,
                j;

            for (i = 0; i < guessNumber.length; i += 1) {
                if (!this.bullsGotHit[i]) {
                    for (j = 0; j < tryNumber.length; j += 1) {
                        if (guessNumber[i] === parseInt(tryNumber[j], 10)) {
                            this.cows += 1;
                        }
                    }
                }
            }

            return this.cows;
        };

        return BullsAndCows;
    }());

    scoreboard = (function () {
        var scoreboard = {},
            scoreboardShowButton = document.querySelector('#scoreboard #show'),
            scoreboardHideButton = document.querySelector('#scoreboard #hide'),
            scoreBoardClearButton = document.querySelector('#scoreboard #clear'),
            scoreboardInfo = document.getElementById('scoreboard-info');

        function addNameToScoreBoard(name, currentGuessCount) {
            if (!scoreboard[name]) {
                scoreboard[name] = currentGuessCount;
            }
            else if (scoreboard[name] > currentGuessCount) {
                scoreboard[name] = currentGuessCount;
            }

            localStorage.setObject('scoreboard', scoreboard);
        }

        function getScoreboardFromLocalStorage() {
            scoreboard = localStorage.getObject('scoreboard') || {};
        }

        function onHideScoreBoardButtonClick() {
            scoreboardInfo.innerText = '';
        }

        function onShowScoreboardButtonClick() {
            var player;

            // checking if the scoreboard (object) is empty
            if (Object.getOwnPropertyNames(scoreboard).length) {
                scoreboardInfo.innerText = 'High scores:';
                for (player in scoreboard) {
                    scoreboardInfo.innerText += '\nName: ' + player + ' -> Guess count: ' + scoreboard[player];
                }
            }
            else {
                alert('The scoreboard is empty');
            }
        }

        function onClearScoreBoardButtonClick() {
            scoreboard = {};
            localStorage.clear();
            onHideScoreBoardButtonClick();
        }

        scoreboardShowButton.addEventListener('click', onShowScoreboardButtonClick, false);
        scoreboardHideButton.addEventListener('click', onHideScoreBoardButtonClick, false);
        scoreBoardClearButton.addEventListener('click', onClearScoreBoardButtonClick, false);

        return {
            addNameToScoreBoard: addNameToScoreBoard,
            hideScoreBoard: onHideScoreBoardButtonClick,
            getScoreboardFromLocalStorage: getScoreboardFromLocalStorage
        };
    }());

    function onAddNameButtonClick() {
        var nameInputValue = document.getElementById('name-input').value;
        if (nameInputValue) {
            scoreboard.addNameToScoreBoard(nameInputValue, guessCount);
        }
        else {
            alert('Please enter a valid name (not an empty string)');
        }

        playNewGame();
    }

    function setNameInput() {
        var userInputDiv,
            messageDiv,
            nameInput,
            inputLabel,
            addNameButton;

        if (!document.getElementById('name-input')) {
            userInputDiv = document.getElementById('user-input');
            messageDiv = document.createElement('div');
            nameInput = document.createElement('input');
            inputLabel = document.createElement('label');
            addNameButton = document.createElement('button');
            messageDiv.innerText = 'You can enter the scoreboard';
            nameInput.setAttribute('id', 'name-input');
            nameInput.setAttribute('type', 'text');
            inputLabel.setAttribute('for', 'name-input');
            inputLabel.innerText = 'Please enter your name';
            addNameButton.innerText = 'Add name';
            addNameButton.addEventListener('click', onAddNameButtonClick, false);
            userInputDiv.appendChild(messageDiv);
            userInputDiv.appendChild(inputLabel);
            userInputDiv.appendChild(nameInput);
            userInputDiv.appendChild(addNameButton);
        }
    }

    function removeNameInput() {
        if (document.getElementById('user-input')) {
            document.getElementById('user-input').innerHTML = '';
        }
    }

    function onTryButtonClick() {
        var playerTryNumber = document.getElementById('number-entry').value,
            resultDiv = document.getElementById('result'),
            result,
            bullsAndCows,
            currentBullsCount,
            currentCowsCount;

        if (parseInt(playerTryNumber, 10) && playerTryNumber.length === 4) {
            bullsAndCows = new BullsAndCows();
            currentBullsCount = bullsAndCows.countBulls(guessNumber, playerTryNumber);
            currentCowsCount = bullsAndCows.countCows(guessNumber, playerTryNumber);
            guessCount += 1;
            result = 'Bulls: ' + currentBullsCount + '\nCows: ' + currentCowsCount;

            if (bullsAndCows.bulls === 4) {
                result += '\nYou\'ve guessed the number in ' + guessCount + ' attempt(s).';
                setNameInput();
            }
            else {
                removeNameInput();
            }
        }
        else {
            result = 'You must enter a four digit number.';
        }

        resultDiv.innerText = result;
    }

    function removeBullsAndCowsResult() {
        if (document.getElementById('result')) {
            document.getElementById('result').innerText = '';
        }
    }

    function playNewGame() {
        // why do we use new here?
        guessNumber = number.generateGuessNumber();

        // Logs the guess number to the console for developing and debugging purposes.
        console.log('The generated guess number is: ' + guessNumber.join(''));

        // reset the guess count with every new game
        guessCount = 0;
        removeBullsAndCowsResult();
        removeNameInput();
        scoreboard.hideScoreBoard();
    }

    playNewGame();
    scoreboard.getScoreboardFromLocalStorage();
    tryButton = document.querySelector('#wrapper div button');
    tryButton.addEventListener('click', onTryButtonClick, false);
}());