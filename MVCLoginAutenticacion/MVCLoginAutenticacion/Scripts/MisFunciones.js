$(document).ready(function () {
    $('#DDList').change(function () {
        var i = $('#DDList').val();
        $.ajax({
            url: "/Orders/Index",
            type: "GET",
            data: { id: i }
        })
            .done(function (partialViewResult) {
                $("#target").html(partialViewResult);
            });

    });
});



