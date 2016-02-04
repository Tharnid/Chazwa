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

(function () { // (inputParam)
    var ele = document.getElementById("username");
    ele.innerHTML = "Han Solo";

    var main = document.getElementById("main");
    main.onmouseenter = function () {
        main.style = "background-color: #888;";
    };

    main.onmouseleave = function () {
        main.style = "";
    };
})(); // you can put params in here....("Hello")