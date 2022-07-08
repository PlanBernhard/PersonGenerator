using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanB.PersonGenerator;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPersonGenerator()
        {
            List<MockPerson> mockPersonList = new List<MockPerson>();
            SeedData seedData = new SeedData();

            for(int i = 0; i < 100; i++)
            {
                MockPerson mockPerson = new MockPerson(seedData.Firstnames, seedData.Lastnames);
                mockPersonList.Add(mockPerson);
            }

            foreach(var person in mockPersonList)
            {
                Assert.IsTrue(!string.IsNullOrEmpty(person.FirstName));
                Assert.IsTrue(!string.IsNullOrEmpty(person.LastName));
                Debug.WriteLine($"New Person: {person.FirstName} {person.LastName} born {person.Birthday.ToString("dd.MM.yyyy")}");
            }
            Assert.AreNotEqual(mockPersonList.First(), mockPersonList.Last());
        }
    }
}
