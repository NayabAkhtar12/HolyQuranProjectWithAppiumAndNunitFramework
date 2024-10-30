using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace HolyQuran.Core
{
    [TestFixture]
    public class TestInitiallize
    {
        public AndroidDriver<AndroidElement>? driver;
        //   private AndroidDriver<AndroidElement> driver;

        public static ExtentReports Extent;
        private static ExtentSparkReporter? _reporter;

        // public AndroidDriver<AndroidElement> Driver { get => driver; set => driver = value; }

        // Static constructor for initializing ExtentReports
        static TestInitiallize()
        {
            string reportPath = @"D:\Reports\report.html";  // Ensure you are using the correct folder path
            _reporter = new ExtentSparkReporter(reportPath);
            Extent = new ExtentReports();
            Extent.AttachReporter(_reporter);
        }

        //public TestInitiallize()
        //{
        //    string reportPath = @"D:\Reports\report.html";  // Ensure you are using the correct folder path
        //    var ExtentSparkReports = new ExtentSparkReporter(reportPath);
        //    Extent = new ExtentReports();
        //    Extent.AttachReporter(ExtentSparkReports);
        //}

        [SetUp]
        public void Setup()
        {
            try
            {
                AppiumOptions? cap = new AppiumOptions();
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Vivo Y03");
                cap.AddAdditionalCapability(MobileCapabilityType.Udid, "ONOZSG4H8HSGW8HY");
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "14");
                cap.AddAdditionalCapability("appium:automationName", AutomationName.AndroidUIAutomator2);

                // This is the key part that will launch the app
                cap.AddAdditionalCapability("appPackage", "");
                cap.AddAdditionalCapability("appActivity", "");
                string Appiumuri = "http://127.0.0.1:4723/";
                string Appiumuri1 = "http://192.168.100.14:4723/";

                driver = new AndroidDriver<AndroidElement>(new Uri(Appiumuri), cap, TimeSpan.FromSeconds(180));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to initialize driver: {e.Message}");
                throw;
            }
        }

        [TearDown]
        public void CleanUp()
        {
            try
            {
                if (driver != null)
                {
                    driver.CloseApp();
                    driver.Quit();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to initialize driver: {e.Message}");
                throw;
            }
            Extent.Flush();

        }
    }
}
