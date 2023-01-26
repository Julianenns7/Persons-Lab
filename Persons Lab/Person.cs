using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Persons_Lab
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColor;
        private int age;
        private bool isWorking;


        public Person(int personId, string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColor = favoriteColor;
            this.age = age;
            this.isWorking = isWorking;
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine(personId + ": " + firstName + " " + lastName + "'s favorite color is: " + favoriteColor);
        }
        
        public void ChangeFavoriteColor()
        {
            favoriteColor = "white";
        }

        public void GetAgeInTenYears()
        {
           Console.WriteLine(firstName + " " + lastName + "'s age in 10 years is: " + (age + 10));
        }

        public override string ToString()
        {
            return "PersonId: " + personId + "\nfirstName: " + firstName + "\nlastName: " + lastName + "\nfavoriteColor: " + favoriteColor + "\nage: " + age + "\nisWorking: " + isWorking;
        }

    }
}
