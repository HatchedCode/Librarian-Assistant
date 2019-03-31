using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationEngine.UserTypes
{
    internal partial class Librarian: User
    {
        private ushort typeID => 2;

    }
    internal class Admin: User
    {
        private ushort adminLevel;
        private ushort newAttribute;
        private ushort typeID => 1;
        private readonly UserFactory userFactory;

        public ushort AdminLevel
        {
            get { return this.adminLevel; }
            set { this.adminLevel = value; }
        }

        public ushort NewAttribute
        {
            get { return this.newAttribute; }
        }

        public ushort TypeLevel => this.typeID;

        public Admin()
        {

        }

        public void RemoveUser(string networkId)
        {
            // verify that the network id exists in the database.
        }

        public void AddUser(ushort typeID, Tuple<string,uint,string> UserBasicinfo)
        {
            this.userFactory.CreateNewUser(typeID, UserBasicinfo);
        }

    }
}
