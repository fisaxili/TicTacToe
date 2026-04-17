using TicTacToe.Logic;

namespace TicTacToe.Tests;

public class BoardTests
{
    [Fact]
    public void MakeMove_EmptyCell_ReturnsTrue()
    {
        var board = new Board();
        Assert.True(board.MakeMove(0, 0, CellValue.X));
        Assert.Equal(CellValue.X, board[0, 0]);
    }

    [Fact]
    public void MakeMove_OccupiedCell_ReturnsFalse()
    {
        var board = new Board();
        board.MakeMove(1, 1, CellValue.X);
        Assert.False(board.MakeMove(1, 1, CellValue.O));
    }

    [Fact]
    public void MakeMove_OutOfRange_Throws()
    {
        var board = new Board();
        Assert.Throws<ArgumentOutOfRangeException>(() => board.MakeMove(3, 0, CellValue.X));
    }

    [Fact]
    public void CheckWinner_Row_ReturnsCorrect()
    {
        var board = new Board();
        board.MakeMove(0, 0, CellValue.X);
        board.MakeMove(0, 1, CellValue.X);
        board.MakeMove(0, 2, CellValue.X);
        Assert.Equal(CellValue.X, board.CheckWinner());
    }

    [Fact]
    public void CheckWinner_Column_ReturnsCorrect()
    {
        var board = new Board();
        board.MakeMove(0, 2, CellValue.O);
        board.MakeMove(1, 2, CellValue.O);
        board.MakeMove(2, 2, CellValue.O);
        Assert.Equal(CellValue.O, board.CheckWinner());
    }

    [Fact]
    public void CheckWinner_Diagonal_ReturnsCorrect()
    {
        var board = new Board();
        board.MakeMove(0, 0, CellValue.X);
        board.MakeMove(1, 1, CellValue.X);
        board.MakeMove(2, 2, CellValue.X);
        Assert.Equal(CellValue.X, board.CheckWinner());
    }

    [Fact]
    public void CheckWinner_AntiDiagonal_ReturnsCorrect()
    {
        var board = new Board();
        board.MakeMove(0, 2, CellValue.O);
        board.MakeMove(1, 1, CellValue.O);
        board.MakeMove(2, 0, CellValue.O);
        Assert.Equal(CellValue.O, board.CheckWinner());
    }

    [Fact]
    public void IsFull_EmptyBoard_ReturnsFalse()
    {
        Assert.False(new Board().IsFull());
    }

    [Fact]
    public void IsFull_FullBoard_ReturnsTrue()
    {
        var board = new Board();
        // X O X / O X O / O X O
        board.MakeMove(0, 0, CellValue.X); board.MakeMove(0, 1, CellValue.O); board.MakeMove(0, 2, CellValue.X);
        board.MakeMove(1, 0, CellValue.O); board.MakeMove(1, 1, CellValue.X); board.MakeMove(1, 2, CellValue.O);
        board.MakeMove(2, 0, CellValue.O); board.MakeMove(2, 1, CellValue.X); board.MakeMove(2, 2, CellValue.O);
        Assert.True(board.IsFull());
    }

    [Fact]
    public void Reset_ClearsBoard()
    {
        var board = new Board();
        board.MakeMove(0, 0, CellValue.X);
        board.Reset();
        Assert.Equal(CellValue.Empty, board[0, 0]);
    }
}
