using System.Collections.Generic;

public class GameLayout : IGameLayout
{
    List<int> game;

    public GameLayout(List<int> game)
    {
        this.game = game;
    }

    public string GetLayoutGame()
    {
        var gameLayout = "";
        
        foreach (var number in this.game)
        {
            gameLayout += number.ToString("00") + "   ";
        }
        
        return gameLayout;
    }
}