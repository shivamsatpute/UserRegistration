using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        public static bool passwordValidation(String password)
        {
            String patternPassword = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
            Regex Passregex = new Regex(patternPassword);
            return Passregex.IsMatch(password);
        }
        public static bool PhoneNumberValidation(String Pno)
        {
            String PPattern = @"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}"; 
            Regex Pregex = new Regex(PPattern); 
            return Pregex.IsMatch(Pno);
        }
        public static bool EmailValidation(String email)
        {
            String Epattern = @"^[a-z]+([-+*.]?[0-9a-z])*@[a-z0-9]+\.(\.?[a-z]{2,}){1,2}$";
            Regex eregex = new Regex(Epattern); 
            return eregex.IsMatch(email);

        }
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


            Console.WriteLine("Enter Email:- ");  
            string email = Console.ReadLine();     

            if (EmailValidation(email))   
            {
                Console.WriteLine("Valid Email"); 
            }
            else
            {
                Console.WriteLine("Invalid Email");  
            }

            Console.WriteLine("\nEnter Phone Number :- ");  
            string Pno = Console.ReadLine();     
            if (PhoneNumberValidation(Pno))
            {
                Console.WriteLine("Valid Phone Number");
            }
            else
            {
                Console.WriteLine("Invalid Phone Number");
            }

            Console.WriteLine("Enter the Password:- ");
            String password = Console.ReadLine();

            if (passwordValidation(password))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
    }
}
