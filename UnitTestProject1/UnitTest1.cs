using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.Extensions.Configuration;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {

        }



        [TestMethod]
        public void ReadAppSettingsJson()
        {
            //var FilePath = @"C:\Test\SP3 Selenium 4.28 Framework(Net)\UnitTestProject1\appsettings.json";

            // Build configuration 
            //The appsettings.json file is copied to the debug
            //runtime dir, the var basePath points to the debug
            //runtime dir, and loads the json file = "appsettings.json"
            var basePath = System.IO.Directory.GetCurrentDirectory();
            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();

            // Read settings 
            var appName = configuration["ApplicationName"];
            var logLevelDefault = configuration["Logging:LogLevel:Default"];
            var logLevelMicrosoft = configuration["Logging:LogLevel:Microsoft"];


        }
    }
}
