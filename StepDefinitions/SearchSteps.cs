using AutomationPractice.Pages;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAutomation.Pages;

namespace AutomationPractice.StepDefinitions
{
    [Binding]
    public class SearchSteps
    {


        DashBoardPage DashBoardPage => new DashBoardPage(Driver);

        public IWebDriver Driver { get; private set; }


        public SearchSteps(IWebDriver Driver)
        {

            this.Driver = Driver;
        }



        [When(@"The user enter ""([^""]*)"" and clicks on the search button")]
        public void WhenTheUserEnterAndClicksOnTheSearchButton(string item)
        {
            DashBoardPage.SearchForItem(item);
        }


        [Then(@"The search result should contain the searched item ""([^""]*)""")]
        public void ThenTheSearchResultShouldContainTheSearchedItem(string item)
        {
            DashBoardPage.IfSearchResultsAreThere(item);
        }

        [When(@"The user clicks the add to card button")]
        public void WhenTheUserClicksTheAddToCardButton()
        {
            //DashBoardPage.ClickAddToCard();
        }


    }
}
