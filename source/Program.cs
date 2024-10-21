using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace RPAChallengeSolve;

static class Program
{
  const string rpaChallengeURL = "https://rpachallenge.com/";
  static void Main(string[] args)
  {
    IList<ChallengeModel> lst = ChallengeModel.GetDemoList();
    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
    FirefoxOptions options = new FirefoxOptions();
    IWebDriver driver = new FirefoxDriver(service, options);
    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

    try
    {
      driver.Navigate().GoToUrl(rpaChallengeURL);

      IWebElement startButton = wait.Until(
          drv => drv.FindElement(By.XPath("//button[contains(text(),'Start')]"))
        );
      startButton.Click();

      foreach(ChallengeModel obj in lst)
      {
        IWebElement submitButton = wait.Until(
            drv => drv.FindElement(By.XPath("(//input[@type='submit' and contains(@value,'Submit')])"))
          );
        ReadOnlyCollection<IWebElement> inputFields = driver.FindElements(By.TagName("input"));
        
        foreach(IWebElement el in inputFields)
        {
          string field = el.GetAttribute("ng-reflect-name");
          switch(field)
          {
            case "labelAddress":
              el.SendKeys(obj.Address);
              break;

            case "labelEmail":
              el.SendKeys(obj.Email);
              break;

            case "labelLastName":
              el.SendKeys(obj.LastName);
              break;

            case "labelPhone":
              el.SendKeys(obj.PhoneNumber);
              break;

            case "labelRole":
              el.SendKeys(obj.RoleInCompany);
              break;

            case "labelCompanyName":
              el.SendKeys(obj.CompanyName);
              break;

            case "labelFirstName":
              el.SendKeys(obj.FirstName);
              break;

            default:
              break;
          }
        }

        submitButton.Click();
      }

      Thread.Sleep(5000);
      driver.Quit();
    }
    catch (Exception ex)
    {
      Console.WriteLine($"[ERROR] {ex.Message}");
    }
    finally
    {
      driver.Quit();
    }
  }
}