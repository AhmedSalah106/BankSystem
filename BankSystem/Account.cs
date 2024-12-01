using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Account
    {
        public int ID { get; set; }

        public int TotalAmount { get; set; }

        public string photo { get; set; }
        private Account() { }

        public class Builder
        {
            private readonly Account account;

            public Builder()
            {
                account = new Account();
            }

            public Builder setID(int id)
            {
                account.ID = id;
                return this;
            }

            public Builder setTotalAmount(int totalAmount)
            {
                account.TotalAmount = totalAmount;
                return this;
            }

            public Builder setPhoto(string photo)
            {
                account.photo = photo;
                return this;
            }

            public Account Build()
            {
                return account;
            }
        }
    }
}
