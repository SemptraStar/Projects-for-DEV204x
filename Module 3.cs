using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3
{
    class Program
    {

        static void Main(string[] args)
        {
            GetStudentInformation();
            PrintStudentInformarion("Alex", "Last", "Address1", "Address2",
                                    "New York", "Some State", "USA", 880024);
            try
            {
                SetBirthdate();
            }
             catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }
        }
         
        static void GetStudentInformation ()
        {    
            Console.Write("Enter the student's first name: ");
            string studentsFirstName;
            UserInput(out studentsFirstName);

            Console.Write("Enter the student's second name: ");
            string studentsSecondName;
            UserInput(out studentsSecondName);

            Console.Write("Enter the student's address line 1: ");
            string studentsAddressLine1 = Console.ReadLine();

            Console.Write("Enter the student's address line 2: ");
            string studentsAddressLine2 = Console.ReadLine();

            Console.Write("Enter the student's city: ");
            string studentsCity;
            UserInput(out studentsCity);

            Console.Write("Enter the student's state / province: ");
            string studentsStateOrProvince;
            UserInput(out studentsStateOrProvince);

            Console.Write("Enter the student's country: ");
            string studentsCountry;
            UserInput(out studentsCountry);

            Console.Write("Enter the student's zip / postal: ");
            int studentsZipOrPostal;
            UserInput(out studentsZipOrPostal);

            Console.WriteLine("First name, zip: {0}, {1}", studentsFirstName, studentsZipOrPostal);
        }
        static void PrintStudentInformarion (string firstName, string secondName, string addressLine1,
                                             string addressLine2, string city, string stateOrProvince,
                                             string country, int zipOrPostal)
        {
            Console.Clear();
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Second name: " + secondName);
            Console.WriteLine("Address line 1: " + addressLine1);
            Console.WriteLine("Address line 2: " + addressLine2);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State / Province: " + stateOrProvince);
            Console.WriteLine("Country: " + country);
            Console.WriteLine("Zip / Postar: " + zipOrPostal);
            Console.WriteLine("Press any button...");
            Console.ReadLine();
        }
        static void UserInput (out string input)
        {
            string temp = null;

             do
             {
                temp = Console.ReadLine();
             } while (!IsAllChars(temp) || String.IsNullOrWhiteSpace(temp));

            input = temp;
        }
        static void UserInput (out int input)
        {
            string temp = null;

            for (;;) { 
                temp = Console.ReadLine();
                if (!Int32.TryParse(temp, out input))
                    Console.WriteLine("Only digits available.");
                else break;
            }

            input = Int32.Parse(temp);
        }
        static bool IsAllChars (string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsLetter(s[i]))
                {
                    Console.WriteLine("Only English letters is available. {0} is not a letter.", s[i]);
                    return false;
                }
            }

            return true;
        }
        static DateTime SetBirthdate ()
        {
            throw new NotImplementedException();
        }
    }
}
