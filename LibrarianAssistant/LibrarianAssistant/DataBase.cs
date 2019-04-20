using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ApplicationEngine
{

    



    class DataBase
    {

        private UserTypes.Librarian lib = new UserTypes.Librarian();
       
     
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "AzjbyoyIlfvOFVzasWvFtWd9qUquxgEk2RNIWfXW",
            BasePath = "https://libraryassistantv1.firebaseio.com/"
        };

        IFirebaseClient client;

        public DataBase()
        {
            client = new FireSharp.FirebaseClient(config);
        }

        public async void AddAsync(string key, ApplicationEngine.UserTypes.Librarian adder)
        {

            SetResponse response = await client.SetTaskAsync(key, adder);
            ApplicationEngine.UserTypes.Librarian results = response.ResultAs<ApplicationEngine.UserTypes.Librarian>();

        }

        public async void search(string type, string key)
        {
            
            FirebaseResponse response = await client.GetTaskAsync(type+"/"+key);
            this. lib = response.ResultAs<ApplicationEngine.UserTypes.Librarian>();

        }


  

        public UserTypes.Librarian GetLibrarian(string type, string key)
        {
            search(type, key);
            return this.lib;
        }




    }
  
}
