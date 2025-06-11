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
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username must be provided.", nameof(username));

            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email must be provided.", nameof(email));

            // Rudimentary e-mail sanity-check; replace with full validator if available
            if (!email.Contains('@'))
                throw new FormatException($"Invalid e-mail address: {email}");

            Console.WriteLine(
                $"Creating user {username.Trim().ToUpperInvariant()} with email {email.Trim().ToLowerInvariant()}");
        }

    }

}
