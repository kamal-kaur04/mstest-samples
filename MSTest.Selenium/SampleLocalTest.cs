using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrowserStack
{
  [TestClass]
  [TestCategory("sample-local-test")]
  public class SampleLocalTest : BrowserStackMSTest
  {
    public SampleLocalTest() : base() { }

    [TestMethod]
    public void BStackTunnelCheck()
    {
      // This will fail as browserstackLocal is false
      driver.Navigate().GoToUrl("http://bs-local.com:45454/");
      StringAssert.Contains("BrowserStack Local", driver.Title);
    }
  }
}
