using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace HolyQuran.Pages
{
    class AlQuran2ndSession
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ReusableMethods ReusableMethods;
        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public AlQuran2ndSession(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            ReusableMethods = new ReusableMethods(driver, test);

        }



        public void PerformQuranOperations()
        {


            ReusableMethods.SplashHandling2ndsessiont();
            ReusableMethods.HandleCBanner("On Holy Quran Module");
            ReusableMethods.ClickwithAd(ALQuranMenu, "Clicking AL Quran Menu");
            ReusableMethods.ClickwithAd(AlFatiha, "Clicking AL Fatiha Menu");
            ReusableMethods.ElementClick(SelectReciterDropDown, "Clicking SelectReciterDropDown");
            ReusableMethods.ElementClick(SelectReciter, "Clicking SelectReciter");
            ReusableMethods.ElementClick(PlaySurah, "Clicking PlaySurah");
            ReusableMethods.ElementClick(SelectReciter, "Clicking SelectReciter");
            ReusableMethods.ElementClick(NextAyah, "NextAyah");
            ReusableMethods.ElementClick(PrevAyah, "PrevAyah");
            ReusableMethods.ElementClick(BookMarkPage, "BookMarkPage");
            ReusableMethods.ElementClick(GotoTranslationSection, "GotoTranslationsection");
            ReusableMethods.ElementClick(DownloadTranslation, "DownloadTranslation");
            ReusableMethods.ElementClick(DownloadedSection, "DownloadedSection");
            ReusableMethods.ElementClick(ViewTranslation, "ViewTranslation");
            ReusableMethods.ElementClick(TranslationNextPage, "TranslationNextPage");
            ReusableMethods.ElementClickandNavigateBack(TranslationPrevPage, "TranslationPrevPage");
            ReusableMethods.NavigateBack("To Home screen  Al Quran");

        }


        public void PerformSwipeOperations()
        {
            ReusableMethods.ClickwithAd(Surah2, "Clicking Surah2 ,  Surah Aal e Imran Swipe");
            ReusableMethods.Swipe();
            ReusableMethods.Swipe();
            ReusableMethods.Swipe();
            ReusableMethods.NavigateBack("To Home screen  Al Quran");
            //Surah Nisa

            ReusableMethods.ClickwithAd(SurahAnNisa, "Clicking SurahAnNisa ,  SurahAnNisa Swipe");
            ReusableMethods.Swipe();
            ReusableMethods.Swipe();
            ReusableMethods.Swipe();
            ReusableMethods.NavigateBack("To Home screen  Al Quran");
            ReusableMethods.NavigateBack("To Home screen main");

        }


        //Web Elements
        public IWebElement? ALQuranMenu => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivquran"), "ALQuranMenu");

        public IWebElement? AlFatiha => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5' and @text='Surat Al-Fatiha']"), "AlFatiha");

        public IWebElement? PlaySurah => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/play"), "PlaySurah");

        public IWebElement? SelectReciterDropDown => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/selectReader"), "SelectReciterDropDown");

        public IWebElement? RepeatVerse => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/repeat"), "RepeatVerse");

        public IWebElement? ViewList => ReusableMethods.FindElement(By.Id(""), "ViewList");

        public IWebElement? Continue => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/StartButton"), "Continue");

        public IWebElement? LanguageSave => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btnCacncel"), "LanguageSave");

        public IWebElement? OnboardSkip => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btn_skip"), "OnboardSkip");

        public IWebElement? OnboardFinish => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/btn_next_step"), "OnboardFinish");

        public IWebElement? StoragePermissionAllow => ReusableMethods.FindElement(By.Id("com.android.permissioncontroller:id/permission_allow_button"), "StoragePermissionAllow");

        public IWebElement? LocationPermissionAllow => ReusableMethods.FindElement(By.Id("com.android.permissioncontroller:id/permission_allow_foreground_only_button"), "LocationPermissionAllow");

        public IWebElement? SelectReciter => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/spinnerText' and @text='Abdullah Basfar']"), "SelectReciter");

        public IWebElement? NextAyah => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/forward"), "NextAyah");

        public IWebElement? PrevAyah => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/before"), "PrevAyah");

        public IWebElement? BookMarkPage => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/bookmark"), "BookMarkPage");

        public IWebElement? GotoTranslationSection => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tafser"), "GotoTranslationSection");

        public IWebElement? AvailableforDownload => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/transtabTv"), "AvailableforDownload");

        public IWebElement? DownloadTranslation => ReusableMethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivHeaderDownStatus'])[2]"), "DownloadTranslation");

        public IWebElement? DownloadedSection => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/tfseerTabTv"), "DownloadedSection");

        public IWebElement? ViewTranslation => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5' and @text='Azerbaijani']"), "ViewTranslation");

        public IWebElement? TranslationPrevPage => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivPrevious"), "TranslationPrevPage");

        public IWebElement? TranslationNextPage => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivNext"), "TranslationNextPage");

        public IWebElement? SurahBack => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/back"), "SurahBack");

        public IWebElement? Surah2 => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5' and @text='Surat Aal-E-Imran']"), "Surah2");

        public IWebElement? SurahAnNisa => ReusableMethods.FindElement(By.XPath("//android.widget.TextView[@resource-id='com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/textView5' and @text='Surat An-Nisa']"), "SurahAnNisa");



    }
}
