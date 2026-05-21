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

        public static string DisplayInfo()
        {
            return "Hello Hycon";
        }

    }


}
