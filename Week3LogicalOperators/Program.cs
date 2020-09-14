using System;

namespace Week3LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*login form
             *login: admin
             *password: pass1234
             *Create a programm thath asks users login credentials
             *check if the users entered correct login and password
             *if the login and password are correct display "welcome"
             * if the login or password are incorrect display "try again"
             */
            string Login;
            string Password;
            Console.WriteLine("Login: ");
            Login = Console.ReadLine();
            Console.WriteLine("Password: ");
            Password = Console.ReadLine();

            if((Login == "admin") && Password == ("pass1234"))
            {
                Console.WriteLine("Welcome!");
            }else if((Login == "admin") && (Password != "pass1234"))
            {
                Console.WriteLine("The password is inncorrect");
            }else if((Login != "admin") && (Password == "pass1234"))
            {
                Console.WriteLine("The login is inncorect.");
            }else
            {
                Console.WriteLine("You shall not pass!");
            }
        }
    }
}
