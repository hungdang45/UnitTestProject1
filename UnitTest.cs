using System;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Winium;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest : LoginTest
    {
        ReadOnlyCollection<IWebElement> textBox = driver.FindElementsById("textBox");
        ReadOnlyCollection<IWebElement> btnLogin = driver.FindElementsById("btnLogin");

        //GIAO HÀNG
        //[1] Verify order cancelled by account "quanly" 
        [TestMethod]
        public void CancelOrder()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton3").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 60, 154).Click().Perform();
            driver.FindElementById("lblCancel").Click();
            driver.FindElementById("textBox").Click();
            driver.FindElementById("textBox").SendKeys("quanly");
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 793, 472).Click().SendKeys("passio2019").Perform();
            driver.FindElementById("btnPositive").Click();
            driver.FindElementById("btnPositive").Click();
        }

        //[2] Verify order successful by money when user carried away 
        [TestMethod]
        public void OrderByMoneyI()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton3").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 60, 154).Click().Perform();
            driver.FindElementById("lblPayment").Click();
            driver.FindElementById("btnAddPayment").Click();
            driver.FindElementById("btnCustomerInfo").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 420, 369).Click().SendKeys("abc").Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 630, 369).Click().SendKeys("111").Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 847, 369).Click().SendKeys("xyz").Perform();
            driver.FindElementById("btnFinish").Click();
        }

        //[3] Verify order successful by money when user carried away (cont)
        [TestMethod]
        public void OrderByMoneyII()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton3").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 60, 154).Click().Perform();
            driver.FindElementById("lblPayment").Click();
            driver.FindElementById("btn100").Click();
            driver.FindElementById("btnAddPayment").Click();
            driver.FindElementById("btnCustomerInfo").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 420, 369).Click().SendKeys("abc").Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 630, 369).Click().SendKeys("111").Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 847, 369).Click().SendKeys("xyz").Perform();
            driver.FindElementById("btnFinish").Click();
        }

        //[4] Verify order successful by money and use voucher when user carried away
        [TestMethod]
        public void OrderByMoneyAndUseVoucher()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton3").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 60, 154).Click().Perform();
            driver.FindElementById("lblPayment").Click();
            driver.FindElementById("btnCustomerInfo").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 420, 369).Click().SendKeys("abc").Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 630, 369).Click().SendKeys("111").Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 847, 369).Click().SendKeys("xyz").Perform();
            driver.FindElementById("btnPromotionInfo").Click();
            driver.FindElementById("btnStore1").Click();
            driver.FindElementById("btnAddPayment").Click();
            driver.FindElementById("btnFinish").Click();
            driver.FindElementById("btnViewOrder").Click();
            driver.FindElementById("btnViewReport").Click();
            driver.FindElementById("btnViewReport").Click();
        }

        //[5] Verify order successful by membership card and use voucher when user carried away
        [TestMethod]
        public void OrderByMembershipAndUseVoucher()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton3").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 60, 154).Click().Perform();
            driver.FindElementById("lblPayment").Click();
            driver.FindElementById("btnCustomerInfo").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 424, 300).Click().SendKeys("0009388109").Perform();
            driver.FindElementById("btnCheck").Click();
            Thread.Sleep(5000);
            driver.FindElementById("btnCustomerInfo").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 630, 369).Click().SendKeys("111").Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 847, 369).Click().SendKeys("xyz").Perform();
            driver.FindElementById("btnPromotionInfo").Click();
            driver.FindElementById("btnStore1").Click();
            driver.FindElementById("btnAddPayment").Click();
            driver.FindElementById("btnFinish").Click();
            driver.FindElementById("btnViewOrder").Click();
            driver.FindElementById("btnViewReport").Click();
            driver.FindElementById("btnViewReport").Click();
        }

        //[6] Verify order successful by membership card when user carried away
        [TestMethod]
        public void OrderByMembership()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton3").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 60, 154).Click().Perform();
            driver.FindElementById("lblPayment").Click();
            driver.FindElementById("btnCustomerInfo").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 424, 300).Click().SendKeys("0009388109").Perform();
            driver.FindElementById("btnCheck").Click();
            Thread.Sleep(5000);
            driver.FindElementById("btnCustomerInfo").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 630, 369).Click().SendKeys("111").Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 847, 369).Click().SendKeys("xyz").Perform();
            driver.FindElementById("btnPaymentInfo").Click();
            driver.FindElementById("btnAddPayment").Click();
            driver.FindElementById("btnFinish").Click();
            driver.FindElementById("btnViewOrder").Click();
            driver.FindElementById("btnViewReport").Click();
            driver.FindElementById("btnViewReport").Click();
        }
        
        //Free style of test
        //[7] Input id membership card to sign in to payment the bill
        [TestMethod]
        public void VerifyNoticeWhenInputMembershipCardWrong()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton3").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 60, 154).Click().Perform();
            driver.FindElementById("lblPayment").Click();
            driver.FindElementById("btnCustomerInfo").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 424, 300).Click().SendKeys("...abc123!@#").Perform();
            driver.FindElementById("btnCheck").Click();
            Thread.Sleep(5000);
            driver.FindElementById("btnCustomerInfo").Click();

        }

        //[8] Input id membership card to sign in to payment the bill (cont)
        [TestMethod]
        public void VerifyWhenInputMembershipCard()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton3").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 60, 154).Click().Perform();
            driver.FindElementById("lblPayment").Click();
            driver.FindElementById("btnCustomerInfo").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 424, 300).Click().SendKeys("0009388109").Perform(); 
            driver.FindElementById("btnCheck").Click();
            Thread.Sleep(5000);
            driver.FindElementById("btnCustomerInfo").Click();
            driver.FindElementById("btnClearMembershipCard").Click();
        }

        //[9] Verify the function of the button promotion in pay the bill
        [TestMethod]
        public void VerifyAllButtonPromotion()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton3").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 60, 154).Click().Perform();
            driver.FindElementById("lblPayment").Click();
            driver.FindElementById("btnCustomerInfo").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 420, 369).Click().SendKeys("abc").Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 630, 369).Click().SendKeys("111").Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 847, 369).Click().SendKeys("xyz").Perform();
            driver.FindElementById("btnPromotionInfo").Click();
            driver.FindElementById("btnStore1").Click();
            driver.FindElementById("btnPromotionInfo").Click();
            driver.FindElementById("btnStore2").Click();
            driver.FindElementById("btnPromotionInfo").Click();
            driver.FindElementById("btnCommon2").Click();
            driver.FindElementById("btnPromotionInfo").Click();
            driver.FindElementById("btnCommon6").Click();
            driver.FindElementById("btnPromotionInfo").Click();
            driver.FindElementById("btnSpecial3").Click();
            driver.FindElementById("btnPromotionInfo").Click();
            driver.FindElementById("btnSpecial10").Click();
            driver.FindElementById("btnAddPayment").Click();
            driver.FindElementById("btnFinish").Click();
        }

        //[10] Verify drinks which have a event for free
        [TestMethod]
        public void VerifyFreeDrinks()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElementById("ptbLogo"), 280, 120).Click().Perform();
            driver.FindElementById("flexButton3").Click();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 568, 798).Click().Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 568, 155).Click().Perform();
            action.MoveToElement(driver.FindElementById("SaleScreen3"), 596, 205).Click().Perform();
        }

        //[11] Verify the report of the bill
        [TestMethod]
        public void VerifyButtonInReport()
        {
            driver.FindElementById("btnViewOrder").Click();
            Thread.Sleep(2000);
            driver.FindElementById("btnViewReport").Click();
            Thread.Sleep(2000);
            driver.FindElementById("btnViewReport").Click();
            Thread.Sleep(2000);
            driver.FindElementById("lblDown").Click();
            Thread.Sleep(2000);
            driver.FindElementById("lblUp").Click();
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