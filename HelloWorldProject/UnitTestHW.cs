using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryClient;

namespace HelloWorldProject
{
    [TestClass]
    public class UnitTestHW
    {
        [TestMethod]
        public void TestWrite()
        {
            try
            {
                string sClientType = "Console";
                string sOutputString = "Hello World"; ;
                var cli = Factory.Create(sClientType);
                Assert.IsNotNull(cli);
                cli.Write(sOutputString);
            }
 
            catch (Exception e)
            {
                Console.Write("An error occurred: '{0}'", e);
                Console.Write("\nPress enter to finish... ");
                Console.ReadLine();
            }

        }
    }
}
