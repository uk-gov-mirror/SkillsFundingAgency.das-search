﻿namespace Sfa.Das.WebTest.Infrastructure.Selenium
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.PhantomJS;
    using OpenQA.Selenium.Remote;

    using Sfa.Das.WebTest.Infrastructure.Settings;

    using TechTalk.SpecFlow;

    public class WebDriverFactory : IWebDriverFactory
    {
        private IBrowserSettings _settings;

        public WebDriverFactory(IBrowserSettings settings)
        {
            _settings = settings;
        }

        public IWebDriver CreateBrowserStackDriver()
        {
            var capabilities =
                FindBrowserCapability()
                    .SafeSet("os", _settings.OS)
                    .SafeSet("os_version", _settings.OSVersion)
                    .SafeSet("browser_version", _settings.BrowserVersion)
                    .SafeSet("browserstack.debug", "true")
                    .SafeSet("browserstack.user", _settings.BrowserStackUser)
                    .SafeSet("browserstack.key", _settings.BrowserStackKey)
                    .SafeSet("project", _settings.Project)
                    .SafeSet("device", _settings.Device)
                    .SafeSet("resolution", _settings.Resolution)
                    .SafeSet("build", _settings.Build);

            capabilities.SetCapability("name", GenerateTestName());

            Console.WriteLine($"##### Driver: Browserstack - {_settings.OS} {_settings.OSVersion} - {_settings.Device ?? _settings.Browser} {_settings.BrowserVersion}");
            return new RemoteWebDriver(new Uri(_settings.RemoteUrl), capabilities);
        }

        public IWebDriver CreatePhantomJsDriver()
        {
            var driverService = PhantomJSDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            Console.WriteLine($"##### Driver: PhantomJs");
            var driver = new PhantomJSDriver(driverService);
            driver.Manage().Window.Maximize();
            return driver;
        }

        private DesiredCapabilities FindBrowserCapability()
        {
            switch (_settings.Browser.ToLower())
            {
                case "internet explorer":
                    return DesiredCapabilities.InternetExplorer();
                case "chrome":
                    return DesiredCapabilities.Chrome();
                case "firefox":
                    return DesiredCapabilities.Firefox();
                case "android":
                    return DesiredCapabilities.Android();
                case "edge":
                    return DesiredCapabilities.Edge();
                case "safari":
                    return DesiredCapabilities.Safari();
                case "iphone":
                    return DesiredCapabilities.IPhone();
                case "ipad":
                    return DesiredCapabilities.IPad();
            }

            throw new WebDriverException($"Browser Type '{_settings.Browser}' is not supported as a remote driver.");
        }

        private string GenerateTestName()
        {
            var arr = TestContext.CurrentContext.Test.Name.Replace(")", "").Replace(",null", "").Split('(');
            if (arr.Length > 1)
            {
                return FeatureContext.Current.FeatureInfo.Title + " - " + SplitCamelCase(arr[0]) + " " + arr[1];
            }

            return FeatureContext.Current.FeatureInfo.Title + " - " + String.Join(" ", arr.Select(SplitCamelCase));
        }

        private string SplitCamelCase(string input)
        {
            return Regex.Replace(input, "(\\B[A-Z])", " $1");
        }
    }
}