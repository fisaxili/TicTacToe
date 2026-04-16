namespace TicTacToe.Logic;

/// <summary>
/// Игровое поле 3×3.
/// Хранит состояние клеток и предоставляет методы для выполнения ходов и проверки результата.
/// </summary>
public class Board
{
    /// <summary>Внутренний массив клеток поля.</summary>
    private readonly CellValue[,] _cells = new CellValue[3, 3];

    /// <summary>
    /// Возвращает значение клетки по координатам.
    /// </summary>
    /// <param name="row">Строка (0–2).</param>
    /// <param name="col">Столбец (0–2).</param>
    public CellValue this[int row, int col] => _cells[row, col];

    /// <summary>
    /// Выполняет ход — записывает символ в указанную клетку.
    /// </summary>
    /// <param name="row">Строка (0–2).</param>
    /// <param name="col">Столбец (0–2).</param>
    /// <param name="symbol">Символ игрока (X или O).</param>
    /// <returns><c>true</c> если ход выполнен; <c>false</c> если клетка уже занята.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Если координаты выходят за пределы поля.</exception>
    public bool MakeMove(int row, int col, CellValue symbol)
    {
        if (row < 0 || row > 2 || col < 0 || col > 2)
            throw new ArgumentOutOfRangeException("Координаты должны быть от 0 до 2.");
        if (_cells[row, col] != CellValue.Empty)
            return false;

        _cells[row, col] = symbol;
        return true;
    }

    /// <summary>
    /// Проверяет наличие победителя на поле.
    /// Анализирует все строки, столбцы и диагонали.
    /// </summary>
    /// <returns>
    /// Символ победителя (<see cref="CellValue.X"/> или <see cref="CellValue.O"/>),
    /// либо <see cref="CellValue.Empty"/> если победителя нет.
    /// </returns>
    public CellValue CheckWinner()
    {
        // Проверка строк и столбцов
        for (int i = 0; i < 3; i++)
        {
            if (_cells[i, 0] != CellValue.Empty && _cells[i, 0] == _cells[i, 1] && _cells[i, 1] == _cells[i, 2])
                return _cells[i, 0];
            if (_cells[0, i] != CellValue.Empty && _cells[0, i] == _cells[1, i] && _cells[1, i] == _cells[2, i])
                return _cells[0, i];
        }
        // Проверка главной диагонали
        if (_cells[0, 0] != CellValue.Empty && _cells[0, 0] == _cells[1, 1] && _cells[1, 1] == _cells[2, 2])
            return _cells[0, 0];
        // Проверка побочной диагонали
        if (_cells[0, 2] != CellValue.Empty && _cells[0, 2] == _cells[1, 1] && _cells[1, 1] == _cells[2, 0])
            return _cells[0, 2];

        return CellValue.Empty;
    }

    /// <summary>
    /// Проверяет, заполнено ли поле полностью (нет свободных клеток).
    /// </summary>
    /// <returns><c>true</c> если все клетки заняты.</returns>
    public bool IsFull()
    {
        for (int r = 0; r < 3; r++)
            for (int c = 0; c < 3; c++)
                if (_cells[r, c] == CellValue.Empty) return false;
        return true;
    }

    /// <summary>
    /// Возвращает список координат всех свободных клеток.
    /// </summary>
    /// <returns>Список кортежей (row, col) для каждой пустой клетки.</returns>
    public List<(int row, int col)> GetEmptyCells()
    {
        var list = new List<(int, int)>();
        for (int r = 0; r < 3; r++)
            for (int c = 0; c < 3; c++)
                if (_cells[r, c] == CellValue.Empty)
                    list.Add((r, c));
        return list;
    }

    /// <summary>
    /// Принудительно устанавливает значение клетки без проверок.
    /// Используется алгоритмом Minimax для отката пробных ходов.
    /// </summary>
    /// <param name="row">Строка (0–2).</param>
    /// <param name="col">Столбец (0–2).</param>
    /// <param name="value">Новое значение клетки.</param>
    internal void ForceSet(int row, int col, CellValue value) => _cells[row, col] = value;

    /// <summary>
    /// Сбрасывает поле — все клетки становятся пустыми.
    /// </summary>
    public void Reset()
    {
        for (int r = 0; r < 3; r++)
            for (int c = 0; c < 3; c++)
                _cells[r, c] = CellValue.Empty;
    }
}
