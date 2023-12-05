using System;
using TechTalk.SpecFlow;

namespace AppiumSpecFlow.StepDefinitions
{
    [Binding]
    public class ProductScenariosStepDefinitions
    {
       

        [Then(@"the product is listed with title ""([^""]*)"" and price ""([^""]*)""")]
        public void ThenTheProductIsListedWithTitleAndPrice(string p0, string p1)
        {
            
        }

        [When(@"I click product title ""([^""]*)""")]
        public void WhenIClickProductTitle(string p0)
        {
            
        }

        [Then(@"I should be on product details page with title ""([^""]*)"", price ""([^""]*)"" and description ""([^""]*)""")]
        public void ThenIShouldBeOnProductDetailsPageWithTitlePriceAndDescription(string p0, string p1, string p2)
        {
            
        }
    }
}
