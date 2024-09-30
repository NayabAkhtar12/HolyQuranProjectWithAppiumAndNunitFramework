using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;


namespace HolyQuran.Pages
{
    class Names99
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        TouchAction touchAction;
        ReusableMethods ReusableMethods;


        //Constructor
        public Names99(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.touchAction = new TouchAction(driver);
            ReusableMethods = new ReusableMethods(driver, test);
        }

        public void NamesOfAllah()
        {
            ReusableMethods.ScrollToElementByText("99 Names");
            ReusableMethods.ClickwithAd(Namesnine, "Namesnine menu");

            // 99 Names Read
            ReusableMethods.ClickwithAd(ReadNamesAllah, "ReadNamesAllah");
            ReusableMethods.NavigateBack("ReadNamesAllah back ");

            // 99 Names Allah Listen
            ReusableMethods.ClickwithAd(ListenNamesAllah, "ListenNamesAllah");
            ReusableMethods.HandleCBanner("On ListenNamesAllah 99  c banner close");
            ReusableMethods.ElementClick(Nameplay, "Nameplay");
            Thread.Sleep(6000);
            ReusableMethods.NavigateBack("ListenNamesAllah back ");

            ReusableMethods.HandleCBanner("On  99 Names Home screen c banner close");

            //99 Names Nabi read section
            ReusableMethods.ClickwithAd(ReadNamesHusna, "ReadNamesHusna");
            ReusableMethods.NavigateBack("ReadNamesHusna back ");

            // 99 Names Nabi Listen
            ReusableMethods.ClickwithAd(ListenNamesNabi, "ListenNamesNabi");
            ReusableMethods.HandleCBanner("On ListenNamesNabi 99  c banner close");
            ReusableMethods.ElementClick(Nameplay, "Nameplay ListenNamesNabi");
            Thread.Sleep(6000);
            ReusableMethods.NavigateBack("ListenNamesNabi back ");
            ReusableMethods.NavigateBack("to Homescreen  ");
        }
        public void NamesOfAllah1()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //ReusableMethods.SplashHandling2ndsessiont();

            //Names
            try
            {
                ReusableMethods.ScrollToElementByText("99 Names");
                Namesnine.Click();
                ReusableMethods.HandleCBanner("C Banner 99 Names Menu Module");
                ReusableMethods.InterAdHandle();

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("99 Names", ex);
            }

            // 99 Names Read
            try
            {
                //Thread.Sleep(5000);
                try
                {
                    wait.Until(ExpectedConditions.ElementToBeClickable(ReadNamesAllah));  // Ensure the button is clickable
                    ReadNamesAllah.Click();
                    Console.WriteLine("Successfully clicked on 'ReadNamesAllah' button.");
                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Clicking ReadNamesAllah button", ex);
                }

                try
                {
                    ReusableMethods.InterAdHandle();  // Handle interstitial ad
                    Console.WriteLine("Read names Interstitial ad handled.");
                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Handling interstitial ad", ex);
                }

                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("  BackButton Navigation ", ex);
                }
            }
            catch (NoSuchElementException ex)
            {
                ReusableMethods.HandleException("99 Names Allah Read Issue", ex);

            }

            // 99 Names Listen
            try
            {
                ListenNamesAllah.Click();

                ReusableMethods.InterAdHandle();
                ReusableMethods.HandleCBanner("C Banner ListenNamesAllah Module");

                //Rest of action to perform on Names Listen screen
                try
                {
                    Nameplay.Click();
                    Thread.Sleep(6000);
                    Nameplay.Click();
                    try
                    {
                        driver.Navigate().Back();

                    }
                    catch (Exception ex)
                    {
                        ReusableMethods.HandleException("Backbutton", ex);
                    }
                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException(" Issue 99 Names Allah Listen ", ex);
                }

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("99 Names  Allah listen Issue", ex);
            }

            //99 Names Nabi section

            try
            {
                ReadNamesHusna.Click();
                ReusableMethods.InterAdHandle();

                try
                {
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    ReusableMethods.HandleException("Backbutton", ex);
                }

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("99 Names Read Nabi Issue", ex);
            }

            // 99 Names Nabi  Listen
            try
            {
                ListenNamesNabi.Click();
                ReusableMethods.InterAdHandle();
                //    Thread.Sleep(2000);
                ReusableMethods.HandleCBanner("C Banner ListenNamesNabi Module");


                try
                {
                    Nameplay.Click();
                    Thread.Sleep(6000);
                    Nameplay.Click();
                    try
                    {
                        driver.Navigate().Back();

                    }
                    catch (Exception ex)
                    {
                        ReusableMethods.HandleException("Backbutton", ex);
                    }
                }

                catch (Exception ex)
                {
                    ReusableMethods.HandleException("NamesplayIssue", ex);
                }

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("99 Names  Issue", ex);
            }
            try
            {
                driver.Navigate().Back();

            }
            catch (Exception ex)
            {
                ReusableMethods.HandleException("99 Names  Issue", ex);
            }

        }

        public IWebElement? Namesnine => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivnamesnabi"), "Namesnine");

        public IWebElement? ReadNamesHusna => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_read_nabi_names"), "ReadNamesHusna");

        public IWebElement? ListenNamesNabi => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_listen_nabi_names"), "ListenNamesNabi");

        public IWebElement? ReadNamesAllah => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_read_asma"), "ReadNamesAllah");

        public IWebElement? ListenNamesAllah => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/iv_listen_asma"), "ListenNamesAllah");

        public IWebElement? Nameplay => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivPP"), "Nameplay");

        public IWebElement? Continue => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/StartButton"), "Continue");




    }
}
