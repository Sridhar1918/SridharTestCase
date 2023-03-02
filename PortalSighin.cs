using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System.Reflection;

namespace Trailportalsignin
{
    [TestClass]

    public class Traillogin
    {
        [TestMethod]
        public void Trailportallogin()
        {
            int waitingTime = 3000;
            int waitingTime1 = 20000;
            By Username = By.XPath("//input[@id='Username']");
            By Passward = By.XPath("//input[@id='PasswordValue']");
            By Signin = By.XPath("//button[@id='submit-signin-local']");


            IWebDriver webDriver = new EdgeDriver();

            Thread.Sleep(waitingTime1);

            webDriver.Navigate().GoToUrl("https://shreedhar9887.powerappsportals.com/SignIn?returnUrl=%2F");

            Thread.Sleep(waitingTime1);

            webDriver.Manage().Window.Maximize();

            Thread.Sleep(waitingTime);

            webDriver.FindElement(Username).SendKeys("Shreedhar9887");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(Passward).SendKeys("Sera@9887");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(Signin).Click();

            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("//a[contains(text(), 'Students')]")).Click();
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("//a[contains(text(), 'View')]")).Click();
            Thread.Sleep(waitingTime);

            By Search = By.XPath("//input[@class='query form-control']");

            //1st Record Checking
            webDriver.FindElement(Search).SendKeys("Sridhar");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(Search).SendKeys(Keys.Enter);

            By FisrtRecord = By.XPath("//a[@href='/details/?id=5aa50b63-08a9-ed11-aacf-000d3a0aab51']");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(FisrtRecord).Click();
            Thread.Sleep(waitingTime);

            var actualFirstRecd = webDriver.FindElement(By.XPath("//input[@Value='Sridhar@gmail.com']")); 
            
            Assert.IsTrue(actualFirstRecd.Equals(actualFirstRecd));

            webDriver.FindElement(By.XPath("//a[contains(text(), 'Students')]")).Click();
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("//a[contains(text(), 'View')]")).Click();
            Thread.Sleep(waitingTime);

            //2nd Record Checking
            webDriver.FindElement(Search).SendKeys("Avengers");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(Search).SendKeys(Keys.Enter);

            By SecondRecord = By.XPath("//a[@href='/details/?id=0d3cc245-5ea9-ed11-aacf-000d3a0aab51']");
            Thread.Sleep(waitingTime);

            webDriver.FindElement(SecondRecord).Click();
            Thread.Sleep(waitingTime);

            var actualSecondRecd = webDriver.FindElement(By.XPath("//input[@Value='avengers@gmail.com']"));

            Assert.IsTrue(actualSecondRecd.Equals(actualSecondRecd));

            webDriver.FindElement(By.XPath("//a[contains(text(), 'Students')]")).Click();
            Thread.Sleep(waitingTime);

            webDriver.FindElement(By.XPath("//a[contains(text(), 'View')]")).Click();
            Thread.Sleep(waitingTime);






        }
    }
}