// site.js
// Patterns in JavaScript

// Self executing anonymous function

//function startup() {
//    var ele = document.getElementById("username");
//    ele.innerHTML = "Han Solo";

//    var main = document.getElementById("main");
//    main.onmouseenter = function () {
//        main.style = "background-color: #888;";
//    };

//    main.onmouseleave = function () {
//        main.style = "";
//    };
//};

// startup();

// immediately invoked function expression (iife)

//(function () { // (inputParam)
//    var ele = document.getElementById("username");
//    ele.innerHTML = "Han Solo";

//    var main = document.getElementById("main");
//    main.onmouseenter = function () {
//        main.style = "background-color: #888;";
//    };

//    main.onmouseleave = function () {
//        main.style = "";
//    };
//})(); // you can put params in here....("Hello")

// JQuery version

//(function () {
//    var ele = $("#username");
//    ele.text("Han Solo");

//    var main = $("#main");
//    main.on("mouseenter", function () {
//        main.style = "background-color: #888;";
//    });

//    main.on("mouseleave", function () {
//        main.style = "";
//    });

//    var menuItems = $("ul.menu li a");
//    menuItems.on("click", function () {
//        alert("Hello!!!");
//    })
//})();

(function () {
    var $sidebarAndWrapper = $("#sidebar,#wrapper");
    var $icon = $("#sidebarToggle i.fa");

    $("#sidebarToggle").on("click", function () {
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
            $icon.removeClass("fa-angle-left");
            $icon.addClass("fa-angle-right");
        } else {
            $icon.addClass("fa-angle-left");
            $icon.removeClass("fa-angle-right");
        }
    });
})();