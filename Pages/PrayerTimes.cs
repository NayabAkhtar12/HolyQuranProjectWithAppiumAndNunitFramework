using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace HolyQuran.Pages
{
    class PrayerTimes
    {
        private AppiumDriver<AndroidElement> driver;
        ReusableMethods ReusableMethods;

        //Constructor
        public PrayerTimes(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new ReusableMethods(driver, test);

        }

        public void PrayerTimesMethod()
        {
            ReusableMethods.ClickwithAd(prayerTimesMenu, "prayerTimesMenu");
            ReusableMethods.HandleCBanner("On Prayer times c banner Module");
            ReusableMethods.ElementClick(PrayerTimeNotification, "PrayerTimeNotification");
            ReusableMethods.ElementClickandNavigateBack(PrayerTimeNotification, "PrayerTimeNotification");
        }


        public IWebElement? PrayerTimeNotification => ReusableMethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ib_notification'])[3]"), "PrayerTimeNotification");

        public IWebElement? prayerTimesMenu => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivprayers"), "prayerTimesMenu");






    }
}
