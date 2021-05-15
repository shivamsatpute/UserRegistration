using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        public static bool NameValidation(String firstName)
        {
            String pattern = "^[A-Z]{1,}[a-z]{2,}$";  

            Regex regex = new Regex(pattern);      
            return regex.IsMatch(firstName);    
        }
        static void Main(string[] args)  
        {
            Console.WriteLine("Welcome to User Registration");       

            Console.WriteLine("Enter the First Name");  
            String firstName = Console.ReadLine();     

            if (NameValidation(firstName))  
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }


            Console.WriteLine("\nEnter the Last Name"); 
            String lastName = Console.ReadLine();             

            if (NameValidation(lastName))            
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }
        }
    }
}
