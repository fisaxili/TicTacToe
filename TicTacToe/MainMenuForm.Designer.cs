using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe;

partial class MainMenuForm
{
    private System.ComponentModel.IContainer components = null;

    private Label lblTitle;
    private Label lblSubtitle;
    private Button btnPlay;
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
        this.btnPlay = new Button();
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
        this.lblSubtitle.Text = "Игрок против игрока";
        this.lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;

        // btnPlay
        this.btnPlay.BackColor = Color.FromArgb(100, 200, 255);
        this.btnPlay.Cursor = Cursors.Hand;
        this.btnPlay.FlatStyle = FlatStyle.Flat;
        this.btnPlay.FlatAppearance.BorderSize = 0;
        this.btnPlay.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 220, 255);
        this.btnPlay.Font = new Font("Segoe UI", 13f, FontStyle.Bold);
        this.btnPlay.ForeColor = Color.FromArgb(18, 18, 30);
        this.btnPlay.Location = new Point(180, 200);
        this.btnPlay.Name = "btnPlay";
        this.btnPlay.Size = new Size(240, 60);
        this.btnPlay.TabIndex = 2;
        this.btnPlay.Text = "▶  Начать игру";
        this.btnPlay.TextAlign = ContentAlignment.MiddleCenter;
        this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);

        // lblVersion
        this.lblVersion.AutoSize = true;
        this.lblVersion.Font = new Font("Segoe UI", 8f);
        this.lblVersion.ForeColor = Color.FromArgb(80, 80, 100);
        this.lblVersion.Location = new Point(540, 430);
        this.lblVersion.Name = "lblVersion";
        this.lblVersion.TabIndex = 3;
        this.lblVersion.Text = "v1.0";

        // MainMenuForm
        this.BackColor = Color.FromArgb(18, 18, 30);
        this.ClientSize = new Size(600, 480);
        this.Controls.Add(this.lblTitle);
        this.Controls.Add(this.lblSubtitle);
        this.Controls.Add(this.btnPlay);
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
