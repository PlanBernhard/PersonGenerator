using PersonGenerator.Adapters;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace PlanB.PersonGenerator
{
    public class MockPerson : Model.IMockPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public DateTime birthDate { get => new DateTime(1970, 1, 1); }

        private static Random random = new Random();
        public CryptoServiceRandom cryptoServiceRandom = new CryptoServiceRandom();

        /// <summary>
        /// Get Person with random forename and lastname based on the given list
        /// The random birth date will be between {birthDate} and date today
        /// </summary>
        /// <param name="firstnameList"></param>
        /// <param name="lastnameList"></param>
        public MockPerson(List<string> firstnameList, List<string> lastnameList)
        {
            FirstName = GetRandomString(firstnameList);
            LastName = GetRandomString(lastnameList);
            Birthday = GetRandomDate(birthDate);
        }

        /// <summary>
        /// Get Person with random forename and lastname based on the given list
        /// The random birth date will be between {birthDate} and date today
        /// </summary>
        /// <param name="firstnameList"></param>
        /// <param name="lastnameList"></param>
        public MockPerson(List<string> firstnameList, List<string> lastnameList, bool useCryptoService)
            : this(firstnameList, lastnameList)
        {
            Birthday = GetRandomDate(new DateTime(1970, 1, 1), useCryptoService);
        }

        /// <summary>
        /// Get Person with random forename, lastname and birthdate based on the given list
        /// The random birth date will be between {birthDate} and date today using CryptoService
        /// </summary>
        /// <param name="firstnameList"></param>
        /// <param name="lastnameList"></param>
        /// <param name="startDate"></param>
        public MockPerson(List<string> firstnameList, List<string> lastnameList, DateTime startDate, bool useCryptoService)
            : this(firstnameList, lastnameList)
        {
            Birthday = GetRandomDate(startDate, useCryptoService);
        }


        private DateTime GetRandomDate(DateTime startDate, bool useCryptoService = false)
        {
            int daysBetween = (DateTime.Today - startDate).Days;
            int randomDays;
            if (useCryptoService)
            {
                randomDays = cryptoServiceRandom.Next(daysBetween);
            }
            else
            {
                randomDays = random.Next(daysBetween);
            }
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
