using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AFT
{
    public class LoginPage
    {
        public ChromeDriver _driver;

        public LoginPage(ChromeDriver driver)
        {
            _driver = driver;
        }

        ~LoginPage()
        {
            _driver.Dispose();
        }

        public LoginPage Open()
        {
            _driver.Navigate().GoToUrl("http://localhost:49333/Account/Login");
            return this;
        }

        public IWebElement GetErrorMess()
        {
            return _driver.FindElementByXPath("//*[@id='loginForm']/form/div[1]/div/span/span");
        }

        public IWebElement SubmitButton()
        {
            return _driver.FindElementByXPath("//*[@id='loginForm']/form/div[4]/div/input");
        }

        public IWebElement ErrorMessage()
        {
            return _driver.FindElementByCssSelector(".text-danger.field-validation-error span");
        }
    }
}