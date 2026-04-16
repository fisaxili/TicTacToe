using TicTacToe.Logic;

namespace TicTacToe;

/// <summary>
/// Игровая форма — основной экран партии.
/// Отображает поле 3×3, текущий статус, счёт и управляющие кнопки.
/// </summary>
public partial class GameForm : Form
{
    /// <summary>Движок игры, управляющий логикой партии.</summary>
    private readonly GameEngine _engine;

    /// <summary>Кнопки игрового поля, расположенные в матрице 3×3.</summary>
    private readonly Button[,] _cells = new Button[3, 3];

    /// <summary>Цвет символа X.</summary>
    private static readonly Color ColorX = Color.FromArgb(255, 100, 100);

    /// <summary>Цвет символа O.</summary>
    private static readonly Color ColorO = Color.FromArgb(100, 200, 255);

    /// <summary>Цвет подсветки победной линии.</summary>
    private static readonly Color ColorWin = Color.FromArgb(80, 255, 120);

    /// <summary>
    /// Инициализирует игровую форму и запускает партию.
    /// Если первым ходит бот — автоматически выполняет его ход.
    /// </summary>
    /// <param name="engine">Настроенный движок игры.</param>
    /// <exception cref="ArgumentNullException">Если <paramref name="engine"/> равен null.</exception>
    public GameForm(GameEngine engine)
    {
        _engine = engine ?? throw new ArgumentNullException(nameof(engine));
        InitializeComponent();
        BuildGrid();
        UpdateUI();

        // Если первым ходит бот — делаем ход сразу
        if (_engine.CurrentPlayer.IsBot)
            BotMoveAsync();
    }

    /// <summary>
    /// Динамически создаёт кнопки игрового поля 3×3 и добавляет их на панель.
    /// </summary>
    private void BuildGrid()
    {
        int cellSize = 110;
        int padding = 8;
        int startX = 40;
        int startY = 40;

        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                var btn = new Button
                {
                    Size = new Size(cellSize, cellSize),
                    Location = new Point(startX + c * (cellSize + padding), startY + r * (cellSize + padding)),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(30, 30, 50),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 36f, FontStyle.Bold),
                    Cursor = Cursors.Hand,
                    Tag = (r, c)  // сохраняем координаты клетки в Tag
                };
                btn.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 100);
                btn.FlatAppearance.BorderSize = 2;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 70);
                btn.Click += Cell_Click;
                _cells[r, c] = btn;
                pnlBoard.Controls.Add(btn);
            }
        }
    }

    /// <summary>
    /// Обработчик клика по клетке поля.
    /// Выполняет ход игрока, обновляет UI и при необходимости запускает ход бота.
    /// </summary>
    private void Cell_Click(object? sender, EventArgs e)
    {
        // Игнорируем клик если игра окончена или сейчас ход бота
        if (_engine.IsGameOver || _engine.CurrentPlayer.IsBot) return;

        var (row, col) = ((int, int))((Button)sender!).Tag!;
        if (!_engine.MakeMove(row, col)) return;

        UpdateCellUI(row, col);
        UpdateUI();

        // Если после хода игрока наступает очередь бота — запускаем
        if (!_engine.IsGameOver && _engine.CurrentPlayer.IsBot)
            BotMoveAsync();
    }

    }

    /// <summary>
    /// Обработчик кнопки "Новая игра". Сбрасывает поле, сохраняя счёт.
    /// </summary>
    private void btnNewGame_Click(object sender, EventArgs e)
    {
        _engine.NewGame();
        ResetBoardUI();
        UpdateUI();
        if (_engine.CurrentPlayer.IsBot) BotMoveAsync();
    }

    /// <summary>
    /// Обработчик кнопки "Сбросить счёт".
    /// Запрашивает подтверждение и обнуляет счёт обоих игроков.
    /// </summary>
    private void btnResetScore_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Сбросить счёт?", "Подтверждение",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            _engine.ResetScore();
            ResetBoardUI();
            UpdateUI();
            if (_engine.CurrentPlayer.IsBot) BotMoveAsync();
        }
    }

    /// <summary>
    /// Обработчик кнопки "Главное меню". Закрывает игровую форму.
    /// </summary>
    private void btnBackToMenu_Click(object sender, EventArgs e)
    {
        Close();
    }


            }
        }
    }
}
