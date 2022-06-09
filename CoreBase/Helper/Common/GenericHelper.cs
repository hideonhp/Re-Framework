using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using Re_Framework.CoreBase.Helper.Element;
using Re_Framework.CoreBase.Helper.Enum;
using Re_Framework.CoreBase.Settings;
using SeleniumExtras.WaitHelpers;

namespace Re_Framework.CoreBase.Helper.Common
{
    public class GenericHelper
    {
        private static readonly ILog Logger = Log4NetHelper.GetXmlLogger(typeof(GenericHelper));
        private static Func<IWebDriver, bool> WaitForWebElementFunc(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count == 1)
                    return true;
                Logger.Info(" Waiting for Element : " + locator);
                return false;
            });
        }

        private static Func<IWebDriver, IList<IWebElement>> GetAllElements(By locator)
        {
            return ((x) =>
            {
                return x.FindElements(locator);
            });
        }

        private static Func<IWebDriver, IWebElement> WaitForWebElementInPageFunc(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count == 1)
                    return x.FindElement(locator);
                return null;
            });
        }

        public static void SelecFromAutoSuggest(By autoSuggesLocator, string initialStr, string strToSelect,
            By autoSuggestistLocator)
        {
            var autoSuggest = ObjectRepository.Driver.FindElement(autoSuggesLocator);
            autoSuggest.SendKeys(initialStr);
            Thread.Sleep(1000);

            var wait = GenericHelper.GetWebdriverWait(TimeSpan.FromSeconds(40));
            var elements = wait.Until(GetAllElements(autoSuggestistLocator));
            var select = elements.First((x => x.Text.Equals(strToSelect, StringComparison.OrdinalIgnoreCase)));
            select.Click();
            Thread.Sleep(1000);
        }

        public static WebDriverWait GetWebdriverWait(TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(1));
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, timeout)
            {
                PollingInterval = TimeSpan.FromMilliseconds(500),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            Logger.Info(" Wait Object Created ");
            return wait;
        }
        public static bool IsElemetPresent(string locator, int type)
        {
            switch (type)
            {
                case 0:
                    {
                        try
                        {
                            Logger.Info(" Checking for the element " + locator);
                            return ObjectRepository.Driver.FindElement(By.Id(locator)).Displayed;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }

                case 1:
                    {
                        try
                        {
                            Logger.Info(" Checking for the element " + locator);
                            return ObjectRepository.Driver.FindElement(By.Name(locator)).Displayed;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }

                case 2:
                    {
                        try
                        {
                            Logger.Info(" Checking for the element " + locator);
                            return ObjectRepository.Driver.FindElement(By.TagName(locator)).Displayed;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }

                case 3:
                    {
                        try
                        {
                            Logger.Info(" Checking for the element " + locator);
                            return ObjectRepository.Driver.FindElement(By.ClassName(locator)).Displayed;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                case 4:
                    {
                        try
                        {
                            Logger.Info(" Checking for the element " + locator);
                            return ObjectRepository.Driver.FindElement(By.CssSelector(locator)).Displayed;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                case 5:
                    {
                        try
                        {
                            Logger.Info(" Checking for the element " + locator);
                            return ObjectRepository.Driver.FindElement(By.LinkText(locator)).Displayed;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                case 6:
                    {
                        try
                        {
                            Logger.Info(" Checking for the element " + locator);
                            return ObjectRepository.Driver.FindElement(By.PartialLinkText(locator)).Displayed;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                case 7:
                    {
                        try
                        {
                            Logger.Info(" Checking for the element " + locator);
                            return ObjectRepository.Driver.FindElement(By.XPath(locator)).Displayed;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                default:
                    {
                        throw new ArgumentException("Not Found Type Method for Locator" + locator.ToString());
                    }
            }
        }

        public static IWebElement GetElement(String locator, int type)
        {
            switch (type)
            {
                case 0:
                    return ObjectRepository.Driver.FindElement(By.Id(locator));
                case 1:
                    return ObjectRepository.Driver.FindElement(By.Name(locator));
                case 2:
                    return ObjectRepository.Driver.FindElement(By.TagName(locator));
                case 3:
                    return ObjectRepository.Driver.FindElement(By.ClassName(locator));
                case 4:
                    return ObjectRepository.Driver.FindElement(By.CssSelector(locator));
                case 5:
                    return ObjectRepository.Driver.FindElement(By.LinkText(locator));
                case 6:
                    return ObjectRepository.Driver.FindElement(By.PartialLinkText(locator));
                case 7:
                    return ObjectRepository.Driver.FindElement(By.XPath(locator));
                default:
                    throw new ArgumentException("Not Found Type Method for Locator" + locator.ToString());
            }
        }

        public static void TakeScreenShot(string filename = "Screen")
        {
            var screen = ObjectRepository.Driver.TakeScreenshot();
            if (filename.Equals("Screen"))
            {
                filename = filename + DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") + ".jpeg";
                screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
                Logger.Info(" ScreenShot Taken : " + filename);
                return;
            }
            screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg); Logger.Info(" ScreenShot Taken : " + filename);
        }

        public static bool WaitForWebElement(By locator, TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(1));
            Logger.Info(" Setting the Explicit wait to 1 sec ");
            var wait = GetWebdriverWait(timeout);
            var flag = wait.Until(WaitForWebElementFunc(locator));
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut()));
            Logger.Info(" Setting the Explicit wait Configured value ");
            return flag;
        }

        public static IWebElement WaitForWebElementVisisble(By locator, TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(1));
            Logger.Info(" Setting the Explicit wait to 1 sec ");
            var wait = GetWebdriverWait(timeout);
            var flag = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut()));
            Logger.Info(" Setting the Explicit wait Configured value ");
            return flag;
        }

        public static IWebElement WaitForWebElementInPage(By locator, TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(1));
            Logger.Info(" Setting the Explicit wait to 1 sec ");
            var wait = GetWebdriverWait(timeout);
            var flag = wait.Until(WaitForWebElementInPageFunc(locator));
            Logger.Info(" Setting the Explicit wait Configured value ");
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut()));
            return flag;
        }

        public static IWebElement Wait(Func<IWebDriver, IWebElement> conditions, TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(1));
            Logger.Info(" Setting the Explicit wait to 1 sec ");
            var wait = GetWebdriverWait(timeout);
            var flag = wait.Until(conditions);
            Logger.Info(" Setting the Explicit wait Configured value ");
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut()));
            return flag;
        }
    }
}
