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

4. What is the difference between an object and a class?
	
		classes are templates that specify the data and operations for an entity

		Objects are instances of a class created at runtime using the new
		keyword

5. What is lazy loading and when do you use it?

		- Instantiating objects when they are needed and not before
		- involves creating an instance in the property getter for the related object


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


**Instantiating Related Objects**

	- related object only needed in one method
	- always needed by class (vendor always included w/ product)
	- Sometimes

	One Method - Initialize in the method that needs it
	Always Needed - Define a property || Initialize in constructor
	Sometimes - Define a prop || init in the prop getter || called lazy loading

**Null Checking**

	Object variable is local variable

	Object variable is backing field with a property (priv and then pub)

	private Vendor productVendor;
	public Vendor ProductVendor
	{
		get { return productVendor; }
		set { productVendor = value; }
	}

 	if (whatever == null && whatever2 == null)
	{
		return whatever ? (called Elvis operator)
	}

**If null then null; if not then dot**

	var whatever = currentA?.CurrentB?.Whatever;

## Defining Fields

**Define Fields correctly**

	can be variables or constants (const)
	Holds data for each object 

**Data Encapsulation/Information Hiding**

	Objects data only accessible to that object
	Fields are private
	Accessible outside of the class through property getters/setters

**Backing Fields**

	Optional accessibility modifier (public, private, custom type defined by class etc)
	
	**Accessibility Modifier**	**Data Type** (string int etc)	**Name**

	private string whatever;

**Do's**

	Define meaningful name
	user camelCasing
	Keep fields private
	Use props to provide access to fields

**Don't's**

	Single character name
	Abbreviations
	Initialize to the fields default value
**Nullable Types**

	Allows definition of a value OR null
	Specified with a "?" suffix on the type
	Distinguishes "not set" form the default value

	Do's

	Use simple types to distinguish "not set" and "default value"
	Use properties of the type suck as HasValue and Value as needed

	Do Not's

	Use them if not necessary

**Constants**

	defined in a class
	
	Holds a hard coded value

	Must be assigned to an expression that can be fully evaluated at compile 
	time...ie compile time constant value

	access ability modifier (not private) unlike backing field
	const keyword used

	public const whatever

	Access Modifier - const - Data type - Name

	**Constant BP**
	
	Do:
	
		Class Naming
		Define a meaningful name
		User PascalCasing
		Compile time constants that will never change
	
	Avoid:
	
		Avoid single character
		Avoid using abbreviations
		Avoid using All upper case
		For fields that could change over time
	

**Read-Only Fields**

	Variable defined in a class
	Holds a value that is initialized and then not changes
	
	Must be initialized:

	in the declaration 
	or in the constructor


	public readonly whatever;
	public readonly string Default Whatever = GetWhatever();
	
	public Product()
	{
		Whatever = RetrieveWhatever();
	}

	Optional static keyword (defines readonly belonging to all instances of class)

	Runtime constant value
	
	public 	readonly 	decimal 	MinimumPrice;

	Accessisbilty modifier	readonly keyword	data type	Name

	(Can have assigned value as well)


Do's

- Class naming
- Define a meaningful name
- Use Pascal casing

Do Not's

- Class naming
- Use abbreviations

Constant	

- Compile time
- Assigned to an expression evaluated at compile time
- Assigned on declaration

VS		

Readonly

- Runtime constant 
- Assigned to any valid expression at runtime
- Assigned on declaration or constructor

Data Enscapsulation principle
---

- An object's data should be accessible only to the object
- Backing fields containing the object data should be marked as private


What is a backing field?
---

- a variable in a class used to retain each object's data

When to use a backing field?
---

- for every data field retained for an object

When should you use a constant?
---

- When defining a field with a simple data type that will never change (PI etc)

- When should you used a read-only field?
---

- When defining a field that is initialized from a file, table, or code but should not then be changed anywhere else in the application

What is the difference between a constant and a read-only field?
---

- A constant
	- is static
	- Assigned on declaration 
	- Assigned to an expression that is full evaluated at compile time

- A read-only field
	- can be static or non-static
	- Assigned in the declaration or in a constructor
	- Assigned to any valid expression


---

## Good Properties
---

**Code in the getter**

- Check the user's credentials
- Check application state
- Format the returned value
- Log
- Lazy loading

**Code in setter**

- Check user's credentials
- Check application state
- Validate the incoming value
- Log or change tracking
- Format, convert, clean up

### Properties Best Practices

**Do:**

- Meaningful property name
- Use PascalCasing
- Add code in getter to protect, format, and initialize
- Add code in setter to protect, format, and validate

**Avoid:**

- Avoid single character or abbreviated names
- N/A

---

## Auto-Implemented Properties
---

- Concise property declaration
- Implicit backing field
- Don't allow code in the getter or setter
- Best used for simple properties
- Initialize the property

    	public string Category { get; set; } = "Tools";
    	public int SequenceNumber { get; set; } = 1;
    	public Vendor productVendor { get; set; } = GetDefaultVendor();

### Auto-Property BP
---
**Do:**

- Naming
	- Define a meaningful name
	- Use PascalCasing

- Initialize on declaration when needed


**Avoid:**

- Naming
	- Avoid single characters
	- Avoid abbreviations

- If property requires code in getter or setter

---

## Property Accessibility
---

**Public**

	Grant access to property from anywhere in code

**Protected**

	when working with inheritance and a base class

**Internal**

	only available in the component in which the property is defined
	ie viewmodel and user interface component make them only available to UI classes

**Protected Internal**

	only available in the component and to inherited classes

**Private**

	Only available to the class in which it was prepared


**Getter/Setter**

	Can include property modifiers and they must be more restrictive then
	what's on the prop modifier ie:

	internal string Category { public get; set; }

### General rule of thumb

	Select the most restrictive accessibility that still gets the job done

### Additional Use of Properties

	Define concatenated values (combining first and last names)
	Express calculations (Line item total in a shopping cart)
	Expose related objects properties (vendor company name)

### Expression-bodied Properties

	public string FullName => FirstName + " " + LastName; C# 6.0

### Benefits of Properties

1. Fined grained access control
2. Execute code
3. Set break points or logging
4. Available for data binding (fields must be encapsulated with properties)

### Good Properties FAQ

#### What is the primary purpose of a property?

	to guard access to fields of a class 
	and to optionally provide a location for logic

#### What are auto-implemented properties?

	Short cut syntax for defining an implicit backing field with its assocaited property
	getter and setter.

#### When should you use an auto-implemented property?

	when creating simple properties for a class

#### When shouldn't you use an auto-implemented property?

	If the property requires any code in the getter or setter

---
