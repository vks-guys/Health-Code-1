function fn_AddToCart(Id) {

    $.getJSON("/Home/CartItem", { Id: Id }, function (data) {

        if (data.IsExist === 0) {
            $('#pc').text(data.Total);
            //alert("Added");
        }
        else {
            alert("Already Added to cart.");
        }

    });
}

function fn_DeleteCartItem(Id, value) {
    debugger;
    //$.getJSON("/Home/CartItemDelete", { Id: Id }, function (data) {

    //    console.log(data);
    //    $('#CartItemDiv').empty();
    //    $('#CartItemDiv').html(data);

    //});

    $.ajax({
        url: '/Home/CartItemDelete',
        contentType: 'application/html; charset=utf-8',
        data: { "Id": Id },
        type: 'GET',
        dataType: 'html',
        success: function (result) {
            $('#CartItemDiv').html(result);
        },
        error: function (xhr, status) {
            alert(status);
        }
    })
}