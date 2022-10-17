using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteProjeto3
{
    class BuscaCep : Begin
    {
        [Test]
        public void Test1()
        {
            driver.FindElement(By.Id("endereco")).SendKeys("06534130");
            driver.FindElement(By.Id("btn_pesquisar")).Click();
            Assert.That(driver.FindElement(By.XPath("//*[@id=\'resultado-DNEC\']/tbody/tr/td[1]")).Text, Does.Contain("Rua Tupi"));
            driverQuit = true;
        }
    }
}
