using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe;

partial class MainMenuForm
{
    private System.ComponentModel.IContainer components = null;

    private Label lblTitle;
    private Label lblSubtitle;
    private Button btnSinglePlayer;
    private Button btnTwoPlayers;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblSubtitle = new Label();
        btnSinglePlayer = new Button();
        btnTwoPlayers = new Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(100, 200, 255);
        lblTitle.Location = new Point(20, 50);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(560, 70);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "КРЕСТИКИ-НОЛИКИ";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblSubtitle
        // 
        lblSubtitle.Font = new Font("Segoe UI", 12F);
        lblSubtitle.ForeColor = Color.FromArgb(160, 160, 200);
        lblSubtitle.Location = new Point(20, 120);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(560, 30);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Выберите режим игры";
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnSinglePlayer
        // 
        btnSinglePlayer.BackColor = Color.FromArgb(30, 30, 50);
        btnSinglePlayer.Cursor = Cursors.Hand;
        btnSinglePlayer.FlatAppearance.BorderColor = Color.FromArgb(100, 200, 255);
        btnSinglePlayer.FlatAppearance.BorderSize = 2;
        btnSinglePlayer.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 80);
        btnSinglePlayer.FlatStyle = FlatStyle.Flat;
        btnSinglePlayer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnSinglePlayer.ForeColor = Color.White;
        btnSinglePlayer.Location = new Point(60, 190);
        btnSinglePlayer.Name = "btnSinglePlayer";
        btnSinglePlayer.Size = new Size(200, 160);
        btnSinglePlayer.TabIndex = 2;
        btnSinglePlayer.Text = "🤖  Один игрок\n\nПротив компьютера";
        btnSinglePlayer.UseVisualStyleBackColor = false;
        btnSinglePlayer.Click += btnSinglePlayer_Click;
        // 
        // btnTwoPlayers
        // 
        btnTwoPlayers.BackColor = Color.FromArgb(30, 30, 50);
        btnTwoPlayers.Cursor = Cursors.Hand;
        btnTwoPlayers.FlatAppearance.BorderColor = Color.FromArgb(100, 200, 255);
        btnTwoPlayers.FlatAppearance.BorderSize = 2;
        btnTwoPlayers.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 80);
        btnTwoPlayers.FlatStyle = FlatStyle.Flat;
        btnTwoPlayers.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnTwoPlayers.ForeColor = Color.White;
        btnTwoPlayers.Location = new Point(320, 190);
        btnTwoPlayers.Name = "btnTwoPlayers";
        btnTwoPlayers.Size = new Size(200, 160);
        btnTwoPlayers.TabIndex = 3;
        btnTwoPlayers.Text = "👥  Два игрока\n\nИгрок против игрока";
        btnTwoPlayers.UseVisualStyleBackColor = false;
        btnTwoPlayers.Click += btnTwoPlayers_Click;
        // 
        // MainMenuForm
        // 
        BackColor = Color.FromArgb(18, 18, 30);
        ClientSize = new Size(600, 480);
        Controls.Add(lblTitle);
        Controls.Add(lblSubtitle);
        Controls.Add(btnSinglePlayer);
        Controls.Add(btnTwoPlayers);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainMenuForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Крестики-нолики";
        ResumeLayout(false);
    }

    #endregion
}
