using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRabit_Test
{
    public class UserService
    {
        public void CreateUser(string username, string email)
        {
            // Directly using without null/empty validation
            Console.WriteLine($"Creating user {username.ToUpper()} with email {email.ToLower()}");
        }

    }

}
