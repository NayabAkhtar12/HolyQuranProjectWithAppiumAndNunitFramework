using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace HolyQuran.Pages
{
    class ReusableMethods
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelperC adHelper;
        TouchAction touchAction;

        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        // Constructor
        public ReusableMethods(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.adHelper = new AdHelperC(driver);
            this.touchAction = new TouchAction(driver);

        }

        public void SplashHandling2ndsessiont()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(Continue)).Click();
            }
            catch (Exception ex)
            {
                HandleException("Clicking Continue", ex);
            }

            InterAdHandle();
            Thread.Sleep(4000);
        }

        //public void HandleException1(string action, Exception ex)
        //{
        //    Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
        //    Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        //}


        public void HandleExceptione(string actionName, Exception ex)
        {
            // Log the error message
            Test.Log(Status.Fail, $"Test failed during: {actionName}. Exception: {ex.Message}");

            // Capture a screenshot
            Screenshot screenshot = driver.GetScreenshot();
            string filePath = @"D:\Reports\SS\screenshot.png";
            screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);
            Console.WriteLine($"Screenshot saved to: {filePath}");
            Test.AddScreenCaptureFromPath(filePath);
        }

        public void HandleException(string actionName, Exception ex)
        {
            // Log the error message
            Test.Log(Status.Fail, $"Test failed during: {actionName}. Exception: {ex.Message}");

            try
            {
                // Capture the screenshot
                Screenshot screenshot = driver.GetScreenshot();
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                string filePath = @$"D:\Reports\screenshot_{timestamp}.png";

                // Save screenshot as a PNG file
                screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);
                Console.WriteLine($"Screenshot saved to: {filePath}");

                // Attach the screenshot to the report
                Test.AddScreenCaptureFromPath(filePath);
            }
            catch (Exception screenshotException)
            {
                // Log failure to capture/attach screenshot
                Test.Log(Status.Warning, "Failed to capture screenshot: " + screenshotException.Message);
            }


        }




        public void Swipe()
        {
            TouchAction act = new TouchAction(driver);
            act.LongPress(200, 180).Wait(5000).MoveTo(900, 180).Release().Perform();
            Thread.Sleep(3000);

        }

        public IWebElement ScrollToElementByText(string text)
        {
            return driver.FindElement(MobileBy.AndroidUIAutomator(
                $"new UiScrollable(new UiSelector().scrollable(true)).scrollIntoView(new UiSelector().text(\"{text}\"))"));
        }


        public void HandleCBanner(string context)
        {
            //**************Code to close c banner ***********
            try
            {
                Thread.Sleep(5000);
                var x = 641; //641 667
                var y = 843; //843 850

                touchAction.Tap(x, y).Perform();
                Thread.Sleep(2000);
                Console.WriteLine("Tap performed successfully at coordinates: (" + x + ", " + y + ")");
            }
            catch (Exception ex)
            {
                HandleException($"C Banner not Found on {context}", ex);

            }
        }

        //New method for live ads
        public void InterAdHandle()
        {
            // Thread.Sleep(12000);
            try
            {
                By handleAdButton = By.XPath(
            "//android.widget.Button | " +
            "//android.widget.TextView[@text=\"Close\"] |" +
            "//android.widget.ImageView[@content-desc='Ad closed'] | " +
            "//android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ']" +
            "//android.view.View[@resource-id=\"mys-content\"]/android.view.View[2]/android.widget.TextView" +
            "//android.widget.TextView[@text=\"CLOSE\"]"
            );

                // By closeButton = By.XPath("//android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ' ]");
                // By crossButton = By.XPath("//android.widget.Button | //android.widget.ImageView[@content-desc='Ad closed']");
                //    By handleAdButton = By.XPath("//android.widget.Button | //android.widget.ImageView[@content-desc='Ad closed'] | //android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ' ]");

                IWebElement adButton = null;

                // Check if any of the locators are present
                if (IsElementPresent(handleAdButton))
                {
                    adButton = driver.FindElement(handleAdButton);
                    if (adButton != null)
                    {
                        adButton.Click();
                    }
                    else
                    {
                        Console.WriteLine("No Interstitial Ad found");
                    }
                }
                else
                {
                    Console.WriteLine("No ad close button found");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No ad close button found");
            }
            catch (Exception ex)
            {
                HandleException("inter Ad", ex);
            }
        }

        private bool IsElementPresent(By locator)
        {
            try
            {
                return driver.FindElements(locator).Count > 0;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void LogTestFailure(Exception ex)
        {
            // Log the failure using Extent Reports
            Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            // Optionally log the stack trace for more details
            Test.Log(Status.Fail, $"Stack Trace: {ex.StackTrace}");

            // You can also add a screenshot or other debug info if needed
            // For example: AttachScreenshot();
        }

        public void ClickwithAdAndNavigateBack(IWebElement? element, string elementName)
        {
            try
            {
                element?.Click();
            }
            catch (Exception ex)
            {
                HandleException(elementName, ex);
            }
            try
            {
                InterAdHandle();
            }
            catch (Exception ex)
            {
                HandleException(elementName, ex);
            }
            try
            {
                driver?.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException(elementName, ex);
            }
        }

        public void ClickwithAd(IWebElement? element, string elementName)
        {
            try
            {
                element?.Click();
            }
            catch (Exception ex)
            {
                HandleException(elementName, ex);
            }

            try
            {
                InterAdHandle();
            }
            catch (Exception ex)
            {
                HandleException(elementName, ex);
            }


        }
        public void NavigateBack(string Action)

        {
            try
            {
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException(Action, ex);
            }
        }

        public void ElementClick(IWebElement? element, string elementName)
        {
            try
            {
                element?.Click();
            }
            catch (Exception ex)
            {
                HandleException(elementName, ex);
            }
        }

        public void ElementClickandNavigateBack1(IWebElement? element, string elementName)
        {
            try
            {
                element?.Click();
            }
            catch (Exception ex)
            {
                HandleException(elementName, ex);
            }
            try
            {
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException(elementName, ex);
            }

        }
        public WebDriverWait GetWebDriverWait(int seconds = 10)  //or int seconds
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
        }

        public void ElementClickandNavigateBack(IWebElement? element, string elementName)
        {
            bool isClicked = false;

            try
            {
                if (element != null)
                {
                    element.Click();
                    isClicked = true; // Set to true if the click is successful
                }
                else
                {
                    // Log and handle if the element is null (not found)
                    HandleException(elementName + " not found", new NoSuchElementException("Element not found"));
                    return; // Exit if element is not found
                }
            }
            catch (Exception ex)
            {
                // Log the exception and do not throw it to allow continued execution
                HandleException(elementName + " click failed", ex);
                return; // Exit if the click fails
            }

            if (isClicked)
            {
                try
                {
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    HandleException("Navigation Back from " + elementName, ex);
                    // Do not return here; allow the flow to continue
                }
            }
        }

        public IWebElement? FindElement(By by, string elementName)
        {
            try
            {
                return driver.FindElement(by); // Attempts to find the element
            }
            catch (Exception ex)
            {
                HandleException(elementName + " not found", ex); // Logs exception
                return null; // Returns null if the element is not found
            }
        }
        IWebElement Continue => driver.FindElementById("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/StartButton");
    }
}
