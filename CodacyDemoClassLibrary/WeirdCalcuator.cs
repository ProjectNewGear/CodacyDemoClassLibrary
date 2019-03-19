using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodacyDemoClassLibrary
{
    public class WeirdCalcuator
    {
        public int DoSomeUnnecessaryCalculation(int input)
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

        

        public string HowOftenDoesPatientVisit(int numberOfVisits)
        {
            //string thisIsBad = "We should not have commented out code in our files";

            string returnValue = string.Empty;
            switch(numberOfVisits)
            {
                case 0:
                    {
                        returnValue = "This is a new patient";
                        break;
                    }
                case 1:
                    {
                        returnValue = "This patient has been here once";
                        break;
                    }
                case 2:
                    {
                        returnValue = "This patient has been here more than once";
                        break;
                    }
                case 3:
                    {
                        returnValue = "This patient has been here than once";
                        break;
                    }
                default:
                    {
                        returnValue = "This patient visits here a lot";
                        break;
                    }                   
            }
            return returnValue;
        }
    }
}
