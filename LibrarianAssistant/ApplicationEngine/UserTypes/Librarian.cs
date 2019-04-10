using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationEngine.UserTypes
{
    internal partial class Librarian: User
    {
        string firstName;
        string lastName;
        string password;
        string iD;

        public Librarian()
        {
            firstName = "";
            lastName = "";
            password = "";
            iD = "";
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string ID
        {
            get
            {
                return iD;
            }
            set
            {
                iD = value;
            }
        }
    }
}
