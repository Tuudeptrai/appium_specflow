using AppiumSpecFlow.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumSpecFlow.Hooks
{
    [Binding]
     class InitializeHook
    {
        private ScenarioContext _scenarioContext;

        public InitializeHook(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [BeforeScenario]
        public void Initialize()
        {
            AppiumDriver appiumDriver = new AppiumDriver();
            //context injection
            _scenarioContext.Set(appiumDriver.InitializeAppium());
        }
    }
}
