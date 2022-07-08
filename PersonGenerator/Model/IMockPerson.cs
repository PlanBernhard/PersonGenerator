using System;
using System.Collections.Generic;

namespace PlanB.PersonGenerator.Model
{
    internal interface IMockPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime Birthday { get; set; }
    }
}
