# DesignPatterns

A collection of classic design pattern implementations in C# .NET, organized by category to serve as a learning resource and reference for developers.

## Repository Structure

```
DesignPatterns.sln
├── DesignPatterns
│   ├── Creational
│   │   ├── FactoryMethodDesignPatern
│   │   ├── FactoryMethodDesignPaternDI
│   │   └── SingletonDesignPattern
│   └── Visual Studio 2022/Visualizers
└── .gitignore
```

## Creational Patterns

### Factory Method
Defines an interface for creating objects, but lets subclasses decide which class to instantiate.
- **FactoryMethodDesignPatern**: Console app showing the basic Factory Method pattern.  
- **FactoryMethodDesignPaternDI**: Extends the basic example by integrating with the Microsoft DI container.  

### Singleton
Ensures a class has only one instance and provides a global point of access to it.
- **SingletonDesignPattern**: C# implementation of the Singleton pattern with thread-safe initialization.  





