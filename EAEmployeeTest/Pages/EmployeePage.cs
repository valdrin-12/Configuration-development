using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAEmployeeTest.Pages
{
    internal class EmployeePage
    {

        private IWebDriver Driver;

        public EmployeePage(IWebDriver driver)

        {
            Driver = driver;
        }



        //public LoginPage(RemoteWebDriver driver) => _driver = driver;

       // public IWebElement buttonEmployee => Driver.FindElement(By.CssSelector("body > div.navbar.navbar-inverse.navbar-fixed-top > div > div.navbar-collapse.collapse > ul > li:nth-child(3) > a"));

        public IWebElement txtSearch => Driver.FindElement(By.Name("searchTerm"));
        public IWebElement lnkCreateNew => Driver.FindElement(By.LinkText("Create New"));

        public IWebElement lnkEmployeeList => Driver.FindElement(By.LinkText("Employee List"));

        public void ClickCreateNew()
        {
            lnkCreateNew.Click();
        }

        public void EmployeeList()
        {

            lnkEmployeeList.Click();
        }

    }
}

