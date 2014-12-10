define(["jquery", "reloadChat"], function ($, reloadChat) {
    'use strict';
    var sendMessage = function (resourceUrl, data) {
        return $.ajax({
            url: resourceUrl,
            type: 'POST',
            data: JSON.stringify(data),
            contentType: 'application/json',
            success: function (data) {
                reloadChat(resourceUrl);
                $('#tb-send').val('');
            },
            error: function (error) {
                console.log(error);
            }
        });
    };

    return sendMessage;
});