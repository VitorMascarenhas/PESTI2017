function loadCategories() {
    alert("Olá");
    $.ajax({
        var ur = "http://localhost:50645/api/categories";
        
        dataType: 'json',
        type: "GET",
        url: url,
        success: showCategories
    });
}

function showCategories(result) {

    $.each(result, function(i, cat) {
        //use obj.id and obj.name here, for example:
        alert(cat.Name);
    });
}
