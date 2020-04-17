using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url= @"https://market.yandex.ru/catalog/54726/list?hid=91491&track=menuleaf&onstock=1&local-offers-first=0";
            //driver.FindElement(By.XPath(@".//div[@id='search-3']/form/input[@id='s']")).SendKeys("c#");
            //driver.FindElement(By.XPath(@".//img[@class='image']")).Click();
            //Thread.Sleep(3000);
            var links = driver.FindElements(By.XPath(@".//img[@class='image']"));
            foreach (IWebElement link in links)
                Console.WriteLine("{0} - {1}", link.Text, link.GetAttribute("href"));
            Thread.Sleep(3000);
        }
    }
}
