using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public string Password { get; set;}
        public AccountType accountType { get; set; }
        public string image { get; set; }
        private User() { }

        public class Builder
        {
            private readonly User user;
            public Builder()
            {
                this.user = new User();
            }

            public Builder setFirstName(string firstName)
            {
                user.FirstName = firstName;
                return this;
            }

            public Builder setLastName(string lastName)
            {
                user.LastName = lastName;
                return this;
            }
            public Builder setImage(string image)
            {
                user.image = image;
                return this;
            }

            public Builder setPassword(string password)
            {
                user.Password = password;
                return this;
            }
            public Builder setAccountType(AccountType accountType)
            {
                user.accountType = accountType;
                return this;
            }

            public User Build()
            {
                return user;
            }
        }

    }
}
