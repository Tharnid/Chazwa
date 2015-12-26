# C# Studies #

----------
----------
- **Instance methods** have a value as their receiver
- **Static method**s have a type
- **Strings** are not mutated by methods; a new value is produced

12/31 BegCsharp
0/30 Intermediate CSharp
0/57 Design Patterns

dnvm use -r coreclr -arch x86 1.0.0-beta5-11682

class default Accessibility modifier is:

    internal

Field

	A variable in the class (holds data values)

Properties

	Getter and Setter functions
	Guard access to the fields

Methods

	Functions contain behaviors and operations for the class

1. Why is a layered architecture important?

    	Logical components are easier to create, change, extend and maintain
    	code is easier to reuse

2. What is a class?

		A template for the objects created at runtime
		It specifies the data and operations for each entity

	

3. What are the benefits of unit testing?

    	Higher quality code, faster and easier debugging, and they are repeatable over the life of the application

# Object Oriented Programming
---

**Definition**  

    Programming paradigm based on the concept of objects

**What is it good for?**

**Abstraction**

	the process of providing only essential information to the the outside world and hiding overall background details

**OOP Design technique**

**Encapsulation**

    Information Hiding

**Inheritance**

	allows us to create a new class using an existing one...extending one class to another

**Composition**

    Complex objects are composed of simpler objects, which in turn are composed of even simpler objects

**Polymorphism**

	means having many forms ie method overloading (method with same name different signature/parameters in the same or differenct class) and operator over loading

**SRP**

    The Single Responsibility Principle
    A class should have one, and only one, reason to change.

**Constructors**

	are special methods used when instantiating a class

	Consider providing a default constructor

	Consider providing a parameterized construtor

	Initialize the minimum properties for a valid object

	Name the parameters the same name as the related properties

**Destructors**

	method called once an object is disposed, can be used to cleanup resources


**Namespace Best Practices**

	<company>.<technology>.<feature>
	TharnApp.Wpf.Pm
	Microsoft.Office.Interop.PowerPoint

	Use PascalCasing

	Avoid

	Using the a classname
	Using System namespaces

###Static Class
---

	static keyword in the signature
	Only static members

---

---

----------
