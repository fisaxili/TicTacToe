using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe;

partial class GameForm
{
    private System.ComponentModel.IContainer components = null;
    private Panel pnlBoard;
    private Label lblStatus, lblScore1, lblScore2, lblScoreTitle;
    private Button btnNewGame, btnResetScore, btnBackToMenu;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.SuspendLayout();

        this.Text = "Крестики-нолики — Игра";
        this.Size = new Size(780, 560);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.BackColor = Color.FromArgb(18, 18, 30);
        this.Font = new Font("Segoe UI", 10f);

        // Board panel
        pnlBoard = new Panel
        {
            Size = new Size(390, 390),
            Location = new Point(30, 70),
            BackColor = Color.FromArgb(18, 18, 30)
        };

        // Right panel elements
        lblScoreTitle = new Label
        {
            Text = "СЧЁТ",
            Font = new Font("Segoe UI", 13f, FontStyle.Bold),
            ForeColor = Color.FromArgb(100, 200, 255),
            AutoSize = true,
            Location = new Point(470, 70)
        };

        lblScore1 = new Label
        {
            Text = "Игрок 1: 0",
            Font = new Font("Segoe UI", 11f),
            ForeColor = Color.FromArgb(255, 100, 100),
            AutoSize = true,
            Location = new Point(450, 105)
        };

        lblScore2 = new Label
        {
            Text = "Игрок 2: 0",
            Font = new Font("Segoe UI", 11f),
            ForeColor = Color.FromArgb(100, 200, 255),
            AutoSize = true,
            Location = new Point(450, 135)
        };

        var separator = new Panel
        {
            BackColor = Color.FromArgb(50, 50, 80),
            Size = new Size(270, 1),
            Location = new Point(450, 175)
        };

        lblStatus = new Label
        {
            Text = "",
            Font = new Font("Segoe UI", 12f, FontStyle.Bold),
            ForeColor = Color.White,
            AutoSize = false,
            Size = new Size(270, 60),
            Location = new Point(450, 185),
            TextAlign = ContentAlignment.MiddleLeft
        };

        // Top title
        var lblTitle = new Label
        {
            Text = "КРЕСТИКИ-НОЛИКИ",
            Font = new Font("Segoe UI", 16f, FontStyle.Bold),
            ForeColor = Color.FromArgb(100, 200, 255),
            AutoSize = true,
            Location = new Point(30, 20)
        };

        this.Controls.AddRange(new Control[]
        {
            lblTitle, pnlBoard,
            lblScoreTitle, lblScore1, lblScore2, separator,
            lblStatus, btnNewGame, btnResetScore, btnBackToMenu
        });

        this.ResumeLayout(false);
    }

    private static Button CreateSideButton(string text, Point location, Color backColor, Color foreColor)
    {
        var btn = new Button
        {
            Text = text,
            Size = new Size(270, 42),
            Location = location,
            FlatStyle = FlatStyle.Flat,
            BackColor = backColor,
            ForeColor = foreColor,
            Font = new Font("Segoe UI", 10f, FontStyle.Bold),
            Cursor = Cursors.Hand,
            TextAlign = ContentAlignment.MiddleLeft,
            Padding = new Padding(10, 0, 0, 0)
        };
        btn.FlatAppearance.BorderSize = 0;
        return btn;
    }
}
