# Design Patterns Project

## 🌟 Introduction
Welcome to the **Design Patterns Project**! This project is a comprehensive guide and learning resource for various design patterns used in software development. Design patterns are proven solutions to common problems in software design. They are like blueprints that can be customized to solve particular design problems in your code.

## 📚 Table of Contents
- [Introduction](#-introduction)
- [Installation](#-installation)
- [Design Patterns](#-design-patterns)
  - [Creational Patterns](#-creational-patterns)
  - [Structural Patterns](#--structural-patterns)
  - [Behavioral Patterns](#-behavioral-patterns)
- [References](#-References)

## 🛠 Installation

To get started with the Design Patterns project, follow these steps to clone the repository and install the necessary dependencies.

### Prerequisites

Ensure you have the following prerequisites installed on your machine:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later.
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio 2022 Version 17.9](https://visualstudio.microsoft.com/vs/whatsnew/) or later.

### Steps

1. **Clone the Repository**

    ```bash
    git clone https://github.com/nahimaroun/Nova4ApiTraining.git
    ```

2. **Navigate to the Project Directory**

    ```bash
    cd Nova4ApiTraining/DP_Training/DesignPatternsTraining
    ```

3. **Install Dependencies**

    If there are any dependencies, ensure they are installed. Typically, dependencies for C# projects are managed via NuGet. Open the project in Visual Studio and restore the NuGet packages.

    ```bash
    dotnet restore
    ```

4. **Build the Project**

    Build the solution to ensure all projects compile correctly.

    ```bash
    dotnet build
    ```

5. **Run the Examples**

    All examples are implemented as Class Libraries. To run them:

    - Open `MainConsoleApp` in Visual Studio.
    - Set `MainConsoleApp` as the startup project.
    - Run the `Program.cs` file

**And if you find these steps complicated, there is a simpler way**

1. **Open visual studio**
 
   On the welcome screen press on clone a Respository
   
 ![Image1](https://github.com/nahimaroun/DesignPatternsTraining/assets/127951295/4169f501-bcad-4948-b7a7-f3299a429216)


2.**Paste the repository link**

   Paste the link in Visual studip and give the project a valid path 
   
   ![Image2](https://github.com/nahimaroun/DesignPatternsTraining/assets/127951295/5d284adc-ae79-4147-a6f6-73f80d4b59dd)


3. **You will still need to install Dependencies**

If there are any dependencies, ensure they are installed. Typically, dependencies for C# projects are managed via NuGet. Open the project in Visual Studio and restore the NuGet packages.

4.**Run the Examples**

 All examples are implemented as Class Libraries.Torun them:

 - Open `MainConsoleApp` in Visual Studio.
 - Set `MainConsoleApp` as the startup project.
 - Run the `Program.cs` file
    
### Notes

- The examples are written in a C# Console Application.
- Ensure your Visual Studio is updated to the latest version to avoid any compatibility issues.
- If you encounter any issues, check the .NET version and make sure it's correctly installed.


## 🧩 Design Patterns
**This project covers the following design patterns:**
- Creational Design Patterns
- Structural Design Patterns
- Behavioral Design Patterns

I have made 5 detailed examples about each category of Design Patterns, you can run them and check out the code to learn about these design patterns and how they're implemented. These examples are very basic examples and no one would use them for such basic tasks, but our goal here is to learn not complicate our lives.

**Here's a brief explanation of the code inside the "MainConsoleApp":**

The program starts by defining a dictionary of design pattern categories, each containing a list of DLL files corresponding to different design pattern examples. The main loop presents the user with options to select a category or exit the program. Upon selecting a category, the user is shown a list of examples within that category. When an example is selected, the program uses reflection to dynamically load the corresponding assembly (DLL file) and invoke its Main method, running the example. If the user chooses to exit, the program terminates. This approach allows for flexible execution of various design pattern examples without hardcoding each example into the main program.


## ○ Creational Patterns:

Creational patterns deal with object creation mechanisms, aiming to create objects in a manner suitable to the situation. These patterns provide various ways to instantiate objects, which increase the flexibility and reuse of existing code.

____________________________
● **Singleton Design Pattern:**

The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance. This is useful when exactly one object is needed to coordinate actions across the system.

![singleton-comic-1-en](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/8d34bd67-4780-445e-a695-d0890ca97512)

*Project-Reference: SingletonDesignPattern.dll*
_________________
● **Factory Method:**

The Factory Method pattern defines an interface for creating an object but lets subclasses alter the type of objects that will be created. This pattern promotes loose coupling by eliminating the need to bind application-specific classes into the code.

![factory-method-en](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/cbdce3b7-454c-4bb8-b1a4-68e99d327f5c)

*Project-Reference: FactoryDesignPattern.dll*
___________________
● **Abstract Factory:**

The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes. It involves a super-factory which creates other factories, also known as a factory of factories.

![abstract-factory-en](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/cc7c08a3-61e4-403a-ae96-ef4a8c215e47)

*Project-Reference: AbstractFactoryTraining.dll*
____________________________
● **Prototype Design Pattern:**

The Prototype pattern specifies the kinds of objects to create using a prototypical instance, and creates new objects by copying this prototype. This is useful when the cost of creating a new object is expensive or complicated.

![prototype](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/69a1c567-599b-4775-8867-d5e4fa03672e)

*Project-Reference: PrototypeDesignPattern.dll*
__________________________
● **Builder Design Pattern:**

The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations. This pattern is useful when creating complex objects step by step.

![builder-en](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/398de502-e0e8-42c5-82cd-11779900b726)

*Project-Reference: BuilderDesignPattern.dll*




## ○  Structural Patterns:

Structural patterns concern class and object composition. They use inheritance to compose interfaces and define ways to compose objects to obtain new functionalities.

____________________________
● **Adapter Design Pattern:**

The Adapter pattern converts the interface of a class into another interface clients expect. This allows classes with incompatible interfaces to work together.

![adapter-en](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/44c843e4-02b0-43cd-a8e6-d6e9e2741e3d)

*Project-Reference: AdapterDesignPattern.dll*
____________________________
● **Bridge Design Pattern:**

The Bridge pattern decouples an abstraction from its implementation so that the two can vary independently. This is useful when both the class and what it does vary often.

![bridge](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/af393d94-6479-4d48-a98c-448b23f62508)

*Project-Reference: BridgeDesignPattern.dll*
____________________________
● **Composite Design Pattern:**

The Composite pattern composes objects into tree structures to represent part-whole hierarchies. It lets clients treat individual objects and compositions of objects uniformly.

![composite](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/d59522cc-16e7-4e7a-9b14-ce313f0465aa)

*Project-Reference: CompositeDesignPattern.dll*
____________________________
● **Decorator Design Pattern:**

The Decorator pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

![decorator](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/47f0dc59-4a61-4ea6-8c0e-41b02e4d08f0)

*Project-Reference: DecoratorDesignPattern.dll*
____________________________
● **Facade Design Pattern:**

The Facade pattern provides a unified interface to a set of interfaces in a subsystem. It defines a higher-level interface that makes the subsystem easier to use.

![facade](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/d8e80864-14c7-4e6a-9375-569b3165273b)

*Project-Reference: FacadeDesignPattern.dll*




## ○ Behavioral Patterns:

Behavioral patterns are concerned with algorithms and the assignment of responsibilities between objects. These patterns help define how objects interact and communicate with each other.

_________________________________________
● **Chain of Responsibility Design Pattern:**

The Chain of Responsibility pattern lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.

![chain-of-responsibility](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/dedf8e05-030b-4429-82e6-2215aaf93cbc)

*Project-Reference: CORDesignPattern.dll*
____________________________
● **Command Design Pattern:**

The Command pattern encapsulates a request as an object, thereby allowing you to parameterize clients with different requests, queue or log requests, and support undoable operations.

![command-en](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/a0fb42bb-31c1-4d48-a894-716cfb9a01d0)

*Project-Reference: CommandDesignPattern.dll*
____________________________
● **Iterator Design Pattern:**

Iterator is a behavioral design pattern that lets you traverse elements of a collection without exposing its underlying representation (list, stack, tree, etc.).

![iterator-en](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/db4a2bc6-12fb-4c81-8f02-fdbd0b6c683a)

*Project-Reference: IteratorDesignPattern.dll*
____________________________
● **Observer Design Pattern:**

The Observer pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. This is often used in implementing distributed event-handling systems.

![observer](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/0ed928da-80c5-4181-9966-b66e468b0c61)

*Project-Reference: ObserverDesignPattern.dll*
__________________________________
● **Template Method Design Pattern:**

The Template Method pattern defines the skeleton of an algorithm in an operation, deferring some steps to subclasses. It lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.

![template-method](https://github.com/nahimaroun/Nova4ApiTraining/assets/127951295/25f55e79-99bf-4781-9143-f839d3a8aa5d)

*Project-Reference: TemplateMethodDesignPattern.dll*

## 📚 References
This project was inspired by and utilizes concepts from the following resources:

Information And Images:

- [Refactoring Guru]( https://refactoring.guru/design-patterns/)


Examples are from:

- [C# Corner](https://www.c-sharpcorner.com/)
                   
- [Dot Net Tutorials](https://dotnettutorials.net/)

- [Refactoring Guru]( https://refactoring.guru/design-patterns/)
