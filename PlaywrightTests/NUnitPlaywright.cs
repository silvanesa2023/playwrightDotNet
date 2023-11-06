using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

public class NUnitPlaywright:PageTest
{
    [SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync("https://qa-navigator.creditunionsfirst.org/");
    }

    [Test]
    public async Task Test1()
    {
        await Page.FillAsync(selector:"#email", value:"admin");
        await Page.FillAsync(selector:"#password", value:"Password1");
        await Page.ClickAsync(selector:"text=Sign In");
        await Expect(Page.Locator(selector:"text=Dashboard")).ToBeVisibleAsync();
    }
}