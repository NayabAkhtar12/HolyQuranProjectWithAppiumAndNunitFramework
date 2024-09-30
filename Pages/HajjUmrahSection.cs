using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace HolyQuran.Pages
{
    class HajjUmrahSection
    {
        private AppiumDriver<AndroidElement> driver;
        ReusableMethods ReusableMethods;


        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public HajjUmrahSection(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new ReusableMethods(driver, test);
        }

        public void HajjGuide()
        {
            ReusableMethods.ClickwithAd(HajjUmrahMenu, "HajjUmrahMenu");
            ReusableMethods.HandleCBanner("C Banner Hajj umrah Menu Module");

            ReusableMethods.ClickwithAd(HajjGuideMenu, "HajjGuideMenu");
            ReusableMethods.HandleCBanner("C Banner HajjGuideMenu Menu Module");

            ReusableMethods.ElementClickandNavigateBack(HajjGuideDay1, "HajjGuideDay1");
            ReusableMethods.ElementClickandNavigateBack(HajjGuideDay2, "HajjGuideDay2");
            ReusableMethods.ElementClickandNavigateBack(HajjGuideDay3, "HajjGuideDay3 and Navigation Hajj Home");
            ReusableMethods.NavigateBack("Navigation Hajj Umrah Home");


        }

        public void UmrahGuide()
        {
            //Umrah
            ReusableMethods.ClickwithAd(UmrahGuideMenu, "umrahGuideMenu");
            ReusableMethods.HandleCBanner("C Banner umrahGuideMenu Menu Module");

            ReusableMethods.ElementClickandNavigateBack(UmrahIhram, "UmrahIhram");
            ReusableMethods.ElementClickandNavigateBack(UmrahTawaf, "UmrahTawaf");
            ReusableMethods.ElementClickandNavigateBack(UmrahSAEE, "UmrahSAEE ");
            ReusableMethods.NavigateBack("Navigation  Hajj Umrah Screen ");
            ReusableMethods.NavigateBack("Navigation to   Home");

        }

        public void FamousPlacesofMakkah()
        {
            try
            {
                FamousPlacesofMakkahMenu.Click();
                Thread.Sleep(3000);
                FamousPlacesofMakkahKaaba.Click();
                Thread.Sleep(3000);

                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                FamousPlacesofMakkahMina.Click();
                Thread.Sleep(3000);

                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }                //  driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Kaaba/Mina Location Makkah ", ex);
            }
        }
        public void FamousPlacesofMedina()
        {
            try
            {
                FamousPlacesofMedinahMenu.Click();
                Thread.Sleep(3000);

                FamousPlacesofMedinah_AlNabwi.Click();
                Thread.Sleep(3000);

                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                FamousPlacesofMedinah_UhudMountain.Click();
                Thread.Sleep(3000);

                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                Thread.Sleep(1500);
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                HajhUmrahUQibla.Click();
                Thread.Sleep(1500);
                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }
                Thread.Sleep(1500);
            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Medina Places", ex);
            }
            try
            {
                driver.Navigate().Back();

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("Backbutton", ex);
            }

        }


        public IWebElement? HajjGuideDay1 => ReusableMethods.FindElement(By.XPath("//ndroid.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc' and @text='8th of Dhul Hijjah']"), "HajjGuideDay1");

        public IWebElement? HajjGuideMenu => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivhajj"), "HajjGuideMenu");

        public IWebElement? HajjUmrahMenu => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivnameshusna"), "HajjUmrahMenu");

        public IWebElement? HajjGuideDay2 => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc' and @text='9th of Dhul Hijjah']"), "HajjGuideDay2");

        public IWebElement? HajjGuideDay3 => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc' and @text='10th of Dhul Hijjah']"), "HajjGuideDay3");

        public IWebElement? HajjGuideDay4 => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc' and @text='11th of Dhul Hijjah']"), "HajjGuideDay4");

        public IWebElement? HajjGuideDay5 => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc' and @text='12th of Dhul Hijjah']"), "HajjGuideDay5");

        public IWebElement? HajjGuideDay6 => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDayDesc' and @text='13th of Dhul Hijjah']"), "HajjGuideDay6");

        public IWebElement? UmrahGuideMenu => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivumrah"), "UmrahGuideMenu");

        public IWebElement? UmrahIhram => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay' and @text='IHRAM']"), "UmrahIhram");

        public IWebElement? UmrahTawaf => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay' and @text='TAWAAF']"), "UmrahTawaf");

        public IWebElement? UmrahSAEE => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay' and @text='SA’EE']"), "UmrahSAEE");

        public IWebElement? UmrahShaving => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay' and @text='SHAVING']"), "UmrahShaving");

        public IWebElement? FamousPlacesofMakkahMenu => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmakkah"), "FamousPlacesofMakkahMenu");

        public IWebElement? FamousPlacesofMakkahKaaba => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay' and @text='Kaaba']"), "FamousPlacesofMakkahKaaba");

        public IWebElement? FamousPlacesofMakkahMina => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay' and @text='Mina']"), "FamousPlacesofMakkahMina");

        public IWebElement? FamousPlacesofMedinahMenu => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivmadina"), "FamousPlacesofMedinahMenu");

        public IWebElement? FamousPlacesofMedinah_AlNabwi => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay' and @text='Al Masjid an Nabawi']"), "FamousPlacesofMedinah_AlNabwi");

        public IWebElement? FamousPlacesofMedinah_UhudMountain => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tvDay' and @text='Uhud Mountain']"), "FamousPlacesofMedinah_UhudMountain");

        public IWebElement? HajhUmrahUQibla => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivqibla"), "HajhUmrahUQibla");

    }
}
