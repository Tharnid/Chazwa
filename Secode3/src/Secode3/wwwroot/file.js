var Person = (function () {
    function Person() {
    }
    Person.prototype.showMe = function () {
        var div = document.createElement("div");
        div.innerHTML = JSON.stringify(this);
        document.getElementsByTagName("body")[0].appendChild(div);
    };
    return Person;
}());
var p = new Person();
p.firstName = "Corran";
p.lastName = "Horn";
p.age = 23;
p.birthDate = new Date();
p.showMe();
// alert(JSON.stringify(p)); 
//# sourceMappingURL=file.js.map