using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace HolyQuran.Pages
{
    class Qibla_Finder
    {
        private AppiumDriver<AndroidElement>? driver;
        ReusableMethods ReusableMethods;

        //Constructor
        public Qibla_Finder(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new ReusableMethods(driver, test);
        }

        public void QiblaFinder()
        {
            //WebDriverWait wait = GetWebDriverWait(5); // Custom 5-second wait

            ReusableMethods.ClickwithAd(qiblaMenu, "Qibla Finder Menu");
            Thread.Sleep(3000);
            ReusableMethods.HandleCBanner("C Banner Qibla Finder Menu Module");
            ReusableMethods.ElementClick(ThemesQibla, "ThemesQibla");
            ReusableMethods.ElementClick(Theme2, "Theme2 click exception");
            ReusableMethods.NavigateBack("back to home");
        }

        public IWebElement? qiblaMenu => driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivqibla");

        public IWebElement? ThemesQibla => driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivChangeTasbeeh");

        public IWebElement? Theme2 => driver?.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/clqibla2");



    }
}
