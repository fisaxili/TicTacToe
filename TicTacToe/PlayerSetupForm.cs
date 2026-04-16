using TicTacToe.Logic;

namespace TicTacToe;

/// <summary>
/// Форма настройки игроков перед началом партии.
/// Позволяет ввести имена игроков и выбрать символ (X или O).
/// </summary>
public partial class PlayerSetupForm : Form
{
    /// <summary>Флаг режима двух игроков.</summary>
    private readonly bool _isTwoPlayers;

    /// <summary>
    /// Созданный движок игры после подтверждения настроек.
    /// Равен <c>null</c>, если пользователь отменил диалог.
    /// </summary>
    public GameEngine
        GameEngine { get; private set; }

    /// <summary>
    /// Инициализирует форму настройки.
    /// </summary>
    /// <param name="isTwoPlayers">
    /// <c>true</c> — режим двух игроков; <c>false</c> — игрок против компьютера.
    /// </param>
    public PlayerSetupForm(bool isTwoPlayers)
    {
        _isTwoPlayers = isTwoPlayers;
        InitializeComponent();
        if (!isTwoPlayers)
        {
            // В режиме одного игрока второй игрок — компьютер, поле скрыто
            lblPlayer2Name.Visible = false;
            txtPlayer2Name.Visible = false;
        }
    }

    /// <summary>
    /// Обработчик кнопки "Начать игру".
    /// Валидирует введённые данные и создаёт <see cref="GameEngine"/>.
    /// </summary>
    private void btnOk_Click(object sender, EventArgs e)
    {
        try
        {
            var name1 = txtPlayer1Name.Text.Trim();
            if (string.IsNullOrWhiteSpace(name1))
            {
                ShowError("Введите имя первого игрока.");
                txtPlayer1Name.Focus();
                return;
            }

            // Определяем символы: игрок 1 выбирает, игрок 2 получает противоположный
            var symbol1 = cmbSymbol.SelectedIndex == 0 ? CellValue.X : CellValue.O;
            var symbol2 = symbol1 == CellValue.X ? CellValue.O : CellValue.X;

            Player p1 = new Player(name1, symbol1);
            Player p2;

            if (_isTwoPlayers)
            {
                var name2 = txtPlayer2Name.Text.Trim();
                if (string.IsNullOrWhiteSpace(name2))
                {
                    ShowError("Введите имя второго игрока.");
                    txtPlayer2Name.Focus();
                    return;
                }
                if (name1.Equals(name2, StringComparison.OrdinalIgnoreCase))
                {
                    ShowError("Имена игроков должны отличаться.");
                    txtPlayer2Name.Focus();
                    return;
                }
                p2 = new Player(name2, symbol2);
            }
            else
            {
                // Второй игрок — бот
                p2 = new Player("Компьютер", symbol2, isBot: true);
            }

            GameEngine = new GameEngine(p1, p2);
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
    }

    /// <summary>
    /// Обработчик кнопки "Отмена". Закрывает диалог без создания игры.
    /// </summary>
    private void btnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    /// <summary>
    /// Показывает диалоговое окно с сообщением об ошибке.
    /// </summary>
    /// <param name="message">Текст сообщения об ошибке.</param>
    private static void ShowError(string message)
    {
        MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
