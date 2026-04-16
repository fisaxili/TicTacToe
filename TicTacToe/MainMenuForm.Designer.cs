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
    private Label lblVersion;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.lblTitle = new Label();
        this.lblSubtitle = new Label();
        this.btnSinglePlayer = new Button();
        this.btnTwoPlayers = new Button();
        this.lblVersion = new Label();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.AutoSize = false;
        this.lblTitle.Font = new Font("Segoe UI", 26f, FontStyle.Bold);
        this.lblTitle.ForeColor = Color.FromArgb(100, 200, 255);
        this.lblTitle.Location = new Point(20, 50);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new Size(560, 70);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "КРЕСТИКИ-НОЛИКИ";
        this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

        // lblSubtitle
        this.lblSubtitle.AutoSize = false;
        this.lblSubtitle.Font = new Font("Segoe UI", 12f);
        this.lblSubtitle.ForeColor = Color.FromArgb(160, 160, 200);
        this.lblSubtitle.Location = new Point(20, 120);
        this.lblSubtitle.Name = "lblSubtitle";
        this.lblSubtitle.Size = new Size(560, 30);
        this.lblSubtitle.TabIndex = 1;
        this.lblSubtitle.Text = "Выберите режим игры";
        this.lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;

        // btnSinglePlayer
        this.btnSinglePlayer.BackColor = Color.FromArgb(30, 30, 50);
        this.btnSinglePlayer.Cursor = Cursors.Hand;
        this.btnSinglePlayer.FlatStyle = FlatStyle.Flat;
        this.btnSinglePlayer.FlatAppearance.BorderColor = Color.FromArgb(100, 200, 255);
        this.btnSinglePlayer.FlatAppearance.BorderSize = 2;
        this.btnSinglePlayer.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 80);
        this.btnSinglePlayer.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
        this.btnSinglePlayer.ForeColor = Color.White;
        this.btnSinglePlayer.Location = new Point(60, 190);
        this.btnSinglePlayer.Name = "btnSinglePlayer";
        this.btnSinglePlayer.Size = new Size(200, 160);
        this.btnSinglePlayer.TabIndex = 2;
        this.btnSinglePlayer.Text = "🤖  Один игрок\n\nПротив компьютера";
        this.btnSinglePlayer.TextAlign = ContentAlignment.MiddleCenter;
        this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);

        // btnTwoPlayers
        this.btnTwoPlayers.BackColor = Color.FromArgb(30, 30, 50);
        this.btnTwoPlayers.Cursor = Cursors.Hand;
        this.btnTwoPlayers.FlatStyle = FlatStyle.Flat;
        this.btnTwoPlayers.FlatAppearance.BorderColor = Color.FromArgb(100, 200, 255);
        this.btnTwoPlayers.FlatAppearance.BorderSize = 2;
        this.btnTwoPlayers.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 80);
        this.btnTwoPlayers.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
        this.btnTwoPlayers.ForeColor = Color.White;
        this.btnTwoPlayers.Location = new Point(320, 190);
        this.btnTwoPlayers.Name = "btnTwoPlayers";
        this.btnTwoPlayers.Size = new Size(200, 160);
        this.btnTwoPlayers.TabIndex = 3;
        this.btnTwoPlayers.Text = "👥  Два игрока\n\nИгрок против игрока";
        this.btnTwoPlayers.TextAlign = ContentAlignment.MiddleCenter;
        this.btnTwoPlayers.Click += new System.EventHandler(this.btnTwoPlayers_Click);

        // lblVersion
        this.lblVersion.AutoSize = true;
        this.lblVersion.Font = new Font("Segoe UI", 8f);
        this.lblVersion.ForeColor = Color.FromArgb(80, 80, 100);
        this.lblVersion.Location = new Point(540, 430);
        this.lblVersion.Name = "lblVersion";
        this.lblVersion.TabIndex = 4;
        this.lblVersion.Text = "v1.0";

        // MainMenuForm
        this.BackColor = Color.FromArgb(18, 18, 30);
        this.ClientSize = new Size(600, 480);
        this.Controls.Add(this.lblTitle);
        this.Controls.Add(this.lblSubtitle);
        this.Controls.Add(this.btnSinglePlayer);
        this.Controls.Add(this.btnTwoPlayers);
        this.Controls.Add(this.lblVersion);
        this.Font = new Font("Segoe UI", 10f);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "MainMenuForm";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Крестики-нолики";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}
