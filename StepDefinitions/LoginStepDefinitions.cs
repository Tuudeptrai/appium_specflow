using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using TechTalk.SpecFlow;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.IO;

namespace AppiumSpecFlow.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public LoginStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"I enter username as ""([^""]*)""")]
        public void WhenIEnterUsernameAs(string username)
        {
            Thread.Sleep(4000);

            _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementByAccessibilityId("test-Username").SendKeys(username);
        }

        [When(@"I enter password as ""([^""]*)""")]
        public void WhenIEnterPasswordAs(string password)
        {
            _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementByAccessibilityId("test-Password").SendKeys(password);
        }

        [When(@"I login")]
        public void WhenILogin()
        {
            _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementByAccessibilityId("test-LOGIN").Click();
        }

        [Then(@"I should see Products page with title ""([^""]*)""")]
        public void ThenIShouldSeeProductsPageWithTitle(string expectedTitle)
        {
            Thread.Sleep(4000);
            string xpath = "//android.view.ViewGroup[@content-desc=\"test-Cart drop zone\"]/android.view.ViewGroup/android.widget.TextView";
          Assert.AreEqual(expectedTitle, _scenarioContext.Get<AndroidDriver<AppiumWebElement>>().FindElementByXPath(xpath).Text);
        }
    }

}
