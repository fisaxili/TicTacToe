using TicTacToe;
using TicTacToe.Logic;

namespace TicTacToe;

/// <summary>
/// Главная форма — начальный экран приложения.
/// Позволяет выбрать режим игры: один игрок против компьютера или два игрока.
/// </summary>
public partial class MainMenuForm : Form
{
    /// <summary>
    /// Инициализирует компоненты главного меню.
    /// </summary>
    public MainMenuForm()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Обработчик кнопки "Один игрок".
    /// Открывает форму настройки для режима игрок против компьютера.
    /// </summary>
    private void btnSinglePlayer_Click(object sender, EventArgs e)
    {
        using var setup = new PlayerSetupForm(isTwoPlayers: false);
        if (setup.ShowDialog() == DialogResult.OK && setup.GameEngine != null)
        {
            var gameForm = new GameForm(setup.GameEngine);
            gameForm.FormClosed += (_, _) => Show();
            Hide();
            gameForm.Show();
        }
    }

    /// <summary>
    /// Обработчик кнопки "Два игрока".
    /// Открывает форму настройки для режима игрок против игрока.
    /// </summary>
    private void btnTwoPlayers_Click(object sender, EventArgs e)
    {
        using var setup = new PlayerSetupForm(isTwoPlayers: true);
        if (setup.ShowDialog() == DialogResult.OK && setup.GameEngine != null)
        {
            var gameForm = new GameForm(setup.GameEngine);
            gameForm.FormClosed += (_, _) => Show();
            Hide();
            gameForm.Show();
        }
    }
}
