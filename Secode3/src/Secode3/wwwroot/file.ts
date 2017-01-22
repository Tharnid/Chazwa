class Person {
    firstName: string;
    lastName: string;
    age: number;
    birthDate: Date;

    private _fullName: string;

    showMe(): void {
        var div = document.createElement("div");
        div.innerHTML = JSON.stringify(this);
        document.getElementsByTagName("body")[0].appendChild(div);
    }

    makeFullName(): string {
        this._fullName = '${this.firstName} ${this.lastName}';
        return this._fullName;
    }

    setAge(age: number) {
        this.age = age;
    }

    setAgeAndDate(age: number, birthDate?: Date) {
        this.age = age;
    }

    setNames(lastName: string = "Solo") {

    }

    private _sibling: Person;

    setSibling(sibling: { age: number, lastName: string, firstName: string }) {
        this._sibling = new Person();
        this._sibling.firstName = sibling.firstName;
        this._sibling.lastName = sibling.lastName;
    }

    constructor(lastName = "[Last Name]") {

    }
}

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