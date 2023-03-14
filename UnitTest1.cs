using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Trailportalsignin
{

    [TestClass]
    public class UnitTest4
    {

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
       
