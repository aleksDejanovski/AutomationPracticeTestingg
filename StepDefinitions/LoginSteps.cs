using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAutomation.Pages;
using Xunit;
using AutomationPractice.Pages;

namespace AutomationPractice.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        public WebDriverWait Wait { get; private set; }
        DashBoardPage DashBoardPage => new DashBoardPage(Driver);

        AuthenticationPage AuthenticationPage => new AuthenticationPage(Driver);
        MyAccountPage MyAccountPage => new MyAccountPage(Driver);


        public IWebDriver Driver { get; private set; }
       

        public LoginSteps(IWebDriver Driver)
        {

            this.Driver = Driver;
        }

        [Given(@"The user is navigated to the ""([^""]*)""")]
        public void GivenTheUserIsNavigatedToThe(string url)
        {
             DashBoardPage.NavigateToUrl(url);
        }

        [When(@"The user clicks the Sign in button")]
        public void WhenTheUserClicksTheSignInButton()
        {
            DashBoardPage.ClickLoginButton();
        }

        [Then(@"The ""([^""]*)"" page appears")]
        public void ThenThePageAppears(string pageName)
        {
            Assert.True(AuthenticationPage.IfUserIsOnAuthenticationPage(pageName));
        }

        [When(@"The user enters valid username ""([^""]*)"", valid password as ""([^""]*)"" and clicks SignIn button")]
        public void WhenTheUserEntersValidUsernameValidPasswordAsAndClicksSignInButton(string username, string password)
        {
            AuthenticationPage.SubmitLoginForm(username, password);
        }

        [Then(@"The user shoud be successfully signed in")]
        public void ThenTheUserShoudBeSuccessfullySignedIn()
        {
            Assert.True(MyAccountPage.IfUserIsOnMyAccountPage());
        }



    }
}
