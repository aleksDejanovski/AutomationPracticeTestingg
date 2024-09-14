using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAutomation.Pages
{
    public class DashBoardPage : BasePage
    {

        private readonly By btnLogin = By.ClassName("login");
        private readonly By txtSearchField = By.Id("search_query_top");
        private readonly By btnSearch = By.CssSelector("button[name='submit_search']");
        private readonly By lblSearchResults = By.CssSelector(".page-heading.product-listing");
        private readonly string txtSubmitSearch = "submit_search";
        private readonly By btnAddToCard = By.CssSelector(".button-container");




        public DashBoardPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateToUrl (string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void ClickLoginButton()
        {
            Driver.FindElement(btnLogin).Click();
        }

        public void SearchForItem(string item)
        {
            Driver.FindElement(txtSearchField).Clear();
            Driver.FindElement(txtSearchField).SendKeys(item);
            Driver.FindElement(btnSearch).Click();

        }

        public void IfSearchResultsAreThere(string item)
        {
            WaitUrlToContain(Driver, txtSubmitSearch);
            Driver.FindElement(lblSearchResults);
             Driver.FindElement(By.CssSelector($"a[title='{item}']"));
        }

        public void ClickAddToCard()
        {
            Driver.FindElement(btnAddToCard).Click();   
        }
       







    }
}
