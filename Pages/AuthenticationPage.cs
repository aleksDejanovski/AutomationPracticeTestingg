using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAutomation.Pages
{
    public class AuthenticationPage : BasePage
    {
        private readonly By txtEmail = By.Id("email");
        private readonly By txtPassword = By.Id("passwd");
        private readonly By btnSignIn = By.Id("SubmitLogin");
      
       
         


        public AuthenticationPage(IWebDriver driver) : base(driver)
        {
        }

        

        public bool IfUserIsOnAuthenticationPage(string pageName)
        {
            WaitUrlToContain(Driver, pageName.ToLower());
            return Driver.FindElement(By.XPath($"//h1[text()='{pageName}']")).Enabled ;
          
        }

        public void SubmitLoginForm(string username, string password)
        {
            WaitElementToAppear(Driver, txtEmail);
            Driver.FindElement(txtEmail).Clear();
            Driver.FindElement(txtEmail).SendKeys(username);
            Driver.FindElement(txtPassword).Clear(); 
            Driver.FindElement(txtPassword).SendKeys(password);
            Driver.FindElement(btnSignIn).Click();
        }



        
            
    }
}
