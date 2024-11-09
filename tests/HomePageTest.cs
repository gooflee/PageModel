


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

[Parallelizable(ParallelScope.All)]
public class HomePageTest : BaseTest{  


    [Test]
    public void clickAboutMenu(){
        driver.Navigate().GoToUrl("https://freecrm.com/");
        Assert.IsTrue(driver.Title=="#1 Free CRM Software Power Up your Entire Business Free Forever");
        HomePage homePage = new HomePage(driver);
        homePage.clickAboutMenu();
        //Assert.AreEqual("About Free CRM for Any Business", driver.Title);
        Assert.That(driver.Title,Is.EqualTo("About Free CRM for Any Business"));
    }

    [Test]
    public void clickSomethingWithHoverOver(){
        driver.Navigate().GoToUrl("https://freecrm.com/");
        Assert.IsTrue(driver.Title=="#1 Free CRM Software Power Up your Entire Business Free Forever");
        HomePage homePage = new HomePage(driver);
        homePage.hoverOverFeaturesMenu();
        var a = 1;
    }
    
}