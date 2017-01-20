class Person {
    firstName: string;
    lastName: string;
    age: number;
    birthDate: Date 

    showMe(): void {
        var div = document.createElement("div");
        div.innerHTML = JSON.stringify(this);
        document.getElementsByTagName("body")[0].appendChild(div);
    }
}

var p = new Person();

p.firstName = "Corran";
p.lastName = "Horn";
p.age = 23;
p.birthDate = new Date();

p.showMe();

// alert(JSON.stringify(p));