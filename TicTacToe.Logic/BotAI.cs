namespace TicTacToe.Logic;

/// <summary>
/// Искусственный интеллект компьютерного игрока.
/// Использует алгоритм Minimax с элементом случайности для среднего уровня сложности:
/// 60% ходов — оптимальные, 40% — случайные.
/// </summary>
public static class BotAI
{
    /// <summary>Генератор случайных чисел для случайных ходов.</summary>
    private static readonly Random _rng = new Random();

    /// <summary>
    /// Возвращает координаты следующего хода бота.
    /// С вероятностью 60% выбирает оптимальный ход (Minimax),
    /// с вероятностью 40% — случайную свободную клетку.
    /// </summary>
    /// <param name="board">Текущее состояние игрового поля.</param>
    /// <param name="botSymbol">Символ бота (X или O).</param>
    /// <returns>Координаты хода (row, col), или (-1, -1) если поле заполнено.</returns>
    public static (int row, int col) GetBestMove(Board board, CellValue botSymbol)
    {
        var empty = board.GetEmptyCells();
        if (empty.Count == 0) return (-1, -1);

        return _rng.Next(100) < 60
            ? GetMinimaxMove(board, botSymbol)
            : empty[_rng.Next(empty.Count)];
    }

    /// <summary>
    /// Находит оптимальный ход с помощью алгоритма Minimax.
    /// Перебирает все возможные ходы и выбирает тот, который максимизирует оценку позиции.
    /// </summary>
    /// <param name="board">Текущее состояние поля.</param>
    /// <param name="botSymbol">Символ бота.</param>
    /// <returns>Координаты оптимального хода.</returns>
    private static (int row, int col) GetMinimaxMove(Board board, CellValue botSymbol)
    {
        var humanSymbol = botSymbol == CellValue.X ? CellValue.O : CellValue.X;
        int bestScore = int.MinValue;
        (int row, int col) bestMove = (-1, -1);

        foreach (var (r, c) in board.GetEmptyCells())
        {
            board.MakeMove(r, c, botSymbol);
            int score = Minimax(board, 0, false, botSymbol, humanSymbol);
            board.ForceSet(r, c, CellValue.Empty); // откат пробного хода

            if (score > bestScore)
            {
                bestScore = score;
                bestMove = (r, c);
            }
        }
        return bestMove;
    }

    /// <summary>
    /// Рекурсивный алгоритм Minimax.
    /// Максимизирует оценку для бота и минимизирует для противника.
    /// </summary>
    /// <param name="board">Текущее состояние поля.</param>
    /// <param name="depth">Глубина рекурсии (количество сделанных ходов).</param>
    /// <param name="isMaximizing"><c>true</c> — ход бота (максимизация); <c>false</c> — ход противника (минимизация).</param>
    /// <param name="botSymbol">Символ бота.</param>
    /// <param name="humanSymbol">Символ противника.</param>
    /// <returns>Оценка позиции: положительная — выгодна боту, отрицательная — выгодна противнику, 0 — ничья.</returns>
    private static int Minimax(Board board, int depth, bool isMaximizing, CellValue botSymbol, CellValue humanSymbol)
    {
        var winner = board.CheckWinner();
        if (winner == botSymbol) return 10 - depth; // бот выиграл
        if (winner == humanSymbol) return depth - 10; // противник выиграл
        if (board.IsFull()) return 0;           // ничья

        if (isMaximizing)
        {
            int best = int.MinValue;
            foreach (var (r, c) in board.GetEmptyCells())
            {
                board.MakeMove(r, c, botSymbol);
                best = Math.Max(best, Minimax(board, depth + 1, false, botSymbol, humanSymbol));
                board.ForceSet(r, c, CellValue.Empty);
            }
            return best;
        }
        else
        {
            int best = int.MaxValue;
            foreach (var (r, c) in board.GetEmptyCells())
            {
                board.MakeMove(r, c, humanSymbol);
                best = Math.Min(best, Minimax(board, depth + 1, true, botSymbol, humanSymbol));
                board.ForceSet(r, c, CellValue.Empty);
            }
            return best;
        }
    }
}
