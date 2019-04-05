﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationEngine.UserTypes
{
    internal abstract class User: INotifyPropertyChanged
    {
        private string name;
        private uint networkID;
        private string password;

        /// <summary>
        /// An event handler that handles events ( when a property changes).
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public User(string name = "", uint networkID = 00000000, string password = "")
        {
            this.password = password;
            this.name = name;
            this.networkID = networkID;
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public uint NetworkID
        {
            get { return networkID; }
            set { this.networkID = value; }
        }

         public string Password
        {
            get { return password; }
            set { this.password = value; }
        }
    }
}