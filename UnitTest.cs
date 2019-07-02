using System;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Winium;
using System.Threading;
using System.Runtime.InteropServices;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest : LoginTest
    {
        ReadOnlyCollection<IWebElement> textBox = driver.FindElementsById("textBox");
        Actions action = new Actions(driver);
        [TestMethod]
        public void VerifyUserCancelOrder()
        {
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton1").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 95, 208).Click().Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 1745, 123).Click().Perform();
            driver.FindElementById("btnCancel").Click();
            driver.FindElementById("lblCancel").Click();
        }

        [TestMethod]
        public void VerifyChooseSizeSuccessful()
        {
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton1").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 95, 208).Click().Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 1745, 123).Click().Perform();
            driver.FindElementById("btnAttribute").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 1382, 347).Click().Perform();
            driver.FindElementById("btnClose").Click();
        }

        [TestMethod]
        public void VerifyChooseQuantitySuccessful()
        {
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton1").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 95, 208).Click().Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 1745, 123).Click().Perform();
            driver.FindElementById("btn0").Click();
            driver.FindElementById("btnClose").Click();
        }

        [TestMethod]
        public void VerifyChooseQuantitySuccessfulByPlusOrMinus()
        {
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton1").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 95, 208).DoubleClick().Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 37, 210).Click().Perform();
        }

        [TestMethod]
        public void VerifyChooseQuantityOrderTheDrinkSizeL()
        {
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton1").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 95, 208).Click().Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 1745, 123).Click().Perform();
            driver.FindElementById("btnAttribute").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 1382, 347).Click().Perform();
            driver.FindElementById("btnClone").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 95, 208).DoubleClick().Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 37, 210).Click().Perform();
        }

        [TestMethod]
        public void VerifyChooseProperties()
        {
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton1").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 95, 208).Click().Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 1745, 123).Click().Perform();
            driver.FindElementById("btnAttribute").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 1382, 347).Click().Perform();
            driver.FindElementById("btnExtra1").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 1171, 344).Click().Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 1166, 485).DoubleClick().Perform();
            driver.FindElementById("btnClose").Click();
        }

        [TestMethod]
        public void VerifyPayment()
        {
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton1").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 95, 208).DoubleClick().Perform();
            driver.FindElementById("lblPayment").Click();
            driver.FindElementById("btnCustomerInfo").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 577, 390).Click().SendKeys("0009388109").Perform();
            driver.FindElementById("btnCheck").Click();
            driver.FindElementById("btnPromotionInfo").Click();
            driver.FindElementById("btnStore2").Click();
            driver.FindElementById("btnPaymentInfo").Click();
            driver.FindElementById("btnAddPayment").Click();
            driver.FindElementById("btnTab1").Click();
            driver.FindElementById("btn100").Click();
            driver.FindElementById("btnAddPayment").Click();
            driver.FindElementById("btnFinish").Click();
        }
        [TestMethod]
        public void VerifyPaymentDeletePromotion()
        {
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton1").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 95, 208).DoubleClick().Perform();
            driver.FindElementById("lblPayment").Click();
            driver.FindElementById("btnCustomerInfo").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 577, 390).Click().SendKeys("0009388109").Perform();
            driver.FindElementById("btnCheck").Click();
            driver.FindElementById("btnPromotionInfo").Click();
            driver.FindElementById("btnStore2").Click();
            driver.FindElementById("btnPaymentInfo").Click();
            driver.FindElementById("btnAddPayment").Click();
            driver.FindElementById("btnTab1").Click();
            driver.FindElementById("btn100").Click();
            driver.FindElementById("btnAddPayment").Click();
            driver.FindElementById("btnPromotionInfo").Click();
            driver.FindElementById("lblCancel").Click();
            driver.FindElementById("btnPaymentInfo").Click();
            driver.FindElementById("btnAddPayment").Click();

        }
        [TestMethod]
        public void VerifyCheckPayment()
        {
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton1").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 95, 208).DoubleClick().Perform();
            driver.FindElementById("lblPayment").Click();
            driver.FindElementById("btn100").Click();
            driver.FindElementById("btnAddPayment").Click();
            driver.FindElementById("btnFinish").Click();
            action.MoveToElement(driver.FindElementById("ptbLogo"), 1675, 1032).Click().Perform();
            action.MoveToElement(driver.FindElementById("ptbLogo"), 397, 96).Click().Perform();
            action.MoveToElement(driver.FindElementById("ptbLogo"), 879, 615).Click().Perform();
        }


        [ClassInitialize]
        public static void loadForm(TestContext context)
        {
            LoadApp(context);
            //IWebElement txtUsername = driver.FindElementById("txtUsername");
            //IWebElement txtPassword = driver.FindElementById("txtPassword");
            //Assert.IsNotNull(txtUsername);
        }

    }
}
