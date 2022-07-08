# Info
Simple helper class to generate a mock person object. The object will be created from two `List`'s that are given as argument.

# Usage
`var mockPerson = new MockPerson(List<string>, List<string>);`

or

`var mockPerson = new MockPerson(List<string>, List<string>, DateTime);`

The method overload supports up to three arguments in the constructor:

## Method arguments
| Argument | Function | Type | Required |
| - | - | - | -: |
| Firstname | List to get random name | List<string> | Yes |
| Lastname | List to get random name | List<string> | Yes |
| Birthday | Startdate to get random date between this date and today | DateTime | No |

## Object properties
| Name | Description
| - | -: |
| Firstname | `string` of Firstname |
| Lastname | `string` of Lastname |
| Birthday | `DateTime` of birthday |

# Example 
```c#
  List<string> firstnameList = new List<string>(){ "Mary", "Bob", "Joe", "Barbara", "Tom", "Linda" };
  List<string> lastnameList = new List<string>(){ "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis" };
  
  MockPerson mockPerson = new MockPerson(firstnameList, lastnameList);
  
  Console.WriteLine($"New Person: {person.FirstName} {person.LastName} born {person.Birthday}");
```

# Remarks
If the method is used without a birthday argument the logic will take a date between `1.1.1970` and todays date.
