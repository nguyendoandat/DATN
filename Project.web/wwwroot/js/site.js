// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


var SiteController = function () {
    this.initialize = function () {
        registerEvents();
        loadCart();
    }
    function loadCart() {
        $.ajax({
            type: "GET",
            url: "/Cart/GetListItem",
            success: function (res) {
                $('#lbl_number_of_items_header').text(res.length)
            }
        });
    }
    function registerEvents() {
        // Write your JavaScript code.
        $('body').on('click', '.btn-primary', function (e) {

            e.preventDefault();
            debugger
            const id = $(this).data('id');
            var number = $(this).data('quantity');
            var quantity = $("#tentacles").val();
            if (quantity === undefined) {
                quantity = 1;
            }
            if (number < quantity) {
                Swal.fire({
                    title: 'Thông bá0!',
                    text: "Số lượng sản phẩm không đủ",
                    icon: 'warning',
                    showCancelButton: false,
                    confirmButtonColor: '#3085d6',
                   
                    confirmButtonText: 'OK'
                })
            }
            $.ajax({
                type: "POST",
                url: '/Cart/AddToCart',
                data: { id: id, quantity: quantity },
                success: function (res) {
                    $('#lbl_number_of_items_header').text(res.length)
                },
                error: function (err) {
                    console.log(err)
                }

            });
        })

    }
}

