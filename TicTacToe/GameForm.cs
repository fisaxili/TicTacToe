using TicTacToe.Logic;

namespace TicTacToe;

/// <summary>
/// Игровая форма — основной экран партии.
/// Отображает поле 3×3, текущий статус, счёт и управляющие кнопки.
/// </summary>
public partial class GameForm : Form
{
    /// <summary>Движок игры, управляющий логикой партии.</summary>

    /// <summary>Кнопки игрового поля, расположенные в матрице 3×3.</summary>
    private readonly Button[,] _cells = new Button[3, 3];

    /// <summary>Цвет символа X.</summary>
    private static readonly Color ColorX = Color.FromArgb(255, 100, 100);

    /// <summary>Цвет символа O.</summary>
    private static readonly Color ColorO = Color.FromArgb(100, 200, 255);

    /// <summary>Цвет подсветки победной линии.</summary>
    private static readonly Color ColorWin = Color.FromArgb(80, 255, 120);
}
