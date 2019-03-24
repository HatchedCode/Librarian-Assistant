using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationEngine.UserTypes
{
    internal partial class Librarian: User
    {

    }
    internal class Admin: User
    {
        private ushort adminLevel;
        private ushort newAttribute;

        public ushort Level
        {
            get { return this.adminLevel; }
            set { this.adminLevel = value; }
        }

        public Admin()
        {

        }

        public void RemoveUser(string networkId)
        {

        }

        public void AddUser(User newUser)
        {

        }

    }
}
