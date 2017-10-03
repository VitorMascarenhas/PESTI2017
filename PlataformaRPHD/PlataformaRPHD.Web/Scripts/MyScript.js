function showImpacts() {
    $.ajax({
        dataType: "json",
        type: "GET",
        url: "/DataSource/GetImpacts",
        success: function (data) {
            $(data).each(function (i) {
                $(".impacts").append('<option value="' + data[i].Id + '">' + data[i].Name + '</option>');
            });
        }
    });
}