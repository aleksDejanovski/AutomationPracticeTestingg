using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAutomation.Pages;

namespace AutomationPractice.Pages
{
    public class MyAccountPage : BasePage
    {
        private readonly By lblMyAccount = By.XPath("//h1[text()='My account']");
        private readonly string myAccountUrl = "controller=my-account";

        public MyAccountPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IfUserIsOnMyAccountPage()
        {
            WaitUrlToContain(Driver, myAccountUrl);
            return Driver.FindElement(lblMyAccount).Enabled;
        }

    }
}
