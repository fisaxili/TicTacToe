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
    /// </summary>
    /// <param name="engine">Настроенный движок игры.</param>
    /// <exception cref="ArgumentNullException">Если <paramref name="engine"/> равен null.</exception>
    public GameForm(GameEngine engine)
    {
        _engine = engine ?? throw new ArgumentNullException(nameof(engine));
        InitializeComponent();
        BuildGrid();
        UpdateUI();
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
                    Tag = (r, c)
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
    /// Выполняет ход игрока и обновляет UI.
    /// </summary>
    private void Cell_Click(object? sender, EventArgs e)
    {
        if (_engine.IsGameOver) return;

        var (row, col) = ((int, int))((Button)sender!).Tag!;
        if (!_engine.MakeMove(row, col)) return;

        UpdateCellUI(row, col);
        UpdateUI();
    }

    /// <summary>
    /// Обновляет визуальное состояние одной клетки после хода.
    /// </summary>
    private void UpdateCellUI(int row, int col)
    {
        var btn = _cells[row, col];
        var val = _engine.Board[row, col];
        btn.Text = val == CellValue.X ? "X" : "O";
        btn.ForeColor = val == CellValue.X ? ColorX : ColorO;
        btn.Enabled = false;
    }

    /// <summary>
    /// Обновляет метки статуса и счёта в соответствии с текущим состоянием игры.
    /// </summary>
    private void UpdateUI()
    {
        if (_engine.IsGameOver)
        {
            HighlightWinningLine();
            string winnerX = _engine.Player1.Symbol == CellValue.X ? _engine.Player1.Name : _engine.Player2.Name;
            string winnerO = _engine.Player1.Symbol == CellValue.O ? _engine.Player1.Name : _engine.Player2.Name;
            string msg = _engine.Result switch
            {
                GameResult.PlayerXWins => $"🎉 Победил {winnerX}!",
                GameResult.PlayerOWins => $"🎉 Победил {winnerO}!",
                GameResult.Draw => "🤝 Ничья!",
                _ => ""
            };
            lblStatus.Text = msg;
            lblStatus.ForeColor = _engine.Result == GameResult.Draw
                ? Color.FromArgb(255, 200, 80)
                : ColorWin;
        }
        else
        {
            var cur = _engine.CurrentPlayer;
            lblStatus.Text = $"Ходит: {cur.Name}  [{(cur.Symbol == CellValue.X ? "X" : "O")}]";
            lblStatus.ForeColor = cur.Symbol == CellValue.X ? ColorX : ColorO;
        }

        lblScore1.Text = $"{_engine.Player1.Name}: {_engine.Player1.Score}";
        lblScore2.Text = $"{_engine.Player2.Name}: {_engine.Player2.Score}";
    }

    /// <summary>
    /// Перебирает все возможные линии и подсвечивает победную, если она есть.
    /// </summary>
    private void HighlightWinningLine()
    {
        for (int i = 0; i < 3; i++)
        {
            if (CheckLine((i, 0), (i, 1), (i, 2))) return;
            if (CheckLine((0, i), (1, i), (2, i))) return;
        }
        CheckLine((0, 0), (1, 1), (2, 2));
        CheckLine((0, 2), (1, 1), (2, 0));
    }

    /// <summary>
    /// Проверяет, образуют ли три клетки победную линию, и подсвечивает их.
    /// </summary>
    private bool CheckLine((int r, int c) a, (int r, int c) b, (int r, int c) c2)
    {
        var va = _engine.Board[a.r, a.c];
        if (va == CellValue.Empty) return false;
        if (va == _engine.Board[b.r, b.c] && va == _engine.Board[c2.r, c2.c])
        {
            _cells[a.r, a.c].BackColor = Color.FromArgb(20, 60, 20);
            _cells[b.r, b.c].BackColor = Color.FromArgb(20, 60, 20);
            _cells[c2.r, c2.c].BackColor = Color.FromArgb(20, 60, 20);
            _cells[a.r, a.c].ForeColor = ColorWin;
            _cells[b.r, b.c].ForeColor = ColorWin;
            _cells[c2.r, c2.c].ForeColor = ColorWin;
            return true;
        }
        return false;
    }

    /// <summary>
    /// Обработчик кнопки "Новая игра". Сбрасывает поле, сохраняя счёт.
    /// </summary>
    private void btnNewGame_Click(object sender, EventArgs e)
    {
        _engine.NewGame();
        ResetBoardUI();
        UpdateUI();
    }

    /// <summary>
    /// Обработчик кнопки "Сбросить счёт".
    /// </summary>
    private void btnResetScore_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Сбросить счёт?", "Подтверждение",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            _engine.ResetScore();
            ResetBoardUI();
            UpdateUI();
        }
    }

    /// <summary>
    /// Обработчик кнопки "Главное меню". Закрывает игровую форму.
    /// </summary>
    private void btnBackToMenu_Click(object sender, EventArgs e)
    {
        Close();
    }

    /// <summary>
    /// Сбрасывает визуальное состояние всех клеток поля к начальному виду.
    /// </summary>
    private void ResetBoardUI()
    {
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                _cells[r, c].Text = "";
                _cells[r, c].Enabled = true;
                _cells[r, c].BackColor = Color.FromArgb(30, 30, 50);
                _cells[r, c].ForeColor = Color.White;
            }
        }
    }
}
