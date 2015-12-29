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
	Gate keepers, providing access to data

Methods

	Functions contain behaviors and operations for the class
	The operations

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

	Method executed when an instance is created from a class

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

	
- Cannot instantiate a static class use the class name instead

- Use sparingly
- only be used as supporting classes
- don't participate with other OOP programming constructs
- cannot have parameterized constructors
- cannot implement an interface
- can't inherit from a static class
- Avoid using as misc bucket
- Every class should have a purpose


---

### Singleton 

---

- Provides only one instance
- Private Constructors
- static property provides one instance
- Single instance of self

**Advantages**

- has an instance
- Can be passed to the other codes as needed
- Can have child objects
- user interface has a set of roles associated with it
- supports OOP constructs
- can implement an interface
- it can be inherited from

**Disadvantages**

	Static class cannot be instantiated
	Singleton can be instantiate itself and provide that instance

---

###Defining References

---

	Identifies the component containing the class

---

## Accessing Class members
---

**Non-static Class**

	var whatever = new Whatever();
	var blah = blah.HelloWorld();

**Static Class**

	var result = WhateverService.LogAction("");

**Object vs. Class**

	Object - one specific things (Hammer or Saw)
	Class - things of the same type (Product)

	Defines the template specifying the data 
	and processing associated with all things
	of that type

**Object Initialization**

	- setting properties (assign all properties...
	- best used when populating from database values)
	- Parameterized constructor (added the values...
	- setting the basic set of properties)
	- object initializers
	- (readability is important and when initializing a sub or superset of
	- properties)

---

----------
