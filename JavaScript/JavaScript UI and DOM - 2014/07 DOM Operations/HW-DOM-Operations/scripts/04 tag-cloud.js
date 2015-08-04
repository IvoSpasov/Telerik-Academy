(function () {
    var tags = ["cms", 'cms', "javascript", "js", "ASP.NET MVC", ".net", ".net", "css", "wordpress", "xaml", "js", "http", "web", "asp.net", "asp.net MVC", "ASP.NET MVC", "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS"],
        tagsInHashTable;


    function generateHashTableWithWordsCount(words) {
        var table = {},
            wordLower,
            i;

        for (i = 0; i < words.length; i += 1) {
            wordLower = words[i].toLowerCase();

            if (!table[wordLower]) {
                table[wordLower] = 1;
            }
            else {
                table[wordLower] += 1;
            }
        }

        return table;
    }

    function generateHashTableWithFontSizes(tags, minFontSize, maxFontSize) {
        var maxCount = 0,
            word,
            steps;
        for (word in tags) {
            if (tags[word] > maxCount) {
                maxCount = tags[word];
            }
        }

        steps = (maxFontSize - minFontSize) / (maxCount - 1);

        for (word in tags) {
            tags[word] = ((tags[word] - 1) * steps) + minFontSize;
        }

    }

    function generateTagCloud(tags) {
        var wrapper = document.getElementById('wrapper'),
            divElement,
            dFrag = document.createDocumentFragment(),
            word;

        for (word in tags) {
            divElement = document.createElement('div');
            divElement.innerHTML = word;
            divElement.style.fontSize = tags[word] + 'px';
            dFrag.appendChild(divElement);
        }

        wrapper.appendChild(dFrag);
    }

    tagsInHashTable = generateHashTableWithWordsCount(tags);
    generateHashTableWithFontSizes(tagsInHashTable, 17, 42);
    generateTagCloud(tagsInHashTable);
}());