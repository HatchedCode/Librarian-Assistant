

namespace EngineTests.UserTests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using NUnit.Framework;
    using ApplicationEngine.UserTypes;

    class UserFactoryTest
    {
        /// <summary>
        /// The first object that is being tested.
        /// </summary>
        private UserFactory objectUnderTest1;

        /// <summary>
        /// This method gets the method that we are trying to test.
        /// </summary>
        /// <param name="objectUnderTest">The object that is being tested.</param>
        /// <param name="methodName">Name of method.</param>
        /// <param name="types">The types that the method accepts.</param>
        /// <returns> The method info. </returns>
        private MethodInfo GetMethod(object objectUnderTest, string methodName, params Type[] types)
        {
            if (string.IsNullOrWhiteSpace(methodName))
            {
                Assert.Fail("methodNamecannot	be	null	or	whitespace");
            }

            // Added the BindingFlags.Public so that I am able to test the public functions within the class too.
            var method = objectUnderTest.GetType()
                .GetMethod(
                    methodName,
                BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public,
                null,
                types,
                null);

            if (method == null)
            {
                Assert.Fail(string.Format("{0}	method	not	found", methodName));
            }

            return method;
        }
    }
}
