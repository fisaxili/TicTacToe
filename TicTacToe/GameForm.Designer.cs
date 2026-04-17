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
        pnlBoard = new Panel();
        lblTitle = new Label();
        lblScoreTitle = new Label();
        lblScore1 = new Label();
        lblScore2 = new Label();
        separator = new Panel();
        lblStatus = new Label();
        btnNewGame = new Button();
        btnResetScore = new Button();
        btnBackToMenu = new Button();
        SuspendLayout();
        // 
        // pnlBoard
        // 
        pnlBoard.BackColor = Color.FromArgb(18, 18, 30);
        pnlBoard.Location = new Point(30, 70);
        pnlBoard.Name = "pnlBoard";
        pnlBoard.Size = new Size(390, 390);
        pnlBoard.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(100, 200, 255);
        lblTitle.Location = new Point(30, 20);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(291, 37);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "КРЕСТИКИ-НОЛИКИ";
        // 
        // lblScoreTitle
        // 
        lblScoreTitle.AutoSize = true;
        lblScoreTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblScoreTitle.ForeColor = Color.FromArgb(100, 200, 255);
        lblScoreTitle.Location = new Point(450, 70);
        lblScoreTitle.Name = "lblScoreTitle";
        lblScoreTitle.Size = new Size(68, 30);
        lblScoreTitle.TabIndex = 2;
        lblScoreTitle.Text = "СЧЁТ";
        // 
        // lblScore1
        // 
        lblScore1.AutoSize = true;
        lblScore1.Font = new Font("Segoe UI", 11F);
        lblScore1.ForeColor = Color.FromArgb(255, 100, 100);
        lblScore1.Location = new Point(450, 105);
        lblScore1.Name = "lblScore1";
        lblScore1.Size = new Size(98, 25);
        lblScore1.TabIndex = 3;
        lblScore1.Text = "Игрок 1: 0";
        // 
        // lblScore2
        // 
        lblScore2.AutoSize = true;
        lblScore2.Font = new Font("Segoe UI", 11F);
        lblScore2.ForeColor = Color.FromArgb(100, 200, 255);
        lblScore2.Location = new Point(450, 135);
        lblScore2.Name = "lblScore2";
        lblScore2.Size = new Size(98, 25);
        lblScore2.TabIndex = 4;
        lblScore2.Text = "Игрок 2: 0";
        // 
        // separator
        // 
        separator.BackColor = Color.FromArgb(50, 50, 80);
        separator.Location = new Point(450, 175);
        separator.Name = "separator";
        separator.Size = new Size(270, 1);
        separator.TabIndex = 5;
        // 
        // lblStatus
        // 
        lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblStatus.ForeColor = Color.White;
        lblStatus.Location = new Point(450, 185);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(270, 60);
        lblStatus.TabIndex = 6;
        lblStatus.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnNewGame
        // 
        btnNewGame.BackColor = Color.FromArgb(100, 200, 255);
        btnNewGame.Cursor = Cursors.Hand;
        btnNewGame.FlatAppearance.BorderSize = 0;
        btnNewGame.FlatStyle = FlatStyle.Flat;
        btnNewGame.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnNewGame.ForeColor = Color.FromArgb(18, 18, 30);
        btnNewGame.Location = new Point(450, 310);
        btnNewGame.Name = "btnNewGame";
        btnNewGame.Padding = new Padding(10, 0, 0, 0);
        btnNewGame.Size = new Size(270, 42);
        btnNewGame.TabIndex = 7;
        btnNewGame.Text = "🔄  Новая игра";
        btnNewGame.TextAlign = ContentAlignment.MiddleLeft;
        btnNewGame.UseVisualStyleBackColor = false;
        btnNewGame.Click += btnNewGame_Click;
        // 
        // btnResetScore
        // 
        btnResetScore.BackColor = Color.FromArgb(50, 50, 70);
        btnResetScore.Cursor = Cursors.Hand;
        btnResetScore.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 110);
        btnResetScore.FlatStyle = FlatStyle.Flat;
        btnResetScore.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnResetScore.ForeColor = Color.FromArgb(160, 160, 200);
        btnResetScore.Location = new Point(450, 365);
        btnResetScore.Name = "btnResetScore";
        btnResetScore.Padding = new Padding(10, 0, 0, 0);
        btnResetScore.Size = new Size(270, 42);
        btnResetScore.TabIndex = 8;
        btnResetScore.Text = "🗑  Сбросить счёт";
        btnResetScore.TextAlign = ContentAlignment.MiddleLeft;
        btnResetScore.UseVisualStyleBackColor = false;
        btnResetScore.Click += btnResetScore_Click;
        // 
        // btnBackToMenu
        // 
        btnBackToMenu.BackColor = Color.FromArgb(40, 40, 60);
        btnBackToMenu.Cursor = Cursors.Hand;
        btnBackToMenu.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 100);
        btnBackToMenu.FlatStyle = FlatStyle.Flat;
        btnBackToMenu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnBackToMenu.ForeColor = Color.FromArgb(120, 120, 160);
        btnBackToMenu.Location = new Point(450, 420);
        btnBackToMenu.Name = "btnBackToMenu";
        btnBackToMenu.Padding = new Padding(10, 0, 0, 0);
        btnBackToMenu.Size = new Size(270, 42);
        btnBackToMenu.TabIndex = 9;
        btnBackToMenu.Text = "← Главное меню";
        btnBackToMenu.TextAlign = ContentAlignment.MiddleLeft;
        btnBackToMenu.UseVisualStyleBackColor = false;
        btnBackToMenu.Click += btnBackToMenu_Click;
        // 
        // GameForm
        // 
        BackColor = Color.FromArgb(18, 18, 30);
        ClientSize = new Size(780, 520);
        Controls.Add(pnlBoard);
        Controls.Add(lblTitle);
        Controls.Add(lblScoreTitle);
        Controls.Add(lblScore1);
        Controls.Add(lblScore2);
        Controls.Add(separator);
        Controls.Add(lblStatus);
        Controls.Add(btnNewGame);
        Controls.Add(btnResetScore);
        Controls.Add(btnBackToMenu);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "GameForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Крестики-нолики — Игра";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
