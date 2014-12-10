/// <reference path="libs/require.js" />

define(['jquery'], function ($) {
    'use strict';

    var httpRequest = (function () {
        var getJSON,
            postJSON;

        getJSON = function (resourceUrl, successFunction, headers) {
            $.ajax({
                url: resourceUrl,
                headers: headers,
                type: 'GET',
                contentType: 'json',
                success: successFunction
            });
        };

        postJSON = function (resourceUrl, data, successFunction, headers) {
            $.ajax({
                url: resourceUrl,
                headers: headers,
                type: 'POST',
                data: JSON.stringify(data),
                contentType: 'application/json',
                success: successFunction
            });
        };

        return {
            getJSON: getJSON,
            postJSON: postJSON
        };
    }());

    return httpRequest;
});