namespace TicTacToe.Logic;

/// <summary>
/// Представляет игрока.
/// Хранит имя, символ и текущий счёт побед.
/// </summary>
public class Player
{
    /// <summary>Имя игрока.</summary>
    public string Name { get; }

    /// <summary>Символ игрока на поле: X или O.</summary>
    public CellValue Symbol { get; }

    /// <summary>Количество побед в текущей сессии.</summary>
    public int Score { get; private set; }

    /// <summary>
    /// Создаёт нового игрока.
    /// </summary>
    /// <param name="name">Имя игрока. Не может быть пустым.</param>
    /// <param name="symbol">Символ игрока (X или O). Не может быть <see cref="CellValue.Empty"/>.</param>
    /// <exception cref="ArgumentException">
    /// Если имя пустое или символ равен <see cref="CellValue.Empty"/>.
    /// </exception>
    public Player(string name, CellValue symbol)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Имя игрока не может быть пустым.", nameof(name));
        if (symbol == CellValue.Empty)
            throw new ArgumentException("Символ игрока не может быть Empty.", nameof(symbol));

        Name = name;
        Symbol = symbol;
    }

    /// <summary>Увеличивает счёт побед на 1.</summary>
    public void AddWin() => Score++;

    /// <summary>Сбрасывает счёт побед до нуля.</summary>
    public void ResetScore() => Score = 0;
}
