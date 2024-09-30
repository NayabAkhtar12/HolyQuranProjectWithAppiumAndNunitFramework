using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace HolyQuran.Pages
{
    class DigitalTasbeeh
    {
        private AppiumDriver<AndroidElement> driver;
        ExtentReports Extent = new ExtentReports();
        ReusableMethods ReusableMethods;

        //Constructor
        public DigitalTasbeeh(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new ReusableMethods(driver, test);
        }

        public void DigitalTasbeehMethod()
        {
            ReusableMethods.ClickwithAd(digitalTasbeehMenu, "digitalTasbeehMenu");
            ReusableMethods.HandleCBanner("On Holy Quran Module");
            ReusableMethods.ElementClick(EditZikrForCount, "EditZikrForCount");
            ReusableMethods.ElementClick(SelectZikrForCount, "SelectZikrForCount");
            ReusableMethods.ElementClick(CountPlus, "CountPlus");
            ReusableMethods.ElementClickandNavigateBack(CountPlus, "CountPlus");
        }


        public IWebElement? digitalTasbeehMenu => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivtasbeeh"), "digitalTasbeehMenu");

        public IWebElement? EditZikrForCount => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivChangeTasbeeh"), "EditZikrForCount");

        public IWebElement? SelectZikrForCount => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvZikar' and @text='بِسْمِ اللهِ الرَّحْمٰنِ الرَّحِيْمِ']"), "SelectZikrForCount");

        public IWebElement? CountPlus => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivTasbeehbtncount"), "CountPlus");


    }
}
