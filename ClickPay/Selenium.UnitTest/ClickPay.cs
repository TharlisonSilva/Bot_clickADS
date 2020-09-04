using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestClass]
    public class ClickPay
    {
        public IWebDriver driver;
        private StringBuilder verificationErrors;
        public string baseURL;
        
        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            
        }

        [TestInitialize]
        public void InitializeTest()
        {
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void Click_Pay_Test()
        {
            int contador = 0;
            Random numAleatorio = new Random();

            string[] links = new string[] { @"http://raboninco.com/1zhUW",
                                            @"http://raboninco.com/1zsL0",
                                            @"http://raboninco.com/1zsLr",
                                            @"http://raboninco.com/1zsN3",
                                            @"http://raboninco.com/1zsUS",
                                            @"http://raboninco.com/1zsVW",
                                            @"http://raboninco.com/1zsXo",
                                            @"http://raboninco.com/1zsZp",
                                            @"http://raboninco.com/1zsay",

                                            @"http://raboninco.com/1zsVW",
                                            @"http://raboninco.com/20YKz",
                                            @"http://raboninco.com/20YFx",
                                            @"http://raboninco.com/20YDg",
                                            @"http://raboninco.com/20YEK",
                                            @"http://raboninco.com/20YFL",
                                            @"http://raboninco.com/20YGS",
                                            @"http://raboninco.com/20YHF",
                                            @"http://raboninco.com/20YIB",
                                            @"http://raboninco.com/20YIv",
                                            @"http://raboninco.com/20YJh"};
            while (contador == 0)
            {
                try
                {
                    while (contador < 1000)
                    {
                        var option = new ChromeOptions()
                        {
                            BinaryLocation = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
                        };

                        this.driver = new ChromeDriver(option);
                        int posicao = numAleatorio.Next(0, 19);

                        driver.Navigate().GoToUrl(links[posicao]);
                        Thread.Sleep(15000);
                        /*
                         if ( (driver.PageSource.Contains("id=" + "\"" + "abC" + "\"")) &&
                             (driver.PageSource.Contains("id=" + "\"" + "_bd" + "\"")) &&
                             (driver.PageSource.Contains("Continuar")))
                        {
                            driver.FindElement(By.Id("abC")).Click();
                            Thread.Sleep(7000);
                            driver.FindElement(By.Id("skip_bu2tton")).Click();
                            Thread.Sleep(1000);
                        }
                        else
                        {*/
                            driver.FindElement(By.Id("skip_bu2tton")).Click();
                            Thread.Sleep(5000);
                        //}
                        
                        this.driver.Dispose();
                        contador++;
                    }
                    contador = 0;
                }
                catch
                {
                    this.driver.Dispose();
                    contador = 0;
                }
            }

            //ITakesScreenshot camera = driver as ITakesScreenshot;
            //Screenshot screenshot = camera.GetScreenshot();                  SE QUISER TIRAR FOTOS DE CADA CLICK 
            //screenshot.SaveAsFile($"{Guid.NewGuid()}.png");

            //Assert.IsNotNull(driver.FindElement(By.XPath("//pre[contains(text(),'Sucesso')]")));
        }
    }
}
