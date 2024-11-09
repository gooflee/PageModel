

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


using SeleniumExtras.PageObjects;
// page is: https://freecrm.com/
public class HomePage : BasePage {



    [FindsBy(How = How.XPath, Using ="//a[contains(text(),'About')]")]
    private IWebElement? _aboutMenu;

    [FindsBy(How=How.XPath, Using = "//header/div[1]/nav[1]/div[2]/div[1]/div[3]/ul[1]/li[2]")]
    private IWebElement? _FeaturesMenu;
    public HomePage(IWebDriver driver) : base(driver){
        PageFactory.InitElements(driver, this);
    }

    public void clickAboutMenu(){

        if(_aboutMenu!= null){
            _aboutMenu.Click();
        }
        else{
            throw new Exception("PageObject About is null");
        }
    }

    public void hoverOverFeaturesMenu(){
        Actions actions = new Actions(_driver);
        actions.MoveToElement(_FeaturesMenu).Build().Perform();
    }
}