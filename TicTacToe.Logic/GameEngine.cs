namespace TicTacToe.Logic;

/// <summary>
/// Движок игры — центральный класс, управляющий ходами, сменой игроков и результатом партии.
/// </summary>
public class GameEngine
{
    /// <summary>Игровое поле текущей партии.</summary>
    public Board Board { get; } = new Board();

    /// <summary>Первый игрок (ходит первым).</summary>
    public Player Player1 { get; }

    /// <summary>Второй игрок.</summary>
    public Player Player2 { get; }

    /// <summary>Игрок, чья очередь делать ход.</summary>
    public Player CurrentPlayer { get; private set; }

    /// <summary>Результат текущей партии. <see cref="GameResult.None"/> пока игра не завершена.</summary>
    public GameResult Result { get; private set; } = GameResult.None;

    /// <summary>Возвращает <c>true</c> если партия завершена (есть победитель или ничья).</summary>
    public bool IsGameOver => Result != GameResult.None;

    /// <summary>
    /// Создаёт движок игры с двумя игроками.
    /// </summary>
    /// <param name="player1">Первый игрок.</param>
    /// <param name="player2">Второй игрок.</param>
    /// <exception cref="ArgumentNullException">Если один из игроков равен null.</exception>
    /// <exception cref="ArgumentException">Если оба игрока имеют одинаковый символ.</exception>
    public GameEngine(Player player1, Player player2)
    {
        Player1 = player1 ?? throw new ArgumentNullException(nameof(player1));
        Player2 = player2 ?? throw new ArgumentNullException(nameof(player2));
        if (player1.Symbol == player2.Symbol)
            throw new ArgumentException("Игроки не могут иметь одинаковые символы.");
        CurrentPlayer = player1;
    }

    /// <summary>
    /// Выполняет ход текущего игрока в указанную клетку.
    /// После хода проверяет результат и переключает очерёдность.
    /// </summary>
    /// <param name="row">Строка (0–2).</param>
    /// <param name="col">Столбец (0–2).</param>
    /// <returns><c>true</c> если ход выполнен; <c>false</c> если клетка занята или игра окончена.</returns>
    public bool MakeMove(int row, int col)
    {
        if (IsGameOver) return false;
        if (!Board.MakeMove(row, col, CurrentPlayer.Symbol)) return false;

        UpdateResult();
        if (!IsGameOver) SwitchPlayer();
        return true;
    }

    /// <summary>
    /// Выполняет ход бота через <see cref="BotAI"/>.
    /// Вызывать только когда <see cref="CurrentPlayer"/> является ботом.
    /// </summary>
    /// <returns>Координаты клетки, в которую сходил бот.</returns>
    /// <exception cref="InvalidOperationException">Если текущий игрок не бот или игра окончена.</exception>
    public (int row, int col) MakeBotMove()
    {
        if (!CurrentPlayer.IsBot || IsGameOver)
            throw new InvalidOperationException("Сейчас не ход бота.");

        var move = BotAI.GetBestMove(Board, CurrentPlayer.Symbol);
        MakeMove(move.row, move.col);
        return move;
    }

    /// <summary>
    /// Начинает новую партию: сбрасывает поле и результат, сохраняя счёт игроков.
    /// </summary>
    public void NewGame()
    {
        Board.Reset();
        Result = GameResult.None;
        CurrentPlayer = Player1;
    }

    /// <summary>
    /// Сбрасывает счёт обоих игроков и начинает новую партию.
    /// </summary>
    public void ResetScore()
    {
        Player1.ResetScore();
        Player2.ResetScore();
        NewGame();
    }

    /// <summary>
    /// Обновляет результат партии после каждого хода.
    /// Начисляет победу соответствующему игроку.
    /// </summary>
    private void UpdateResult()
    {
        var winner = Board.CheckWinner();
        if (winner == CellValue.X)
        {
            Result = GameResult.PlayerXWins;
            GetPlayerBySymbol(CellValue.X)?.AddWin();
        }
        else if (winner == CellValue.O)
        {
            Result = GameResult.PlayerOWins;
            GetPlayerBySymbol(CellValue.O)?.AddWin();
        }
        else if (Board.IsFull())
        {
            Result = GameResult.Draw;
        }
    }

    /// <summary>
    /// Переключает очерёдность хода на другого игрока.
    /// </summary>
    private void SwitchPlayer() =>
        CurrentPlayer = CurrentPlayer == Player1 ? Player2 : Player1;

    /// <summary>
    /// Возвращает игрока с указанным символом, или <c>null</c> если не найден.
    /// </summary>
    /// <param name="symbol">Символ для поиска.</param>
    private Player? GetPlayerBySymbol(CellValue symbol) =>
        Player1.Symbol == symbol ? Player1 : Player2.Symbol == symbol ? Player2 : null;
}
