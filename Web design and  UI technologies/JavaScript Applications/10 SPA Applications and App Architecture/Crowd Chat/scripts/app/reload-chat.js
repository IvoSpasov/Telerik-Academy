define(['jquery'], function ($) {
    'use strict';
    var reloadChat = function (resourceUrl) {
        return $.ajax({
            url: resourceUrl,
            type: 'GET',
            contentType: 'application/json',
            success: function (data) {
                var chatters = data,
                    chatlist = $('<ul/>').attr("id", "chat-list"),
                    i;
                for (i = 0; i < chatters.length; i += 1) {
                    $('<li />')
                        .append($('<strong/>')
                            .html(chatters[i].by))
                        .append($('<br/>'))
                        .append($('<span/>')
                            .html(chatters[i].text))
                        .appendTo(chatlist);
                }

                $('#chat-div').html(chatlist);
            },
            error: function (error) {
                console.log(error);
            }
        });
    };

    return reloadChat;
});