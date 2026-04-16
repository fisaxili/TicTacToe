namespace TicTacToe.Logic;

/// <summary>
/// Результат завершённой партии.
/// </summary>
public enum GameResult
{
    /// <summary>Игра ещё не завершена.</summary>
    None,

    /// <summary>Победил игрок с символом X.</summary>
    PlayerXWins,

    /// <summary>Победил игрок с символом O.</summary>
    PlayerOWins,

    /// <summary>Ничья — все клетки заняты, победителя нет.</summary>
    Draw
}
