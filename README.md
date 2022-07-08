# Info
Simple helper class to generate a mock person object. The object will be created from two `List`'s that are given as argument.

# Usage
`var mockPerson = new MockPerson(List<string>, List<string>);`

The method overload supports up to three arguments in the constructor:

## Method arguments
| Argument | Function | Type | Required |
| - | - | - | -: |
| Firstname | List to get random name | List<string> | Yes |
| Lastname | List to get random name | List<string> | Yes |
| Birthday | Startdate to get random date between today | DateTime | No |

## Object properties
| Name | Description
| - | -: |
| Firstname | `string` of Firstname |
| Lastname | `string` of Lastname |
| Birthday | `DateTime` of birthday |

# Example
`MockPerson mockPerson = new MockPerson(firstnameList, lastnameList);`

#Remarks
If the method is used without the Birthday the start-date will be "1.1.1970".
