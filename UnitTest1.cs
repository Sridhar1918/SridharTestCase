using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Trailportalsignin
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest4
    {
        public UnitTest4()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod2()
        {
            System.TimeSpan span = new System.TimeSpan(0, 0, 0, 20, 0);

            //load chrome and the sharepoint library you want to upload to
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://thota9887.sharepoint.com/_layouts/15/sharepoint.aspx";

            //click the upload button
            driver.FindElement(By.Id("QCB1_Button2")).Click();

            //switch the driver focus to the file upload modal
            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("ms-dlgFrame")));

            //allow some time for the modal to load 
            WebDriverWait wait = new WebDriverWait(driver, span);

            //get the upload field from the sharepoint modal
            IWebElement uploadElement = driver.FindElement(By.Id("ctl00_PlaceHolderMain_ctl02_ctl04_InputFile"));

            //use sendkeys to insert the path to the file you want to upload
            uploadElement.SendKeys(@"C:\taco.txt");

            //click the ok button on the modal
            driver.FindElement(By.Id("ctl00_PlaceHolderMain_ctl01_RptControls_btnOK")).Click();
        }
    }
}
       
