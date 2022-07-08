using System;
using System.Collections.Generic;

namespace PlanB.PersonGenerator
{
    public class MockPerson : Model.IMockPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        private static Random random = new Random();

        public MockPerson(List<string> firstnameList, List<string> lastnameList)
        {
            FirstName = GetRandomString(firstnameList);
            LastName = GetRandomString(lastnameList);
            Birthday = GetRandomDate(new DateTime(1970, 1, 1));
        }

        public MockPerson(List<string> firstnameList, List<string> lastnameList, DateTime startDate)
            :base()
        {
            Birthday = GetRandomDate(startDate);
        }


        private DateTime GetRandomDate(DateTime startDate)
        {
            // Todo: Add true randomness
            // RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            int daysBetween = (DateTime.Today - startDate).Days;
            var randomDays = random.Next(daysBetween);
            return startDate.AddDays(randomDays);
        }

        private static string GetRandomString(List<string> list)
        {
            if (list == null) return string.Empty;

            var index = random.Next(list.Count);
            var valueToReturn = list[index];

            return valueToReturn;
        }
    }
}
