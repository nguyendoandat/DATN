
$(document).ready(function () {
    let listCart = new Map();
    let count = 0;
    displayNumberOfCart(count);
    

    $(".add-to-cart").click(function () {
        let id = $(this).data("id");
        //debugger
        if (!listCart.has(id)) {
            listCart.set(id, 1);
            count++;
        }
        else {
            listCart.set(id, listCart.get(id)+1);
        }
        
        displayNumberOfCart(count);

        console.log(listCart);
    })


})

function displayNumberOfCart(count) {
    $("#lbl_number_of_items_header").html(count);
}