using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HomeTasks
{
    internal class Account
    {
        public void Login(string username, string password)
        {
            if (username == "Cavid123" && password == "Cavid1993")
            {
                //Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login succsessfuly");
            }
            else
            {
                Console.WriteLine("Email or password wrong");
            }
        }
    }
}
