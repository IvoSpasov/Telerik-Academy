/// <reference path="libs/require.js" />

(function () {
    'use strict';

    require.config({
        paths: {
            'jquery': 'libs/jquery-2.1.1.min',
            'http-request': 'http-request'
        }
    });

    require(['http-request'], function (httpRequest) {
        var resourceUrl = 'http://localhost:3000/students',
            student = {
                name: 'Pesho',
                grade: 10
            };

        function print(data) {
            console.log(data);
        }

        httpRequest.postJSON(resourceUrl, student, print);
        httpRequest.getJSON(resourceUrl, print);
    });
}());