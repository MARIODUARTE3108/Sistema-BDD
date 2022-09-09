using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.BDD.Helpers
{
    public static class TestsHelper
    {
        private static string _path = "c:\\temp\\";

        public static IWebDriver GetInstance()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }

        public static void SaveSreenshot(IWebDriver driver, string filename)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile($"{_path}{filename}.png", ScreenshotImageFormat.Png);
        }
    }
}
