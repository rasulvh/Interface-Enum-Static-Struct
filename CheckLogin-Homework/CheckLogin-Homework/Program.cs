using Service;
using System;

namespace CheckLogin_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string role = "SuperAdmin";
            IAccount account = new Account();
            account.Login(role);
        }
    }
}
