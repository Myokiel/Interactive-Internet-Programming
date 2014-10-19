var Home = {}
Home.ButtonClick = function ()
{
    $.get("Home/GetMissionCountdownResponse", function (rawResponseEndMessage, status)
    {
        alert(rawResponseEndMessage);

        var deserializedData = JSON.parse(rawResponseEndMessage);

        var count = deserializedData.EndMessage;

        for (var i = 0; i < count.length; i++)
        {
            alert(count[i].Timer);
            alert(count[i].Destruct);
        }

    });

}

    $(document).ready(function ()
    {

        $(".button").click(Home.ButtonClick);

    });