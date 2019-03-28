using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationEngine.UserTypes
{
    internal class UserFactory
    {
        // This represents the random number generator.
        private static Random rnd = new Random();

        public UserFactory(string[] listExtendedAssemblies = null)
        {
            try
            {
                this.RetrieveAllUserTypesInSolution((op, type) => this.availableUserTypes.Add(op, type), listExtendedAssemblies);
            }
            catch(ArgumentException)
            {
                // Console.WriteLine("User kind is already in the system.");
            }
        }

        private Dictionary<ushort,Type> availableUserTypes;
        private delegate void OnUserType(ushort typeID, Type userType);
        private void RetrieveAllUserTypesInSolution(OnUserType curUserType, string[] extendedAssembliesOutsideLibrary = null)
        {
            Type userType = typeof(User);

            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                IEnumerable<Type> userTypes = assembly.GetTypes().Where(type => type.IsSubclassOf(userType));

                foreach (var type in userTypes)
                {
                    PropertyInfo typeId = type.GetProperty("typeID");
                    if (typeId != null)
                    {
                        object level = typeId.GetValue(typeId);
                        if (level is ushort)
                        {
                            ushort typeLevel = (ushort)level;

                            curUserType(typeLevel, type);
                        }
                    }
                }
            }

            if (extendedAssembliesOutsideLibrary != null)
            { 
                foreach (string assemblyname in extendedAssembliesOutsideLibrary)
                {
                    try
                    {
                        Assembly assembly = Assembly.Load(assemblyname);
                        IEnumerable<Type> userTypes = assembly.GetTypes().Where(type => type.IsSubclassOf(userType));
                        foreach (var type in userTypes)
                        {
                            PropertyInfo userTypeField = type.GetProperty("typeID");
                            if (userTypeField != null)
                            {
                                object typeValue = userTypeField.GetValue(type);
                                if (typeValue is ushort typeLevel)
                                {
                                    curUserType(typeLevel, type);
                                }
                            }
                        }

                    }
                    catch (Exception e)
                    {
                        if (e is ArgumentException || e is System.IO.FileNotFoundException || e is System.IO.FileLoadException || e is BadImageFormatException)
                        {
                            // This is the case that the name is an error.
                        }
                    }
                }
            }
        }

        public User CreateNewUser(ushort typeID, Tuple<string,uint,string> basicInfo)
        {
            if(this.availableUserTypes.ContainsKey(typeID))
            {
                object userObject = Activator.CreateInstance(this.availableUserTypes[typeID]);
                if(userObject is User)
                {
                    return (User)userObject;
                }
            }

            // Case that the user type is not in the library
            return null;
        }

        public static uint GenerateNetworkID()
        {
            string strNetworkIDrep = "";
            IEnumerable<int> MaxNumberOfDigits = Enumerable.Range(1, 8);
            foreach (int index in MaxNumberOfDigits)
            {
                strNetworkIDrep += (uint)rnd.Next();
            }

            if(uint.TryParse(strNetworkIDrep, out uint result))
            {
                return result;
            }

            return 1;
        }

        private static bool CheckNetworkID(uint newNetworkID)
        {
            // Check database to see if there exists such a networkid.
            return true;
        }
    }
}
