using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TravelToLearn
{
    public class UnitTest1
    {
        public void siteacma()            
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:50850/Default/Index");
            //ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            //service.HideCommandPromptWindow = true;
            //IWebDriver adriver = new ChromeDriver(service);
            //a
        }
    }
}