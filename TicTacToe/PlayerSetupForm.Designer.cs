using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe;

partial class PlayerSetupForm
{
    private System.ComponentModel.IContainer components = null;

    private Label lblTitle;
    internal Label lblPlayer1Name;
    internal Label lblPlayer2Name;
    private Label lblSymbol;
    internal System.Windows.Forms.TextBox txtPlayer1Name;
    internal System.Windows.Forms.TextBox txtPlayer2Name;
    internal ComboBox cmbSymbol;
    private Button btnOk;
    private Button btnCancel;
    private Panel separator;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.lblTitle = new Label();
        this.lblPlayer1Name = new Label();
        this.lblPlayer2Name = new Label();
        this.lblSymbol = new Label();
        this.txtPlayer1Name = new System.Windows.Forms.TextBox();
        this.txtPlayer2Name = new System.Windows.Forms.TextBox();
        this.cmbSymbol = new ComboBox();
        this.separator = new Panel();
        this.btnOk = new Button();
        this.btnCancel = new Button();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.AutoSize = false;
        this.lblTitle.Font = new Font("Segoe UI", 14f, FontStyle.Bold);
        this.lblTitle.ForeColor = Color.FromArgb(100, 200, 255);
        this.lblTitle.Location = new Point(20, 15);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new Size(380, 40);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Данные игрока";
        this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

        // lblPlayer1Name
        this.lblPlayer1Name.AutoSize = true;
        this.lblPlayer1Name.ForeColor = Color.FromArgb(160, 160, 200);
        this.lblPlayer1Name.Location = new Point(30, 70);
        this.lblPlayer1Name.Name = "lblPlayer1Name";
        this.lblPlayer1Name.TabIndex = 1;
        this.lblPlayer1Name.Text = "Имя игрока 1:";

        // txtPlayer1Name
        this.txtPlayer1Name.BackColor = Color.FromArgb(40, 40, 60);
        this.txtPlayer1Name.BorderStyle = BorderStyle.FixedSingle;
        this.txtPlayer1Name.Font = new Font("Segoe UI", 10f);
        this.txtPlayer1Name.ForeColor = Color.White;
        this.txtPlayer1Name.Location = new Point(180, 67);
        this.txtPlayer1Name.Name = "txtPlayer1Name";
        this.txtPlayer1Name.Size = new Size(180, 28);
        this.txtPlayer1Name.TabIndex = 2;

        // lblPlayer2Name
        this.lblPlayer2Name.AutoSize = true;
        this.lblPlayer2Name.ForeColor = Color.FromArgb(160, 160, 200);
        this.lblPlayer2Name.Location = new Point(30, 110);
        this.lblPlayer2Name.Name = "lblPlayer2Name";
        this.lblPlayer2Name.TabIndex = 3;
        this.lblPlayer2Name.Text = "Имя игрока 2:";

        // txtPlayer2Name
        this.txtPlayer2Name.BackColor = Color.FromArgb(40, 40, 60);
        this.txtPlayer2Name.BorderStyle = BorderStyle.FixedSingle;
        this.txtPlayer2Name.Font = new Font("Segoe UI", 10f);
        this.txtPlayer2Name.ForeColor = Color.White;
        this.txtPlayer2Name.Location = new Point(180, 107);
        this.txtPlayer2Name.Name = "txtPlayer2Name";
        this.txtPlayer2Name.Size = new Size(180, 28);
        this.txtPlayer2Name.TabIndex = 4;

        // lblSymbol
        this.lblSymbol.AutoSize = true;
        this.lblSymbol.ForeColor = Color.FromArgb(160, 160, 200);
        this.lblSymbol.Location = new Point(30, 150);
        this.lblSymbol.Name = "lblSymbol";
        this.lblSymbol.TabIndex = 5;
        this.lblSymbol.Text = "Символ игрока 1:";

        // cmbSymbol
        this.cmbSymbol.BackColor = Color.FromArgb(40, 40, 60);
        this.cmbSymbol.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbSymbol.FlatStyle = FlatStyle.Flat;
        this.cmbSymbol.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
        this.cmbSymbol.ForeColor = Color.White;
        this.cmbSymbol.Items.AddRange(new object[] { "X", "O" });
        this.cmbSymbol.Location = new Point(180, 147);
        this.cmbSymbol.Name = "cmbSymbol";
        this.cmbSymbol.Size = new Size(80, 28);
        this.cmbSymbol.TabIndex = 6;
        this.cmbSymbol.SelectedIndex = 0;

        // separator
        this.separator.BackColor = Color.FromArgb(60, 60, 90);
        this.separator.Location = new Point(30, 200);
        this.separator.Name = "separator";
        this.separator.Size = new Size(360, 1);
        this.separator.TabIndex = 7;

        // btnOk
        this.btnOk.BackColor = Color.FromArgb(100, 200, 255);
        this.btnOk.Cursor = Cursors.Hand;
        this.btnOk.FlatStyle = FlatStyle.Flat;
        this.btnOk.FlatAppearance.BorderSize = 0;
        this.btnOk.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
        this.btnOk.ForeColor = Color.FromArgb(18, 18, 30);
        this.btnOk.Location = new Point(30, 220);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new Size(150, 42);
        this.btnOk.TabIndex = 8;
        this.btnOk.Text = "Начать игру";
        this.btnOk.Click += new System.EventHandler(this.btnOk_Click);

        // btnCancel
        this.btnCancel.BackColor = Color.FromArgb(50, 50, 70);
        this.btnCancel.Cursor = Cursors.Hand;
        this.btnCancel.FlatStyle = FlatStyle.Flat;
        this.btnCancel.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 110);
        this.btnCancel.FlatAppearance.BorderSize = 1;
        this.btnCancel.Font = new Font("Segoe UI", 10f);
        this.btnCancel.ForeColor = Color.FromArgb(160, 160, 200);
        this.btnCancel.Location = new Point(210, 220);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(150, 42);
        this.btnCancel.TabIndex = 9;
        this.btnCancel.Text = "Отмена";
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

        // PlayerSetupForm
        this.AcceptButton = this.btnOk;
        this.BackColor = Color.FromArgb(22, 22, 38);
        this.CancelButton = this.btnCancel;
        this.ClientSize = new Size(420, 300);
        this.Controls.Add(this.lblTitle);
        this.Controls.Add(this.lblPlayer1Name);
        this.Controls.Add(this.txtPlayer1Name);
        this.Controls.Add(this.lblPlayer2Name);
        this.Controls.Add(this.txtPlayer2Name);
        this.Controls.Add(this.lblSymbol);
        this.Controls.Add(this.cmbSymbol);
        this.Controls.Add(this.separator);
        this.Controls.Add(this.btnOk);
        this.Controls.Add(this.btnCancel);
        this.Font = new Font("Segoe UI", 10f);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "PlayerSetupForm";
        this.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Настройка игроков";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}
