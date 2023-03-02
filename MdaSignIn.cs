using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Trailportalsignin
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class MdaSignIn
    {
        public MdaSignIn()
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

        [TestMethod]
        public void TestMethod1()
        {
                int waitingTime = 3000;
                int waitingTime1 = 10000;

            By SigninEmail = By.XPath("//input[@id='i0116']");
            By NextButton = By.XPath("//input[@id='idSIButton9']");
            By SigninPassward = By.XPath("//input[@id='i0118']");
            By AskButton = By.XPath("//input[@id='btnAskLater']");

            By ResultTable = By.XPath("//div[4]/div[1]/div[1]/div[2]/ul/li[5]/ul/li[2]/div/div[1]/div[2]");
            By CreateButton = By.XPath("//button[@id='shree_result|NoRelationship|HomePageGrid|Mscrm.NewRecordFromGrid14-button']");
            By Name = By.XPath("//input[@data-id='shree_name.fieldControl-text-box-text']");


            IWebDriver webDriver = new ChromeDriver();
            Thread.Sleep(waitingTime);

            webDriver.Navigate().GoToUrl("https://shreedhar9887.crm8.dynamics.com/main.aspx?appid=ad64401c-07a9-ed11-aacf-000d3a0aab51");
            Thread.Sleep(waitingTime);

            webDriver.Manage().Window.Maximize();
            Thread.Sleep(waitingTime);

            webDriver.FindElement(SigninEmail).SendKeys("Shreedhar@Thota9887.onmicrosoft.com");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(NextButton).Click();
            Thread.Sleep(waitingTime);

            webDriver.FindElement(SigninPassward).SendKeys("Sera@9887");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(NextButton).Click();
            Thread.Sleep(waitingTime);

            webDriver.FindElement(AskButton).Click();
            Thread.Sleep(waitingTime);

            webDriver.FindElement(NextButton).Click();
            Thread.Sleep(waitingTime1);      



        }
    }
}
