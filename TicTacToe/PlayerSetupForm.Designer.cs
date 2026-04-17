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
        lblTitle = new Label();
        lblPlayer1Name = new Label();
        lblPlayer2Name = new Label();
        lblSymbol = new Label();
        txtPlayer1Name = new TextBox();
        txtPlayer2Name = new TextBox();
        cmbSymbol = new ComboBox();
        separator = new Panel();
        btnOk = new Button();
        btnCancel = new Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(100, 200, 255);
        lblTitle.Location = new Point(20, 15);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(380, 40);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Данные игрока";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblPlayer1Name
        // 
        lblPlayer1Name.AutoSize = true;
        lblPlayer1Name.ForeColor = Color.FromArgb(160, 160, 200);
        lblPlayer1Name.Location = new Point(30, 70);
        lblPlayer1Name.Name = "lblPlayer1Name";
        lblPlayer1Name.Size = new Size(121, 23);
        lblPlayer1Name.TabIndex = 1;
        lblPlayer1Name.Text = "Имя игрока 1:";
        // 
        // lblPlayer2Name
        // 
        lblPlayer2Name.AutoSize = true;
        lblPlayer2Name.ForeColor = Color.FromArgb(160, 160, 200);
        lblPlayer2Name.Location = new Point(30, 110);
        lblPlayer2Name.Name = "lblPlayer2Name";
        lblPlayer2Name.Size = new Size(121, 23);
        lblPlayer2Name.TabIndex = 3;
        lblPlayer2Name.Text = "Имя игрока 2:";
        // 
        // lblSymbol
        // 
        lblSymbol.AutoSize = true;
        lblSymbol.ForeColor = Color.FromArgb(160, 160, 200);
        lblSymbol.Location = new Point(30, 150);
        lblSymbol.Name = "lblSymbol";
        lblSymbol.Size = new Size(148, 23);
        lblSymbol.TabIndex = 5;
        lblSymbol.Text = "Символ игрока 1:";
        // 
        // txtPlayer1Name
        // 
        txtPlayer1Name.BackColor = Color.FromArgb(40, 40, 60);
        txtPlayer1Name.BorderStyle = BorderStyle.FixedSingle;
        txtPlayer1Name.Font = new Font("Segoe UI", 10F);
        txtPlayer1Name.ForeColor = Color.White;
        txtPlayer1Name.Location = new Point(180, 67);
        txtPlayer1Name.Name = "txtPlayer1Name";
        txtPlayer1Name.Size = new Size(180, 30);
        txtPlayer1Name.TabIndex = 2;
        // 
        // txtPlayer2Name
        // 
        txtPlayer2Name.BackColor = Color.FromArgb(40, 40, 60);
        txtPlayer2Name.BorderStyle = BorderStyle.FixedSingle;
        txtPlayer2Name.Font = new Font("Segoe UI", 10F);
        txtPlayer2Name.ForeColor = Color.White;
        txtPlayer2Name.Location = new Point(180, 107);
        txtPlayer2Name.Name = "txtPlayer2Name";
        txtPlayer2Name.Size = new Size(180, 30);
        txtPlayer2Name.TabIndex = 4;
        // 
        // cmbSymbol
        // 
        cmbSymbol.BackColor = Color.FromArgb(40, 40, 60);
        cmbSymbol.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSymbol.FlatStyle = FlatStyle.Flat;
        cmbSymbol.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        cmbSymbol.ForeColor = Color.White;
        cmbSymbol.Items.AddRange(new object[] { "X", "O" });
        cmbSymbol.Location = new Point(180, 145);
        cmbSymbol.Name = "cmbSymbol";
        cmbSymbol.Size = new Size(80, 33);
        cmbSymbol.TabIndex = 6;
        // 
        // separator
        // 
        separator.BackColor = Color.FromArgb(60, 60, 90);
        separator.Location = new Point(30, 200);
        separator.Name = "separator";
        separator.Size = new Size(360, 1);
        separator.TabIndex = 7;
        // 
        // btnOk
        // 
        btnOk.BackColor = Color.FromArgb(100, 200, 255);
        btnOk.Cursor = Cursors.Hand;
        btnOk.FlatAppearance.BorderSize = 0;
        btnOk.FlatStyle = FlatStyle.Flat;
        btnOk.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnOk.ForeColor = Color.FromArgb(18, 18, 30);
        btnOk.Location = new Point(30, 220);
        btnOk.Name = "btnOk";
        btnOk.Size = new Size(150, 42);
        btnOk.TabIndex = 8;
        btnOk.Text = "Начать игру";
        btnOk.UseVisualStyleBackColor = false;
        btnOk.Click += btnOk_Click;
        // 
        // btnCancel
        // 
        btnCancel.BackColor = Color.FromArgb(50, 50, 70);
        btnCancel.Cursor = Cursors.Hand;
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 110);
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.Font = new Font("Segoe UI", 10F);
        btnCancel.ForeColor = Color.FromArgb(160, 160, 200);
        btnCancel.Location = new Point(210, 220);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(150, 42);
        btnCancel.TabIndex = 9;
        btnCancel.Text = "Отмена";
        btnCancel.UseVisualStyleBackColor = false;
        btnCancel.Click += btnCancel_Click;
        // 
        // PlayerSetupForm
        // 
        AcceptButton = btnOk;
        BackColor = Color.FromArgb(22, 22, 38);
        CancelButton = btnCancel;
        ClientSize = new Size(420, 300);
        Controls.Add(lblTitle);
        Controls.Add(lblPlayer1Name);
        Controls.Add(txtPlayer1Name);
        Controls.Add(lblPlayer2Name);
        Controls.Add(txtPlayer2Name);
        Controls.Add(lblSymbol);
        Controls.Add(cmbSymbol);
        Controls.Add(separator);
        Controls.Add(btnOk);
        Controls.Add(btnCancel);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "PlayerSetupForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Настройка игроков";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
