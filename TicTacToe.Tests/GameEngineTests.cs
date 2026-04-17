using TicTacToe.Logic;

namespace TicTacToe.Tests;

public class GameEngineTests
{
    private static GameEngine CreateGame() =>
        new GameEngine(new Player("Игрок1", CellValue.X), new Player("Игрок2", CellValue.O));

    [Fact]
    public void Constructor_SameSymbols_Throws()
    {
        Assert.Throws<ArgumentException>(() =>
            new GameEngine(new Player("A", CellValue.X), new Player("B", CellValue.X)));
    }

    [Fact]
    public void MakeMove_SwitchesPlayer()
    {
        var game = CreateGame();
        var first = game.CurrentPlayer;
        game.MakeMove(0, 0);
        Assert.NotEqual(first, game.CurrentPlayer);
    }

    [Fact]
    public void MakeMove_OccupiedCell_ReturnsFalse()
    {
        var game = CreateGame();
        game.MakeMove(0, 0);
        Assert.False(game.MakeMove(0, 0));
    }

    [Fact]
    public void MakeMove_WinCondition_SetsResult()
    {
        var game = CreateGame();
        // X ходит: (0,0),(0,1),(0,2) — побеждает
        game.MakeMove(0, 0); // X
        game.MakeMove(1, 0); // O
        game.MakeMove(0, 1); // X
        game.MakeMove(1, 1); // O
        game.MakeMove(0, 2); // X wins
        Assert.Equal(GameResult.PlayerXWins, game.Result);
        Assert.True(game.IsGameOver);
    }

    [Fact]
    public void MakeMove_Draw_SetsDrawResult()
    {
        var game = CreateGame();
        // X O X / O X O / O X O — ничья
        game.MakeMove(0, 0); // X
        game.MakeMove(0, 1); // O
        game.MakeMove(0, 2); // X
        game.MakeMove(1, 1); // O
        game.MakeMove(1, 0); // X
        game.MakeMove(1, 2); // O
        game.MakeMove(2, 1); // X
        game.MakeMove(2, 0); // O
        game.MakeMove(2, 2); // X
        Assert.Equal(GameResult.Draw, game.Result);
    }

    [Fact]
    public void NewGame_ResetsBoard_KeepsScore()
    {
        var game = CreateGame();
        game.MakeMove(0, 0); game.MakeMove(1, 0);
        game.MakeMove(0, 1); game.MakeMove(1, 1);
        game.MakeMove(0, 2); // X wins
        int score = game.Player1.Score;
        game.NewGame();
        Assert.Equal(GameResult.None, game.Result);
        Assert.Equal(score, game.Player1.Score);
    }

    [Fact]
    public void ResetScore_ClearsScores()
    {
        var game = CreateGame();
        game.MakeMove(0, 0); game.MakeMove(1, 0);
        game.MakeMove(0, 1); game.MakeMove(1, 1);
        game.MakeMove(0, 2); // X wins
        game.ResetScore();
        Assert.Equal(0, game.Player1.Score);
        Assert.Equal(0, game.Player2.Score);
    }

    [Fact]
    public void Player_EmptyName_Throws()
    {
        Assert.Throws<ArgumentException>(() => new Player("", CellValue.X));
    }

    [Fact]
    public void Player_EmptySymbol_Throws()
    {
        Assert.Throws<ArgumentException>(() => new Player("Test", CellValue.Empty));
    }
}
