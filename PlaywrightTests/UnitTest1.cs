// using Microsoft.Playwright;

// namespace PlaywrightTests;

// public class Tests
// {
//     [SetUp]
//     public void Setup()
//     {
//     }

//     [Test]
//     public async Task Test1()
//     {
//         using var playwright = await Playwright.CreateAsync();
//         await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{
//             Headless = false
//         });
//         var page = await browser.NewPageAsync();
//         await page.GotoAsync("https://qa-navigator.creditunionsfirst.org/");
//         // await page.ClickAsync(selector:"label=Sign In");
//         // await page.ScreenshotAsync(new PageScreenshotOptions{
//         //         Path = "EAApp1.jpg"

//             // });
//         await page.FillAsync(selector:"#email", value:"admin@cu.com");
//         await page.FillAsync(selector:"#password", value:"Password1");
//         await page.ClickAsync(selector:"text=Sign In");
//         await page.WaitForTimeoutAsync(3000);
//         var isExist = await page.Locator(selector:"text='Dashboard'").IsVisibleAsync();
//         Assert.IsTrue(isExist);
//     }
// }