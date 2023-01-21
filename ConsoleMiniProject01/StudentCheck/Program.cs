namespace StudentCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your FirstName: ");
            string FirstName = Console.ReadLine();

            Console.Write("What is your LastName: ");
            string LastName = Console.ReadLine();

            Console.Write("How old are you: ");
            string AgeText = Console.ReadLine();

            string formattedFirstName;
            string formattedLastName;

            string formattedfullname = FirstName + LastName;

            if (int.TryParse(AgeText, out int age))
            {
                if (FirstName.ToLower() == "shah" ||
                    FirstName.ToLower() == "Tim")
                {
                   formattedFirstName = $"Hello Mister {FirstName}";
                }
                else
                {
                    formattedFirstName= FirstName;
                }
                if (LastName.ToLower() == "haque" ||
                    LastName.ToLower() == "Corey")
                {
                    formattedLastName = $"That is a nice {LastName}";
                }
                else
                {
                    formattedLastName= LastName;
                }
                if (age < 21)
                {
                    Console.WriteLine($"You should wait {21 - age} years, {formattedfullname}");
                }
                else
                {
                    Console.WriteLine($"Welcome to class {formattedfullname}");
                }
            }
            else
            {
                Console.WriteLine("You Fell off");
            }
        }

        }
    }