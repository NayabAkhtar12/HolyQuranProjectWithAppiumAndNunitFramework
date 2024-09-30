using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace HolyQuran.Pages
{
    class PremiumandMenu
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelper adHelper;
        ReusableMethods ReusableMethods;
        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public PremiumandMenu(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.adHelper = new AdHelper(driver);
            ReusableMethods = new ReusableMethods(driver, test);
        }


        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }
        public void PremiumandMenuMethod()
        {
            try
            {
                Pro.Click();
                Thread.Sleep(3000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Prayer Times", ex);
            }

            try
            {
                Menu.Click();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                HandleException("Menu", ex);
            }

            try
            {
                PrivacyPolicy.Click();
                Thread.Sleep(7000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("PrivacyPolicy", ex);
            }

            try
            {
                Menu.Click();
                MoreApps.Click();
                Thread.Sleep(3000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("MoreApps", ex);
            }
            try
            {
                Menu.Click();
                RateUs.Click();
                Thread.Sleep(3000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("ExitApp", ex);
            }
            try
            {
                Menu.Click();
                ExitApp.Click();
                Thread.Sleep(3000);
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("ExitApp", ex);
            }
        }

        public IWebElement? Pro => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivPurchaseBtn"), "Pro");

        public IWebElement? Menu => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/menubtn"), "Menu");

        public IWebElement? PrivacyPolicy => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@text='Privacy Policy']"), "PrivacyPolicy");

        public IWebElement? MoreApps => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@text='More Apps']"), "MoreApps");

        public IWebElement? RateUs => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@text='Rate Us!']"), "RateUs");

        public IWebElement? ExitApp => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@text='Exit']"), "ExitApp");

        public IWebElement? Yes => ReusableMethods.FindElement(By.XPath(""), "Yes");  // No XPath provided, please update if necessary

        public IWebElement? No => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/exit_no"), "No");



    }
}
