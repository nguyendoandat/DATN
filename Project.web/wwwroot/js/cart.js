/*const { type } = require("jquery");*/

var CartController = function () {
    this.initialize = function () {
        loadData();

        registerEvents();
    }

    function registerEvents() {
        $('body').on('click', '.btn-plus', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity_' + id).val()) + 1;
            updateCart(id, quantity);
        });

        $('body').on('click', '.btn-minus', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity_' + id).val()) - 1;
            updateCart(id, quantity);
        });
        $('body').on('click', '.btn-remove', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            updateCart(id, 0);
        });
        $('body').on('click', '#btnCheckout', function (e) {
            e.preventDefault();
            $('#divCheckout').show();
        });
        //$('body').on('click', '#chkUserLoginInfo', function () {

        //    getUser();

        //});

    }
    //function getUser() {
    //    $.ajax({
    //        url: '/Cart/GetUser',
    //        type: 'POST',
    //        dataType: 'json',
    //        success: function (res) {
    //            if (res.status) {
    //                var user = res.data;
    //                $('#txtName').val(user.UserName);
    //                /*$('#txtAddress').val(user.Address);*/
    //                $('#txtEmail').val(user.Email);
    //                $('#txtPhone').val(user.PhoneNumber);
    //            }
    //        }
    //    });
    //}

    function updateCart(id, quantity) {
        $.ajax({
            type: "POST",
            url: '/Cart/UpdateCart',
            data: {
                id: id,
                quantity: quantity
            },
            success: function (res) {
                $('#lbl_number_items_header').text(res.length);
                loadData();
            },
            error: function (err) {
                console.log(err);
            }
        });
    }


    function loadData() {
        $.ajax({
            type: "GET",
            url: '/Cart/GetListItem',
            success: function (res) {
                var html = '';
                var total = 0;

                $.each(res, function (i, item) {
                    var amount = item.price * item.quantity;
                    html += "<tr>"
                        + "<td> <img width=\"60\" src=\"" + "/img/" + item.image + "\" alt=\"\" /></td>"
                        + "<td>" + item.description + "</td>"
                        + "<td><div class=\"input-append\"><input class=\"span1\" style=\"max-width: 48px\" placeholder=\"1\" id=\"txt_quantity_" + item.productId + "\" value=\"" + item.quantity + "\" size=\"36\" type=\"text\">"
                        + "<button class=\"btn btn-minus\" data-id=\"" + item.productId + "\" type =\"button\"> <i class=\"fa-solid fa-minus\"></i></button>"
                        + "<button class=\"btn btn-plus\" type=\"button\" data-id=\"" + item.productId + "\"><i class=\"fa-solid fa-plus\"></i></button>"
                        + "<button class=\"btn btn-danger btn-remove\" type=\"button\" data-id=\"" + item.productId + "\"><i class=\"fa-sharp fa-solid fa-xmark\"></i></button>"
                        + "</div>"
                        + "</td>"

                        + "<td>" + numberWithCommas(item.price) + "</td>"
                        + "<td>" + numberWithCommas(amount) + "</td>"
                        + "</tr>";
                    total += amount;
                });
                $('#cart_body').html(html);
                if (html == '') {
                    $('#cartcontainer').html('Không có sản phẩm nào trong giỏ hàng');
                }
                $('#lbl_number_of_items').text(res.length);
                $('#lbl_total').text(numberWithCommas(total));
            }
        });
    }
}
function numberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}
var cart = {
    init: function () {
        cart.registerEvents();
    },
    registerEvents: function () {
        $('#chkUserLoginInfo').off('click').on('click', function () {
            if ($(this).prop('checked'))
                cart.getLoginUser();
            else {
                $('#txtName').val('');
                $('#txtAddress').val('');
                $('#txtEmail').val('');
                $('#txtPhone').val('');
            }
        });
    },
    getLoginUser: function () {
        $.ajax({
            url: '/Cart/GetUser',
            type: 'POST',
            dataType: 'json',
            success: function (response) {
                if (response.status) {
                    debugger;
                    var user = response.data;
                    $('#txtName').val(user.userName);
                    /*$('#txtAddress').val(user.Address);*/
                    $('#txtEmail').val(user.email);
                    $('#txtPhone').val(user.PhoneNumber);
                }
            }
        });
    },
}
cart.init();