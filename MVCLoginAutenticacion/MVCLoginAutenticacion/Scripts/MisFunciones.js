$(document).ready(function () {
    $('#DDList').change(function () {
        var i = $('#DDList').val();
        //$.post('@Url.Action("Index", "Orders",new{id=i})').always(function () {
            $("#target").load('@(Url.Action("Index","Orders",null, Request.Url.Scheme))id=' + i);
        //})

    });
});



