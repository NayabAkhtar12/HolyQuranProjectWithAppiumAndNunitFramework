using AventStack.ExtentReports;
using HolyQuran.Core;
using HolyQuran.Pages;
using NUnit.Framework;

namespace HolyQuran.Test_Class
{
    [TestFixture]
    public class Test_Class : TestInitiallize
    {
        QuranFirstSession? QuranFirstSession;
        AlQuran2ndSession? AlQuran2ndSession;
        Qibla_Finder? QFinder;
        DigitalTasbeeh? DTasbeeh;
        MasjidFinder? MFinder;
        PrayerTimes? PTimes;
        HijriCalender? HijCal;
        HajjUmrahSection? HajjUmrah;
        Azkar? Azkar;
        Names99? Names;
        PremiumandMenu? Premiumand;

        //[Test, Order(1)]
        public void HolyQuranStartUp()
        {
            ExtentTest test = Extent.CreateTest("HolyQuranStartUp Report");
            QuranFirstSession = new QuranFirstSession(driver, test);
            QuranFirstSession.QuranLaunch();
            QuranFirstSession.AlQuranDownload();
        }


        //[Test, Order(2)]
        public void TC01_HolyQuran2ndSession()
        {
            System.Diagnostics.Trace.WriteLine("Test1");
            ExtentTest test = Extent.CreateTest("TC01_HolyQuran2ndSession Report");
            AlQuran2ndSession = new AlQuran2ndSession(driver, test);
            //   AlQuran2ndSession.Surah1();
            AlQuran2ndSession.PerformQuranOperations();
            AlQuran2ndSession.PerformSwipeOperations();
        }


        [Test, Order(3)]
        public void TC03_QiblaFinderTest()
        {
            ExtentTest test = Extent.CreateTest("QiblaFinderTest Report");
            QFinder = new Qibla_Finder(driver, test);
            QFinder.QiblaFinder();
        }

        [Test, Order(4)]
        public void TC03_DigitalTasbeehTest()
        {
            ExtentTest test = Extent.CreateTest("DigitalTasbeehTest Report");
            DTasbeeh = new DigitalTasbeeh(driver, test);
            DTasbeeh.DigitalTasbeehMethod();
        }


        [Test, Order(5)]
        public void TC04_MasjidFinderTest()
        {
            ExtentTest test = Extent.CreateTest("MasjidFinderTest Report");
            MFinder = new MasjidFinder(driver, test);
            MFinder.MasjidFinderMethod();
        }


        [Test, Order(6)]
        public void TC05_PrayerTimesTest()
        {
            ExtentTest test = Extent.CreateTest("PrayerTimesTest Report");
            PTimes = new PrayerTimes(driver, test);
            PTimes.PrayerTimesMethod();
        }

        [Test, Order(7)]
        public void TC06_HijriCalenderTest()
        {
            ExtentTest test = Extent.CreateTest("HijriCalenderTest Report");
            HijCal = new HijriCalender(driver, test);
            HijCal.HijriCalendar();
        }



        [Test, Order(8)]
        public void TC07_HajjandUmrahSection()
        {
            ExtentTest test = Extent.CreateTest("HajjandUmrahSection Report");
            HajjUmrah = new HajjUmrahSection(driver, test);
            HajjUmrah.HajjGuide();
            HajjUmrah.UmrahGuide();
        }

        [Test, Order(9)]
        public void TC08_AzkarSection()
        {
            ExtentTest test = Extent.CreateTest("AzkarSection Report");
            Azkar = new Azkar(driver, test);
            Azkar.AzkarMethod();
        }

        [Test, Order(10)]
        public void TC09_NamesTest()
        {
            ExtentTest test = Extent.CreateTest("99 Names Report");
            Names = new Names99(driver, test);
            Names.NamesOfAllah();
        }

        [Test, Order(11)]
        public void TC10_PremiumandMenu()
        {
            ExtentTest test = Extent.CreateTest("PremiumandMenu Report");
            Premiumand = new PremiumandMenu(driver, test);
            Premiumand.PremiumandMenuMethod();
        }

        QuranAI QuranAi;

        [Test, Order(1)]
        public void QuranAI()
        {
            ExtentTest test = Extent.CreateTest("PremiumandMenu Report");
            QuranAi = new QuranAI(driver, test);
            QuranAi.QuranAITest();
        }

    }
}
