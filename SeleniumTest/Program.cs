using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
        

            IWebDriver driver = new EdgeDriver();
            string link = @"https://localhost:44351/Account/Login/";
            driver.Navigate().GoToUrl(link);

            //Login Test

            driver.FindElement(By.ClassName("username")).SendKeys("Okan");
            driver.FindElement(By.ClassName("password")).SendKeys("111");
            driver.FindElement(By.ClassName("form-btn")).Click();

            //driver.FindElement(By.XPath(".//*[@class='content']/div[3]/div[2]/div/div[3]/div/a[1]")).Click();
            //System.Threading.Thread.Sleep(5000);

            driver.FindElement(By.Id("transfer")).Click();
            driver.FindElement(By.Id("SenderUser")).SendKeys("f6e0a1e2ac41945a9aa7ff8a8aaa0cebc12a3bcc981a929ad5cf810a090e11ae");
            driver.FindElement(By.Id("ReceiverUser")).SendKeys("2ac9a6746aca543af8dff39894cfe8173afba21eb01c6fae33d52947222855ef");
            driver.FindElement(By.Id("Amount")).SendKeys("200");
            driver.FindElement(By.Id("Gonder")).Click();

            System.Threading.Thread.Sleep(3000);

            //Nesne Ekleme Testi
            driver.FindElement(By.Id("nesneEkle")).Click();
            driver.FindElement(By.Id("ArticleName")).SendKeys("Kalem");
            driver.FindElement(By.Id("ArticleQuantity")).SendKeys("2");
            driver.FindElement(By.Id("Carbon")).SendKeys("150");
            driver.FindElement(By.Id("RecyclType")).SendKeys("Tahta");
            driver.FindElement(By.Id("Kaydet2")).Click();

            System.Threading.Thread.Sleep(3000);

            //Güncelleme Testi
            driver.FindElement(By.ClassName("nav-link")).Click();
            driver.FindElement(By.Id("Guncelleme")).Click();
            driver.FindElement(By.Id("RecyclType")).Clear();
            driver.FindElement(By.Id("RecyclType")).SendKeys("Alüminyum");
            driver.FindElement(By.Id("Guncelle")).Click();

            



            //Silme Testi
            //driver.FindElement(By.ClassName("btn-danger")).Click();

        }
    }
}
