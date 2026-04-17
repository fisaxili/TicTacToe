using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe;

partial class GameForm
{
    private System.ComponentModel.IContainer components = null;

    private Panel pnlBoard;
    private Label lblTitle;
    private Label lblScoreTitle;
    private Label lblScore1;
    private Label lblScore2;
    private Panel separator;
    private Label lblStatus;
    private Button btnNewGame;
    private Button btnResetScore;
    private Button btnBackToMenu;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.pnlBoard = new Panel();
        this.lblTitle = new Label();
        this.lblScoreTitle = new Label();
        this.lblScore1 = new Label();
        this.lblScore2 = new Label();
        this.separator = new Panel();
        this.lblStatus = new Label();
        this.btnNewGame = new Button();
        this.btnResetScore = new Button();
        this.btnBackToMenu = new Button();
        this.SuspendLayout();

        // pnlBoard
        this.pnlBoard.BackColor = Color.FromArgb(18, 18, 30);
        this.pnlBoard.Location = new Point(30, 70);
        this.pnlBoard.Name = "pnlBoard";
        this.pnlBoard.Size = new Size(390, 390);
        this.pnlBoard.TabIndex = 0;

        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new Font("Segoe UI", 16f, FontStyle.Bold);
        this.lblTitle.ForeColor = Color.FromArgb(100, 200, 255);
        this.lblTitle.Location = new Point(30, 20);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.TabIndex = 1;
        this.lblTitle.Text = "КРЕСТИКИ-НОЛИКИ";

        // lblScoreTitle
        this.lblScoreTitle.AutoSize = true;
        this.lblScoreTitle.Font = new Font("Segoe UI", 13f, FontStyle.Bold);
        this.lblScoreTitle.ForeColor = Color.FromArgb(100, 200, 255);
        this.lblScoreTitle.Location = new Point(470, 70);
        this.lblScoreTitle.Name = "lblScoreTitle";
        this.lblScoreTitle.TabIndex = 2;
        this.lblScoreTitle.Text = "СЧЁТ";

        // lblScore1
        this.lblScore1.AutoSize = true;
        this.lblScore1.Font = new Font("Segoe UI", 11f);
        this.lblScore1.ForeColor = Color.FromArgb(255, 100, 100);
        this.lblScore1.Location = new Point(450, 105);
        this.lblScore1.Name = "lblScore1";
        this.lblScore1.TabIndex = 3;
        this.lblScore1.Text = "Игрок 1: 0";

        // lblScore2
        this.lblScore2.AutoSize = true;
        this.lblScore2.Font = new Font("Segoe UI", 11f);
        this.lblScore2.ForeColor = Color.FromArgb(100, 200, 255);
        this.lblScore2.Location = new Point(450, 135);
        this.lblScore2.Name = "lblScore2";
        this.lblScore2.TabIndex = 4;
        this.lblScore2.Text = "Игрок 2: 0";

        // separator
        this.separator.BackColor = Color.FromArgb(50, 50, 80);
        this.separator.Location = new Point(450, 175);
        this.separator.Name = "separator";
        this.separator.Size = new Size(270, 1);
        this.separator.TabIndex = 5;

        // lblStatus
        this.lblStatus.AutoSize = false;
        this.lblStatus.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
        this.lblStatus.ForeColor = Color.White;
        this.lblStatus.Location = new Point(450, 185);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new Size(270, 60);
        this.lblStatus.TabIndex = 6;
        this.lblStatus.TextAlign = ContentAlignment.MiddleLeft;

        // btnNewGame
        this.btnNewGame.BackColor = Color.FromArgb(100, 200, 255);
        this.btnNewGame.Cursor = Cursors.Hand;
        this.btnNewGame.FlatStyle = FlatStyle.Flat;
        this.btnNewGame.FlatAppearance.BorderSize = 0;
        this.btnNewGame.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
        this.btnNewGame.ForeColor = Color.FromArgb(18, 18, 30);
        this.btnNewGame.Location = new Point(450, 310);
        this.btnNewGame.Name = "btnNewGame";
        this.btnNewGame.Padding = new Padding(10, 0, 0, 0);
        this.btnNewGame.Size = new Size(270, 42);
        this.btnNewGame.TabIndex = 7;
        this.btnNewGame.Text = "🔄  Новая игра";
        this.btnNewGame.TextAlign = ContentAlignment.MiddleLeft;
        this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);

        // btnResetScore
        this.btnResetScore.BackColor = Color.FromArgb(50, 50, 70);
        this.btnResetScore.Cursor = Cursors.Hand;
        this.btnResetScore.FlatStyle = FlatStyle.Flat;
        this.btnResetScore.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 110);
        this.btnResetScore.FlatAppearance.BorderSize = 1;
        this.btnResetScore.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
        this.btnResetScore.ForeColor = Color.FromArgb(160, 160, 200);
        this.btnResetScore.Location = new Point(450, 365);
        this.btnResetScore.Name = "btnResetScore";
        this.btnResetScore.Padding = new Padding(10, 0, 0, 0);
        this.btnResetScore.Size = new Size(270, 42);
        this.btnResetScore.TabIndex = 8;
        this.btnResetScore.Text = "🗑  Сбросить счёт";
        this.btnResetScore.TextAlign = ContentAlignment.MiddleLeft;
        this.btnResetScore.Click += new System.EventHandler(this.btnResetScore_Click);

        // btnBackToMenu
        this.btnBackToMenu.BackColor = Color.FromArgb(40, 40, 60);
        this.btnBackToMenu.Cursor = Cursors.Hand;
        this.btnBackToMenu.FlatStyle = FlatStyle.Flat;
        this.btnBackToMenu.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 100);
        this.btnBackToMenu.FlatAppearance.BorderSize = 1;
        this.btnBackToMenu.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
        this.btnBackToMenu.ForeColor = Color.FromArgb(120, 120, 160);
        this.btnBackToMenu.Location = new Point(450, 420);
        this.btnBackToMenu.Name = "btnBackToMenu";
        this.btnBackToMenu.Padding = new Padding(10, 0, 0, 0);
        this.btnBackToMenu.Size = new Size(270, 42);
        this.btnBackToMenu.TabIndex = 9;
        this.btnBackToMenu.Text = "← Главное меню";
        this.btnBackToMenu.TextAlign = ContentAlignment.MiddleLeft;
        this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);

        // GameForm
        this.BackColor = Color.FromArgb(18, 18, 30);
        this.ClientSize = new Size(780, 520);
        this.Controls.Add(this.pnlBoard);
        this.Controls.Add(this.lblTitle);
        this.Controls.Add(this.lblScoreTitle);
        this.Controls.Add(this.lblScore1);
        this.Controls.Add(this.lblScore2);
        this.Controls.Add(this.separator);
        this.Controls.Add(this.lblStatus);
        this.Controls.Add(this.btnNewGame);
        this.Controls.Add(this.btnResetScore);
        this.Controls.Add(this.btnBackToMenu);
        this.Font = new Font("Segoe UI", 10f);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "GameForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Крестики-нолики — Игра";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}
