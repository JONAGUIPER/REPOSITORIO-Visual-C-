$(document).ready()
{
    $('#DDList').change(function () {
        var i = $('#DDList').val();
        $.post('@Url.Action("Index", "Orders",new{id=i})').always(function () {
            $('#target').Load('/Home/UpdatePoints');
        })

    });
}


