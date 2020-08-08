using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DemoSelenium
{

    public class TimeConst
    {
        public const int SmallTime = 500;
        public const int LongTime = 5000;

    }


    public class TestCaseBase
    {
        private ChromeDriver driver;

        protected void SleepSmall()
        {
            Thread.Sleep(TimeConst.SmallTime);
        }

        public virtual void Init()
        {
            driver = new ChromeDriver();
        }

        protected void Open(string url)
        {
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        protected void SleepLong()
        {
            Thread.Sleep(TimeConst.LongTime);
        }

        protected void SendText(string xpath, string text)
        {
            driver.FindElementByXPath(xpath).SendKeys(text);
            SleepSmall();
        }

        protected void SendTextByName(string xpath, string text)
        {
            driver.FindElementByXPath(xpath).SendKeys(text);
            SleepSmall();
        }

        protected void Click(string xpath)
        {
            driver.FindElementByXPath(xpath).Click();
            SleepLong();
        }

        public virtual void CleanUp()
        {
            driver.Quit();
        }

        protected bool IsElementExisted(string xPath)
        {
            try
            {
                var text = driver.FindElementByXPath(xPath);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string XpartData(int data)
        {
            return "//div[@class='kt-widget6__item'][2]//span[contains(@class,'kt-font-dark')] [contains(text(),'" + data + "')]";
        }
    }


    [TestFixture]
    public class TestCase1 : TestCaseBase
    {


        [SetUp]
        public override void Init()
        {
            // Hàm này nó sẽ chạy đầu tiên, hiểu đơn giản là nó dùng để thiết lập 1 cái gì đó trước khi nội dung testcase được chạy
            // Nó dựa vào cái Attribute tên là Setup ở bên trên đầu hàm đó
            // ok?ok
            // tương tự với hàm Run có cái attribute là Test thì đó được coi là thân của testcase
            // và teardown là hàm sẽ chạy sau khi testcase chạy xong
            // cái này nó giống finaly trong catch, nó luôn luôn chạy dù cái Testcase failed hay passed

            base.Init();
            base.Open("http://192.168.68.5:1169/Account/Login?ReturnUrl=%2FESM%2FDashboard");

            // Precondition
        }

        [Test]
        public void Run()
        {
          
            //var input = driver.FindElementByXPath("//input[@name='usernameOrEmailAddress']");
            //input.SendKeys("genco1");
            //input = driver.FindElementByXPath("//input[@name='password']");
            //input.SendKeys("genco1");
            //input.SendKeys(Keys.Enter);

            #region Login
            //driver.FindElementByName("usernameOrEmailAddress").SendKeys("genco1");

            base.SendTextByName("//input[@name='usernameOrEmailAddress']", "genco1");
            base.SendTextByName("//input[@name='password']", "genco1");
            base.Click("//button[@id='kt_login_signin_submit']");

            //driver.FindElementByName("password").SendKeys("genco1");
            //driver.FindElementById("kt_login_signin_submit").Click();
            #endregion

            #region SelectDate
            base.Click("//input[@id='dateSelect']");
            base.Click("//th[@class='prev']");
            base.Click("//td[@data-day='27/07/2020']");
            //for (int i = 0; i < 10; i++)
            //{
            //    selectInputDate.SendKeys(Keys.Backspace);
            //    selectInputDate.SendKeys(Keys.Delete);
            //    Thread.Sleep(20);
            //}

            //selectInputDate.SendKeys("18/04/2020");
            //Thread.Sleep(500);
            //selectInputDate.SendKeys(Keys.Enter);
            #endregion


            bool actual = base.IsElementExisted(base.XpartData(800));

            // Precondition
            // Login

            // actual = get text ở trên menu
            // expected = "genco1" = account.username

            // if(actual == expected)
            // 
            


            //xac dinh case 
            Assert.IsTrue(actual);

            base.Click("//i[@class='fas fa-cloud-upload-alt']");
            base.Click("//a[@href='/ESM/TTDBanChaoChuKyToiChiTiet']");

        }


        [TearDown]
        public override void CleanUp()
        {
            //

            base.CleanUp();
        }

        


    }
}
