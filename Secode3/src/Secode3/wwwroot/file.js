var Person = (function () {
    function Person(lastName) {
        if (lastName === void 0) { lastName = "[Last Name]"; }
    }
    Person.prototype.showMe = function () {
        var div = document.createElement("div");
        div.innerHTML = JSON.stringify(this);
        document.getElementsByTagName("body")[0].appendChild(div);
    };
    Person.prototype.makeFullName = function () {
        this._fullName = '${this.firstName} ${this.lastName}';
        return this._fullName;
    };
    Person.prototype.setAge = function (age) {
        this.age = age;
    };
    Person.prototype.setAgeAndDate = function (age, birthDate) {
        this.age = age;
    };
    Person.prototype.setNames = function (lastName) {
        if (lastName === void 0) { lastName = "Solo"; }
    };
    Person.prototype.setSibling = function (sibling) {
        this._sibling = new Person();
        this._sibling.firstName = sibling.firstName;
        this._sibling.lastName = sibling.lastName;
    };
    return Person;
}());
var p = new Person();
var secondPerson = new Person();
p.firstName = "Corran";
p.lastName = "Horn";
p.age = 23;
p.birthDate = new Date();
//alert(p.makeFullName());
p.setAgeAndDate(23);
p.setAgeAndDate(23, new Date());
p.setNames();
p.setNames("Does");
p.setSibling({ age: 12, lastName: "Fortuna", firstName: "Bib" });
p.showMe();
// alert(JSON.stringify(p)); 
//# sourceMappingURL=file.js.map