using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class Account : IAccount
    {
        public void Login(string role)
        {
            Console.WriteLine("Email daxil edin:");
            string email = Console.ReadLine();
            Console.WriteLine("Password daxil edin:");
            string password = Console.ReadLine();

            Check(role, email, password);
        }

        public void Check(string role, string userEmail, string userPassword)
        {
            if (role == "SuperAdmin" && userEmail == "test@code.edu.az" && userPassword == "test12345")
            {
                Console.WriteLine("Girish ugurludur");
                return;
            }
            else if (role == "SuperAdmin")
            {
                Console.WriteLine("Email ve ya password sehvdir");
                return;
            }
            Console.WriteLine("Bu sehifeye girish etmeye seviyyeniz catmir");
        }
    }
}
