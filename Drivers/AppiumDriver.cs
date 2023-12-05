using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecFlow.Drivers
{
    internal class AppiumDriver
    {
        public AppiumDriver <AppiumWebElement> driver {  get; set; }

        public AndroidDriver<AppiumWebElement> InitializeAppium()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-5554");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, @"C:\Users\vuvan\Downloads\data\C#\AppiumSpecFlow\Android.SauceLabs.Mobile.Sample.app.2.7.1.apk");
             appiumOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppActivity, "com.swaglabsmobileapp.SplashActivity");
             appiumOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppPackage, "com.swaglabsmobileapp");

            var AppiumService = new AppiumServiceBuilder().WithIPAddress("127.0.0.1").UsingPort(4723).Build();

            AppiumService.Start();


            return new AndroidDriver<AppiumWebElement>(AppiumService, appiumOptions);        }
    }
}
