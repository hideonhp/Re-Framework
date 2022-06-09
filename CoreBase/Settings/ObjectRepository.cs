using OpenQA.Selenium;
using Re_Framework.CoreBase.Interfaces;
using Re_Framework.CoreBase.PageObjects;

namespace Re_Framework.CoreBase.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
    }
}
