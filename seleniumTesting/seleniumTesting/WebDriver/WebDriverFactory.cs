using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace seleniumTesting
{
	public class WebDriverFactory
	{
		/* Browsers constants */
		public const String CHROME = "chrome";
		public const String FIREFOX = "firefox";
		public const String SAFARI = "safari";
		public const String INTERNET_EXPLORER = "ie";

		/* Platform constants */
		public const String MAC = "mac";
		public const String LINUX = "linux";
		public const String WINDOWS = "windows";

		public WebDriverFactory()
		{
		}

		public static IWebDriver getInstance(String gridHubUrl, Browser browser, String username, String password)
		{
			IWebDriver webDriver = null;

			DesiredCapabilities capability = new DesiredCapabilities();

		}
	}
}
