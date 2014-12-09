// 07 Write a script that parses an URL address given in the format: [protocol]://[server]/[resource]
// and extracts from it the [protocol], [server] and [resource] elements. Return the elements in a JSON object.

function solve() {
    'use strict';

    function urlExtraction(url) {
        var protocol = 'not available',
            server = 'not available',
            resource = 'not available',
            protocolEnd = url.indexOf('://'),
            serverStart = 0,
            serverEnd;

        if (protocolEnd !== -1) {
            protocol = url.substring(0, protocolEnd);
            serverStart = protocolEnd + 3;
        }

        serverEnd = url.indexOf('/', serverStart);

        if (serverEnd !== -1) {
            resource = url.substring(serverEnd);
        }
        else {
            serverEnd = url.length;
        }

        server = url.substring(serverStart, serverEnd);

        return {
            protocol: protocol,
            server: server,
            resource: resource,
            toString: function () {
                return 'Protocol: ' + this.protocol + '\n' +
                       'Server: ' + this.server + '\n' +
                       'Resource: ' + this.resource;
            }
        };
    }

    var address = "http://www.devbg.org/forum/index.php ",
        address2 = "https://www.facebook.com/photo.php?fbid=509933499119386&set=a.411649345614469.1073741849.394475013998569&type=1&theater",
        address3 = "en.wikipedia.org/wiki/List_of_Unicode_characters",
        address4 = "en.wikipedia.org",
        extractedAddress = urlExtraction(address);
    console.log(address);
    console.log(extractedAddress.toString());
    console.log('');
    extractedAddress = urlExtraction(address2);
    console.log(address2);
    console.log(extractedAddress.toString());
    console.log('');
    extractedAddress = urlExtraction(address3);
    console.log(address3);
    console.log(extractedAddress.toString());
    console.log('');
    extractedAddress = urlExtraction(address4);
    console.log(address4);
    console.log(extractedAddress.toString());
}

solve();