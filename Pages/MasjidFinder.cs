using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace HolyQuran.Pages
{
    class MasjidFinder
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        ReusableMethods ReusableMethods;


        //Constructor
        public MasjidFinder(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            ReusableMethods = new ReusableMethods(driver, test);
        }


        public void MasjidFinderMethod()
        {
            ReusableMethods.ClickwithAd(masjidFinderMenu, "masjidFinderMenu");
            Thread.Sleep(6000);
            ReusableMethods.NavigateBack("From Masjid Finder to Home Navigation");
        }

        public IWebElement? masjidFinderMenu => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmasjid"), "masjidFinderMenu");
    }
}
