using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.Logic;

namespace TicTacToe.Tests;

[TestClass]
public class BoardTests
{
    //MakeMove 

    [TestMethod]
    public void MakeMove_EmptyCell_ReturnsTrueAndSetsValue()
    {
        var board = new Board();

        bool result = board.MakeMove(1, 1, CellValue.X);

        Assert.IsTrue(result);
        Assert.AreEqual(CellValue.X, board[1, 1]);
    }

    [TestMethod]
    public void MakeMove_OccupiedCell_ReturnsFalseAndKeepsValue()
    {
        var board = new Board();
        board.MakeMove(0, 0, CellValue.X);

        bool result = board.MakeMove(0, 0, CellValue.O);

        Assert.IsFalse(result);
        Assert.AreEqual(CellValue.X, board[0, 0]);
    }

    [TestMethod]
    public void MakeMove_OutOfRange_ThrowsArgumentOutOfRangeException()
    {
        var board = new Board();

        Assert.ThrowsException<ArgumentOutOfRangeException>(
            () => board.MakeMove(3, 0, CellValue.X));
    }

    // CheckWinner 
    [TestMethod]
    public void CheckWinner_TopRow_ReturnsX()
    {
        var board = new Board();
        board.MakeMove(0, 0, CellValue.X);
        board.MakeMove(0, 1, CellValue.X);
        board.MakeMove(0, 2, CellValue.X);

        Assert.AreEqual(CellValue.X, board.CheckWinner());
    }

    [TestMethod]
    public void CheckWinner_MiddleColumn_ReturnsO()
    {
        var board = new Board();
        board.MakeMove(0, 1, CellValue.O);
        board.MakeMove(1, 1, CellValue.O);
        board.MakeMove(2, 1, CellValue.O);

        Assert.AreEqual(CellValue.O, board.CheckWinner());
    }

    [TestMethod]
    public void CheckWinner_MainDiagonal_ReturnsX()
    {
        var board = new Board();
        board.MakeMove(0, 0, CellValue.X);
        board.MakeMove(1, 1, CellValue.X);
        board.MakeMove(2, 2, CellValue.X);

        Assert.AreEqual(CellValue.X, board.CheckWinner());
    }

    [TestMethod]
    public void CheckWinner_AntiDiagonal_ReturnsO()
    {
        var board = new Board();
        board.MakeMove(0, 2, CellValue.O);
        board.MakeMove(1, 1, CellValue.O);
        board.MakeMove(2, 0, CellValue.O);

        Assert.AreEqual(CellValue.O, board.CheckWinner());
    }

    [TestMethod]
    public void CheckWinner_NoWinner_ReturnsEmpty()
    {
        var board = new Board();
        board.MakeMove(0, 0, CellValue.X);
        board.MakeMove(0, 1, CellValue.O);

        Assert.AreEqual(CellValue.Empty, board.CheckWinner());
    }

    //IsFull

    [TestMethod]
    public void IsFull_EmptyBoard_ReturnsFalse()
    {
        var board = new Board();

        Assert.IsFalse(board.IsFull());
    }

    [TestMethod]
    public void IsFull_AllCellsFilled_ReturnsTrue()
    {
        var board = new Board();
        // X O X
        // O X O
        // O X O
        board.MakeMove(0, 0, CellValue.X); board.MakeMove(0, 1, CellValue.O); board.MakeMove(0, 2, CellValue.X);
        board.MakeMove(1, 0, CellValue.O); board.MakeMove(1, 1, CellValue.X); board.MakeMove(1, 2, CellValue.O);
        board.MakeMove(2, 0, CellValue.O); board.MakeMove(2, 1, CellValue.X); board.MakeMove(2, 2, CellValue.O);

        Assert.IsTrue(board.IsFull());
    }

    // GetEmptyCells 

    [TestMethod]
    public void GetEmptyCells_EmptyBoard_Returns9Cells()
    {
        var board = new Board();

        Assert.AreEqual(9, board.GetEmptyCells().Count);
    }

    [TestMethod]
    public void GetEmptyCells_AfterTwoMoves_Returns7Cells()
    {
        var board = new Board();
        board.MakeMove(0, 0, CellValue.X);
        board.MakeMove(2, 2, CellValue.O);

        Assert.AreEqual(7, board.GetEmptyCells().Count);
    }

    // Reset 

    [TestMethod]
    public void Reset_AfterMoves_AllCellsEmpty()
    {
        var board = new Board();
        board.MakeMove(0, 0, CellValue.X);
        board.MakeMove(1, 1, CellValue.O);

        board.Reset();

        for (int r = 0; r < 3; r++)
            for (int c = 0; c < 3; c++)
                Assert.AreEqual(CellValue.Empty, board[r, c]);
    }
}
