﻿using System;

using System.Configuration;
using FactoryClient;
 


namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string sClientType = ConfigurationManager.AppSettings["ClientType"];
                string sOutputString = ConfigurationManager.AppSettings["OutputString"];
                var cli = Factory.Create(sClientType);
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
