using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.Logic;

namespace TicTacToe.Tests;

[TestClass]
public class GameEngineTests
{
    private static GameEngine CreateEngine()
    {
        var p1 = new Player("Игрок 1", CellValue.X);
        var p2 = new Player("Игрок 2", CellValue.O);
        return new GameEngine(p1, p2);
    }

    // Конструктор

    [TestMethod]
    public void Constructor_SameSymbols_ThrowsArgumentException()
    {
        var p1 = new Player("А", CellValue.X);
        var p2 = new Player("Б", CellValue.X);

        Assert.ThrowsException<ArgumentException>(
            () => new GameEngine(p1, p2));
    }

    [TestMethod]
    public void Constructor_NullPlayer_ThrowsArgumentNullException()
    {
        var p1 = new Player("А", CellValue.X);

        Assert.ThrowsException<ArgumentNullException>(
            () => new GameEngine(p1, null!));
    }

    // MakeMove 

    [TestMethod]
    public void MakeMove_ValidCell_ReturnsTrue()
    {
        var engine = CreateEngine();

        bool result = engine.MakeMove(0, 0);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void MakeMove_OccupiedCell_ReturnsFalse()
    {
        var engine = CreateEngine();
        engine.MakeMove(0, 0);

        bool result = engine.MakeMove(0, 0);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void MakeMove_SwitchesCurrentPlayer()
    {
        var engine = CreateEngine();
        var firstPlayer = engine.CurrentPlayer;

        engine.MakeMove(0, 0);

        Assert.AreNotEqual(firstPlayer, engine.CurrentPlayer);
    }

    [TestMethod]
    public void MakeMove_AfterGameOver_ReturnsFalse()
    {
        var engine = CreateEngine();
        // X побеждает по первой строке
        engine.MakeMove(0, 0); engine.MakeMove(1, 0);
        engine.MakeMove(0, 1); engine.MakeMove(1, 1);
        engine.MakeMove(0, 2); // X выиграл

        bool result = engine.MakeMove(2, 2);

        Assert.IsFalse(result);
    }

    //Результат игры

    [TestMethod]
    public void MakeMove_XWinsTopRow_ResultIsPlayerXWins()
    {
        var engine = CreateEngine();
        engine.MakeMove(0, 0); engine.MakeMove(1, 0);
        engine.MakeMove(0, 1); engine.MakeMove(1, 1);
        engine.MakeMove(0, 2);

        Assert.AreEqual(GameResult.PlayerXWins, engine.Result);
        Assert.IsTrue(engine.IsGameOver);
    }

    [TestMethod]
    public void MakeMove_OWinsColumn_ResultIsPlayerOWins()
    {
        var engine = CreateEngine();
        // X: (0,0),(0,1)  O: (1,0),(1,1),(1,2)
        engine.MakeMove(0, 0); engine.MakeMove(1, 0);
        engine.MakeMove(0, 1); engine.MakeMove(1, 1);
        engine.MakeMove(2, 2); engine.MakeMove(1, 2);

        Assert.AreEqual(GameResult.PlayerOWins, engine.Result);
    }

    [TestMethod]
    public void MakeMove_Draw_ResultIsDraw()
    {
        var engine = CreateEngine();
        // X O X
        // X X O
        // O X O  — ничья (нет победителя)
        engine.MakeMove(0, 0); engine.MakeMove(0, 1);
        engine.MakeMove(0, 2); engine.MakeMove(2, 0);
        engine.MakeMove(1, 0); engine.MakeMove(1, 2);
        engine.MakeMove(1, 1); engine.MakeMove(2, 2);
        engine.MakeMove(2, 1);

        Assert.AreEqual(GameResult.Draw, engine.Result);
    }

    // Счёт 

    [TestMethod]
    public void MakeMove_XWins_Player1ScoreIncremented()
    {
        var engine = CreateEngine();
        engine.MakeMove(0, 0); engine.MakeMove(1, 0);
        engine.MakeMove(0, 1); engine.MakeMove(1, 1);
        engine.MakeMove(0, 2);

        Assert.AreEqual(1, engine.Player1.Score);
        Assert.AreEqual(0, engine.Player2.Score);
    }

    //  NewGame 

    [TestMethod]
    public void NewGame_ResetsBoard_AndResult()
    {
        var engine = CreateEngine();
        engine.MakeMove(0, 0); engine.MakeMove(1, 0);
        engine.MakeMove(0, 1); engine.MakeMove(1, 1);
        engine.MakeMove(0, 2); // X выиграл

        engine.NewGame();

        Assert.AreEqual(GameResult.None, engine.Result);
        Assert.IsFalse(engine.IsGameOver);
        Assert.AreEqual(CellValue.Empty, engine.Board[0, 0]);
    }

    [TestMethod]
    public void NewGame_PreservesScore()
    {
        var engine = CreateEngine();
        engine.MakeMove(0, 0); engine.MakeMove(1, 0);
        engine.MakeMove(0, 1); engine.MakeMove(1, 1);
        engine.MakeMove(0, 2); // X выиграл — Score = 1

        engine.NewGame();

        Assert.AreEqual(1, engine.Player1.Score);
    }

    //ResetScore

    [TestMethod]
    public void ResetScore_ClearsScoreAndBoard()
    {
        var engine = CreateEngine();
        engine.MakeMove(0, 0); engine.MakeMove(1, 0);
        engine.MakeMove(0, 1); engine.MakeMove(1, 1);
        engine.MakeMove(0, 2);

        engine.ResetScore();

        Assert.AreEqual(0, engine.Player1.Score);
        Assert.AreEqual(0, engine.Player2.Score);
        Assert.AreEqual(GameResult.None, engine.Result);
    }

    // CurrentPlayer после победы

    [TestMethod]
    public void MakeMove_WinningMove_CurrentPlayerNotSwitched()
    {
        var engine = CreateEngine();
        engine.MakeMove(0, 0); engine.MakeMove(1, 0);
        engine.MakeMove(0, 1); engine.MakeMove(1, 1);

        var beforeWin = engine.CurrentPlayer;
        engine.MakeMove(0, 2); // победный ход

        Assert.AreEqual(beforeWin, engine.CurrentPlayer);
    }
}
