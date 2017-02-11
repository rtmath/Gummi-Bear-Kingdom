function sidebarToggle(string) {
    $('#' + string + '-content').toggle();
    $('#' + string).toggle();
    $('#' + string + '-active').toggle();
}

$(document).ready(function () {

    $('#sidebar-about-us').click(function () {
        sidebarToggle("sidebar-about-us");
    })
    $('#sidebar-about-us-active').click(function () {
        sidebarToggle("sidebar-about-us");
    })
    $('#mobile-sidebar-about-us').click(function () {
        sidebarToggle("mobile-sidebar-about-us");
    })
    $('#mobile-sidebar-about-us-active').click(function () {
        sidebarToggle("mobile-sidebar-about-us");
    })

    $('#sidebar-contact').click(function () {
        sidebarToggle("sidebar-contact");
    })
    $('#sidebar-contact-active').click(function () {
        sidebarToggle("sidebar-contact");
    })
    $('#mobile-sidebar-contact').click(function () {
        sidebarToggle("mobile-sidebar-contact");
    })
    $('#mobile-sidebar-contact-active').click(function () {
        sidebarToggle("mobile-sidebar-contact");
    })

    $('#sidebar-product').click(function () {
        sidebarToggle("sidebar-product");
    })
    $('#sidebar-product-active').click(function () {
        sidebarToggle("sidebar-product");
    })
    $('#mobile-sidebar-product').click(function () {
        sidebarToggle("mobile-sidebar-product");
    })
    $('#mobile-sidebar-product-active').click(function () {
        sidebarToggle("mobile-sidebar-product");
    })
})