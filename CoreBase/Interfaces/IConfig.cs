﻿using Re_Framework.CoreBase.Configuration;

namespace Re_Framework.CoreBase.Interfaces
{
    public interface IConfig
    {
        BrowserType? GetBrowser();
        string GetUsername();
        string GetPassword();
        string GetWebsite();
        string GetWebsiteAPI();
        string GetWebsiteAPIReqRes();
        int GetPageLoadTimeOut();
        int GetElementLoadTimeOut();

    }
}
