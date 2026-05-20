namespace OOP
{
    internal class Program
    {
        //Animal Object...
        class Animal
        {
            private int age, monthNumber;
            private string name, ownerName;

            public Animal(int age, string name, string ownerName, int monthNumber)
            {
                this.age = age;
                this.name = name;
                this.monthNumber = monthNumber;
                this.ownerName = ownerName;
            }

            public string DisplayNewAnimal()
            {
                string petMonth = ReturnMonthInWord(monthNumber);
                return $"Your pet name is {name} she's {age} years old, she's was born on {petMonth} month of the year, and your name is {ownerName}, you own the pet";
            }

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
        }
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Name: ");
                string Name = Console.ReadLine();

                Console.WriteLine("Enter Age: ");
                int Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Month No: ");
                int MonthNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Owner Name: ");
                string OwnerName = Console.ReadLine();

                if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(OwnerName))
                {
                    throw new Exception("Pet Name or Owner Name cannot be Null or Empty...");
                }
                if (Age <= 0 || MonthNo <= 0)
                {
                    throw new Exception("Age or Month cannot be less than 0...");
                }
                if (MonthNo >= 13)
                {
                    throw new Exception("Pet month of birth cannot be greater than 12 month...");
                }

                Animal pet = new Animal(Age, Name, OwnerName, MonthNo);
                Console.WriteLine(pet.DisplayNewAnimal());
                Console.WriteLine(pet.Name = "Hycon45"); // cannot be use on private variables
                //Console.WriteLine($"{pet.name} - {pet.age} - {pet.monthNumber} - {pet.ownerName}");

                //string output = DisplayNewAnimal(name, ownerName, age, monthNo);
                //Console.WriteLine(output);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
            }
            
        }

        //new animal
        //static string DisplayNewAnimal(string name, string ownerName, int age, int monthNo)
        //{
        //    Animal pet = new Animal(age, name, ownerName, monthNo);
        //    string petMonth = ReturnMonthInWord(pet.monthNumber);
        //    return $"Your pet name is {pet.name} she's {pet.age} years old, she's was born on {petMonth} month of the year, and your name is {pet.ownerName}, you own the pet";
        //}

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
