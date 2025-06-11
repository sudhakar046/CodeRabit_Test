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
            if (username == null)
                throw new ArgumentNullException(nameof(username));

            // Email is not checked
            Console.WriteLine($"Creating user {username} with email {email}");
        }

    }

}
