

using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V128.Network;
using OpenQA.Selenium.Interactions;


using SeleniumExtras.PageObjects;
// page is: https://freecrm.com/
public class HomePage : BasePage {



    [FindsBy(How = How.XPath, Using ="//a[contains(text(),'About')]")]
    private IWebElement? _aboutMenu;

    [FindsBy(How=How.XPath, Using = "//a[contains(text(),'Features')]")]
    private IWebElement? _FeaturesMenu;

    [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Contacts')]")]
    private IWebElement? _contactMenuItem;
    
    [FindsBy(How=How.Id, Using = "messenger-button")]
    private IWebElement _messageButton;

    [FindsBy(How=How.TagName, Using = "textarea")]
    private IWebElement _messagerTextBox;

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

    public void clickContactsMenuItem(){
        this.hoverOverFeaturesMenu();
        _contactMenuItem.Click();
    }

    public void clickMessengerButton(){
        _messageButton.Click();
    }

    public void typeTextIntoMessagerTextfield(string message){
        _driver.SwitchTo().Frame(1);
        _messagerTextBox.SendKeys(message);
    }
}