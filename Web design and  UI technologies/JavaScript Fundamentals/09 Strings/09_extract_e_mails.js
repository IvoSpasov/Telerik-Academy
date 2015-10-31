// Write a function for extracting all email addresses from given text.
// All sub-strings that match the format @… should be recognized as emails.
// Return the emails as array of strings.

(function () {
    'use strict';
    function substringCount(string, substring) {
        string = string.toLowerCase();
        substring = substring.toLowerCase();
        var counter = 0,
            index = string.indexOf(substring);
        while (index !== -1) {
            counter += 1;
            index = string.indexOf(substring, index + substring.length);
        }

        return counter;
    }

    function checkIfValid(email) {
        var isValid = true,
            indexOfMonkey = email.indexOf('@'),
            afterMonkey,
            dotCount;

        if (indexOfMonkey === 0) {
            isValid = false;
        }

        afterMonkey = email.substring(indexOfMonkey + 1);
        dotCount = substringCount(afterMonkey, '.');

        if (dotCount === 0) {
            isValid = false;
        }

        return isValid;
    }

    function extractValidEmails(text) {
        var indexOfMonkey = 0,
            emailAddress,
            lastChar,
            listOfForbiddenChars = ['.', ',', '!', '?'],
            emails = [],
            i;

        do {
            indexOfMonkey = text.indexOf('@', indexOfMonkey + 1);
            emailAddress = text.substring(text.lastIndexOf(' ', indexOfMonkey), text.indexOf(' ', indexOfMonkey)).trim();
            lastChar = emailAddress[emailAddress.length - 1];

            for (i = 0; i < listOfForbiddenChars.length; i += 1) {
                if (lastChar === listOfForbiddenChars[i]) {
                    emailAddress = emailAddress.substring(0, emailAddress.length - 1);
                    break;
                }
            }

            if (checkIfValid(emailAddress)) {
                emails.push(emailAddress);
            }
        } while (indexOfMonkey !== -1);

        return emails;
    }

    var text = 'Please contact us by phone (+001 222 222 222) or by email at example@gmail.com. or ' +
            'at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. ',
        emails = extractValidEmails(text);
    console.log(emails);
})();