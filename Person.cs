using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class Person
    {
        public string Name { get; set; }
        private int age;
        public int Month { get; set; } 
        public string PhoneNumber { get; set; } 
        public string Username { get; set; } 
        public string Password { get; set; } 
        public int MatricNumber { get; set; } 
        public string Department { get; set; }
        public int Age{
            get { return age; }
            //set { age = value > 0 ? value : 0; }
            set {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }
        public bool IsAdult{
            get { return Age >= 18; }
        }

        public string DisplayInfo()
        {
            string monthInWord = ReturnMonthInWord(Month);
            return $"Name: {Name} \n" +
                $"Age: {Age} \n" +
                $"Month: {monthInWord} \n" +
                $"Matric Number: {MatricNumber} \n" +
                $"You're an adult: {IsAdult} \n";
        }

        static string ReturnMonthInWord(int monthNo)
        {
            string month = "";
            switch (monthNo)
            {
                case 1:
                    month = "January";
                    break;
                case 2:
                    month = "Febuary";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "December";
                    break;
                //case var m when m <= 0 :
                //    month = "Can't be less than 0";
                //    break;
                default:
                    month = "Invalid...";
                    break;
            }

            return month;
        }

    }


}
