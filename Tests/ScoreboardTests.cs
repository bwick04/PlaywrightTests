using Microsoft.Playwright.NUnit;
using PlaywrightTests.Pages;
using Microsoft.Playwright;


namespace PlaywrightTests.Tests;

[Parallelizable]
[TestFixture]
public class ScoreboardTest : PageTest
{
    protected ScoreboardPage scoreboardPage;

    [Test]
    public async Task ShouldHaveTheCorrectSlogan()
    {
        scoreboardPage = new ScoreboardPage(Page);
        var homeScore = Page.Locator("#home-score");

        await scoreboardPage.GoToScoreboardPage();
        await scoreboardPage.AddOnePointToHomeScore();
        await Expect(homeScore).ToContainTextAsync("1");
    }
}