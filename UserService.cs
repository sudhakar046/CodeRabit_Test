using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRabbit_Test
{
    public class UserService
    {
        /// <summary>
        /// Illustrates various approaches to comparing a username to the string "admin".
        /// </summary>
        /// <param name="username">The username to evaluate.</param>
        /// <param name="email">The email address associated with the user.</param>
        public void CreateUser(string username, string email)
        {
            //if (string.IsNullOrWhiteSpace(username))
            //    throw new ArgumentException("Username must be provided.", nameof(username));

            //if (string.IsNullOrWhiteSpace(email))
            //    throw new ArgumentException("Email must be provided.", nameof(email));

            //// Rudimentary e-mail sanity-check; replace with full validator if available
            //if (!email.Contains('@'))
            //    throw new FormatException($"Invalid e-mail address: {email}");

            //Console.WriteLine(
            //    $"Creating user {username.Trim().ToUpperInvariant()} with email {email.Trim().ToLowerInvariant()}");

            if (string.Equals(username, "admin", StringComparison.OrdinalIgnoreCase))
            {
                // TODO: handle admin-specific logic here
            }



        }

    }

}
