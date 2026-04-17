using TicTacToe;
using TicTacToe.Logic;

namespace TicTacToe;

/// <summary>
/// Главная форма — начальный экран приложения.
/// </summary>
public partial class MainMenuForm : Form
{
    public MainMenuForm()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Обработчик кнопки "Играть".
    /// Открывает форму настройки игроков и запускает игру.
    /// </summary>
    private void btnPlay_Click(object sender, EventArgs e)
    {
        using var setup = new PlayerSetupForm();
        if (setup.ShowDialog() == DialogResult.OK && setup.GameEngine != null)
        {
            var gameForm = new GameForm(setup.GameEngine);
            gameForm.FormClosed += (_, _) => Show();
            Hide();
            gameForm.Show();
        }
    }
}
