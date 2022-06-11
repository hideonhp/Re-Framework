using System.Collections.ObjectModel;
using System.Threading;
using log4net;
using OpenQA.Selenium;
using Re_Framework.CoreBase.Settings;

namespace Re_Framework.CoreBase.Helper.Common
{
    public class BrowserHelper
    {
        protected static readonly ILog Logger = Log4NetHelper.GetXmlLogger(typeof(BrowserHelper));
        public static void BrowserMaximize()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
            Logger.Info(" Browser Maximize ");
        }

        public static void BrowserMinimize()
        {
            ObjectRepository.Driver.Manage().Window.Minimize();
            Logger.Info(" Browser Minimize ");
        }

        public static void BrowserFullScreen()
        {
            ObjectRepository.Driver.Manage().Window.FullScreen();
            Logger.Info(" Browser FullScreen ");
        }

        public static void GoToUrl(string targetUrl)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(targetUrl);
            Logger.Info(" Browser FullScreen ");
        }

        public static void GoBack()
        {
            ObjectRepository.Driver.Navigate().Back();

        }

        public static void Forward()
        {
            ObjectRepository.Driver.Navigate().Forward();
        }

        public static void RefreshPage()
        {
            ObjectRepository.Driver.Navigate().Refresh();
        }

        public static void SwitchToWindow(int index = 0)
        {
            Thread.Sleep(1000);
            ReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;

            if ((windows.Count - 1) < index)
            {
                throw new NoSuchWindowException("Invalid Browser Window Index" + index);
            }
            ObjectRepository.Driver.SwitchTo().Window(windows[index]);
            Thread.Sleep(1000);
            BrowserMaximize();

        }

        public static void SwitchToParent()
        {
            var windowids = ObjectRepository.Driver.WindowHandles;


            for (int i = windowids.Count - 1; i > 0;)
            {
                ObjectRepository.Driver.Close();
                i = i - 1;
                Thread.Sleep(2000);
                ObjectRepository.Driver.SwitchTo().Window(windowids[i]);
            }
            ObjectRepository.Driver.SwitchTo().Window(windowids[0]);

        }

        public static void SwitchToFrame(By locatot)
        {
            ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(locatot));
        }

        public static void NavigateToUrl(string Url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(Url);
            Logger.Info(" Navigate To Page " + Url);
        }
    }
}
