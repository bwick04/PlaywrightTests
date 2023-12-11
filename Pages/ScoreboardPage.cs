using Microsoft.Playwright;

namespace PlaywrightTests.Pages;

public class ScoreboardPage
{
    private readonly IPage _page;
    private readonly ILocator _homeScore;
    private readonly ILocator _guestScore;
    private readonly ILocator _addOneHomeBtn;
    private readonly ILocator _addTwoHomeBtn;
    private readonly ILocator _addThreeHomeBtn;
    private readonly ILocator _resetHomeBtn;
    private readonly ILocator _addOneGuestBtn;
    private readonly ILocator _addTwoGuestBtn;
    private readonly ILocator _addthreeGuestBtn;
    private readonly ILocator _resetGuestBtn;

    public ScoreboardPage(IPage page)
    {
        _page = page;
        _homeScore = _page.Locator("#home-score");
        _guestScore = _page.Locator("#away-score");
        _addOneHomeBtn = _page.Locator("data-testid=add-one-home");
        _addTwoHomeBtn = _page.Locator("data-testid=add-two-home");
        _addThreeHomeBtn =
        _resetHomeBtn = _page.Locator("data-testid=add-three-home");
    }

    public async Task GoToScoreboardPage()
    {
        await _page.GotoAsync("https://basketball-scoreboard-4bb67a.netlify.app/");
    }

    public async Task AddOnePointToHomeScore()
    {
       await _addOneHomeBtn.ClickAsync();
    }

}
