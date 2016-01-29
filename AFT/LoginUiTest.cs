using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AFT
{
    using NUnit.Framework;
    using OpenQA.Selenium.Chrome;

    // PageObjects pattern https://code.google.com/p/selenium/wiki/PageObjects

    public class LoginUiTest
    {
        [Test]
        public void IfEmailAddressIsNotValid_ShowValidationMessage()
        {
            using (var driver = new ChromeDriver())
            {
                var loginPage = new LoginPage(driver);
                loginPage.Open().SubmitButton().Click();
                Assert.True(loginPage.GetErrorMess().Displayed);
            }
        }

        [Test]
        public void IfEmailAddressIsInvalid_ShowValidationMessage()
        {
            var loginPage = new LoginPage(new ChromeDriver());
            loginPage.Open().SubmitButton().Click();
            Assert.IsTrue(String.CompareOrdinal(loginPage.ErrorMessage().Text, "Требуется поле Email.") == 0);
        }

        //[Test]
        //public void IfEmailAddressIsNotValid1_ShowValidationMessage()
        //{
        //    using (var driver = new ChromeDriver())
        //    {
        //        driver.Navigate().GoToUrl("http://localhost:49333/Account/Login");

        //        var loginErrorMessage1 = driver.FindElementsByXPath("//*[@id='loginForm']/form/div[1]/div/span/span");
        //        Assert.AreEqual(0, loginErrorMessage1.Count);

        //        driver.FindElementById("Email").SendKeys("abc@abc.abc");
        //        Thread.Sleep(300);
        //        driver.FindElementByXPath("//*[@id='loginForm']/form/div[4]/div/input").Click();
        //        Thread.Sleep(300);

        //        var loginErrorMessage = driver.FindElementByName("Invalid login attempt.");

        //        Assert.IsNotNull(loginErrorMessage);
        //    }
        //}
    }
}