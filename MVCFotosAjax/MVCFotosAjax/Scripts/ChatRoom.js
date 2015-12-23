$(function () {
    var chat = $.connection.chatHub;
    chat.client.addMessage = function (name, message) {
        var encodedName = $('<div />').text(name).html();
        var encodedMessage = $('<div />').text(message).html();
        var listItem = '<dt>' + encodedName + ': </dt><dd>' + encodedMessage + '</dd>';
        console.log(listItem);
        $('#discussion').append(listItem);
    };
    $('#chat-message').focus();
    
    $.connection.hub.start().done(function () {
        chat.server.join(photoid).done(function () {
            $('#sendmessage').click(function () {
                chat.server.send(username, photoid, $('#chat-message').val());
                $('#chat-message').val('').focus();
            });
        }) .fail(function (error) {
            console.log('Invocation of start failed. Error: ' + error)
        });
    });

});