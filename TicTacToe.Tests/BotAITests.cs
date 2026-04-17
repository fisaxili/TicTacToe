using TicTacToe.Logic;

namespace TicTacToe.Tests;

public class BotAITests
{
    [Fact]
    public void GetBestMove_WinningMove_TakesIt()
    {
        // Бот X может выиграть ходом (0,2)
        var board = new Board();
        board.MakeMove(0, 0, CellValue.X);
        board.MakeMove(0, 1, CellValue.X);
        // (0,2) свободна — бот должен туда пойти
        var move = BotAI.GetBestMove(board, CellValue.X);
        Assert.Equal((0, 2), move);
    }

    [Fact]
    public void GetBestMove_BlockOpponent_Blocks()
    {
        // Человек O угрожает выиграть по строке 1
        var board = new Board();
        board.MakeMove(1, 0, CellValue.O);
        board.MakeMove(1, 1, CellValue.O);
        // Бот X должен заблокировать (1,2)
        var move = BotAI.GetBestMove(board, CellValue.X);
        Assert.Equal((1, 2), move);
    }

    [Fact]
    public void GetBestMove_EmptyBoard_ReturnsValidCell()
    {
        var board = new Board();
        var (r, c) = BotAI.GetBestMove(board, CellValue.X);
        Assert.InRange(r, 0, 2);
        Assert.InRange(c, 0, 2);
    }
}
