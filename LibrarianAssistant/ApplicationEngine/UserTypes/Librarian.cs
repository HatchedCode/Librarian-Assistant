using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationEngine.UserTypes
{
    internal partial class Librarian : User
    {
       // private int isLibrarian= 0;

        public int level = 0;


        public int Level
        {
            get { return this.level; }
            set { this.level = value; }

        }



    }
}
