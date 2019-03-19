using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodacyDemoClassLibrary
{
    public class Patient
    {
        private string lastName;
        private string firstName;
        public DateTime dateOfBirth;

        public Patient(string _lastName, string _firstname, DateTime _DateOfBirth)
        {
            this.lastName = _lastName;
            this.firstName = _firstname;
            this.dateOfBirth = _DateOfBirth;
        }

        public string getFullName()
        {
            return $"{this.firstName} {this.lastName}";
        }

        public int getPatientAge()
        {
            return DateTime.Today.Year - dateOfBirth.Year;
        }

        public string PrintSomethingBasedOnAge()
        {
            string output = string.Empty;
            if (getPatientAge() < 18)
            {
                return "Patient is a minor";
            }
            else if (getPatientAge() >= 18)
            {
                return "Patient is an adult";
            }
            return output;
        }

        public string ThisMethodIsNotUsed()
        {
            return "Nope, it sure isn't!";
        }

        public int DoAnotherUnnecessaryCalculation(int input)
        {
            if (input > 3)
            {
                input = input * 3;
            }

            if (input < 20)
            {
                input = input + 20;
            }
            else
            {
                input = 20;
            }

            return input;
        }
    }
}
