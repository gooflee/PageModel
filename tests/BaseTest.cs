
using System.ComponentModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

public class BaseTest {
    
    [ThreadStatic]
    public static IWebDriver driver;

    [SetUp]
    public void setup(){
        new DriverManager().SetUpDriver(new ChromeConfig());
        driver = new ChromeDriver();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
    }

    [TearDown]
    public void teardown(){
        driver.Quit();
        driver.Dispose();
    }
}