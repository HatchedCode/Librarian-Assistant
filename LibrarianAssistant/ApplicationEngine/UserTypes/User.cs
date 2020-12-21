using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ApplicationEngine.UserTypes


{
    internal abstract class User: INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private uint iD;
        private string password;

        /// <summary>
        /// An event handler that handles events ( when a property changes).
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public User(string firstName = "", string lastName = "", uint networkID = 00000000, string password = "")
        {
            this.password = password;
            this.firstName = firstName;
            this.ID = networkID;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }

        public uint ID
        {
            get { return iD; }
            set { this.iD = value; }
        }

         public string Password
        {
            get { return password; }
            set { this.password = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}
