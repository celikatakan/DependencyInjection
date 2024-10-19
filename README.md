# Dependency Injection Practice

This project demonstrates the use of Dependency Injection (DI) in C# by implementing a `Teacher` and `ClassRoom` class. The goal is to reduce dependencies between classes, making the design more flexible and modular.

## Classes

### 1. `Teacher` Class
- **Properties:**
  - `FirstName` : `string` - Stores the first name of the teacher.
  - `LastName` : `string` - Stores the last name of the teacher.

- **Methods:**
  - `GetInfo()` : Returns the full name of the teacher.

### 2. `ClassRoom` Class
- **Properties:**
  - `Teacher` : An instance of the `Teacher` class.
  
- **Methods:**
  - `GetTeacherInfo()` : Returns the information of the assigned teacher by calling the `GetInfo()` method of the `Teacher` class.

## Features

1. **Dependency Injection:** 
   - The `ClassRoom` constructor takes an instance of the `Teacher` class as a parameter. This allows the dependency of `Teacher` to be injected rather than directly instantiated within the class, adhering to best practices for loose coupling and easy testing.
   
2. **Interfaces:**
   - The `Teacher` class is designed to implement an interface `ITeacher`, which defines the contract for retrieving teacher information. This promotes abstraction and flexibility.

## Example Usage

1. The `ClassRoom` object is created by injecting a `Teacher` instance into its constructor.
2. The `GetTeacherInfo()` method is called to display the teacher's details.

```csharp
public interface ITeacher
{
    string GetInfo();
}

public class Teacher : ITeacher
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Teacher(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string GetInfo()
    {
        return $"{FirstName} {LastName}";
    }
}

public class ClassRoom
{
    private readonly ITeacher _teacher;

    public ClassRoom(ITeacher teacher)
    {
        _teacher = teacher;
    }

    public string GetTeacherInfo()
    {
        return _teacher.GetInfo();
    }
}

