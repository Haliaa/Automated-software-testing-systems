using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalaizerClassLibrary;
using System;

namespace AnalaizerClassLibraryesTests
{
    [TestClass]
    public class ReplaceUnaryPlusMinusTest
    {
        public TestContext TestContext { get; set; }

        [DataSource("System.Data.SqlClient", @"Data Source=DESKTOP-FACGHCU\SQLEXPRESS;Initial Catalog=testing;Integrated Security=True", "TestingData", DataAccessMethod.Sequential)]

        [TestMethod]

        public void InputString_ReplaceUnaryPlusMinusTest_ChangedString()
        {

            //Assert
            string actualString = (string)TestContext.DataRow["actualString"];
            string expectedString = (string)(TestContext.DataRow["expectedString"]);

            //Actual
            string result;

            //Assert
            try
            {
                result = AnalaizerClass.ReplaceUnaryPlusMinus(actualString);
                Assert.AreEqual(result, expectedString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}