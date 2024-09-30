using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace HolyQuran.Pages
{
    class HijriCalender
    {
        private AppiumDriver<AndroidElement> driver;
        ReusableMethods ReusableMethods;

        //Constructor
        public HijriCalender(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new ReusableMethods(driver, test);

        }

        public void HijriCalendar()
        {
            ReusableMethods.ClickwithAd(hijriCalendarMenu, "hijriCalendarMenu");
            ReusableMethods.ElementClick(NextMonth, "EditZikrForCount");
            ReusableMethods.ElementClick(PrevMonth, "SelectZikrForCount");
            ReusableMethods.ElementClick(Date, "CountPlus");
            ReusableMethods.ElementClick(NextMonth, "EditZikrForCount");
            ReusableMethods.ElementClickandNavigateBack(Date, "Navigation from Calender to Home");
        }

        public IWebElement? hijriCalendarMenu => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivcalendar"), "hijriCalendarMenu");

        public IWebElement? PrevMonth => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/next_month"), "PrevMonth");

        public IWebElement? NextMonth => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/next_month"), "NextMonth");

        public IWebElement? Date => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/gregorian_calendar_day' and @text='14']"), "Date");



    }
}
