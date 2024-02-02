namespace TicTacToe
{
    partial class FrmAutorization1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelClose = new Panel();
            labelClose = new Label();
            labelLogin = new Label();
            labelPassword = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            labelLog = new Label();
            panelLoginto = new Panel();
            labelloginto = new Label();
            label1 = new Label();
            panelClose.SuspendLayout();
            panelLoginto.SuspendLayout();
            SuspendLayout();
            // 
            // panelClose
            // 
            panelClose.BackColor = Color.Indigo;
            panelClose.Controls.Add(labelClose);
            panelClose.Location = new Point(446, 12);
            panelClose.Name = "panelClose";
            panelClose.Size = new Size(42, 42);
            panelClose.TabIndex = 0;
            // 
            // labelClose
            // 
            labelClose.AutoSize = true;
            labelClose.Font = new Font("Ebrima", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelClose.ForeColor = Color.White;
            labelClose.Location = new Point(9, 8);
            labelClose.Name = "labelClose";
            labelClose.Size = new Size(24, 25);
            labelClose.TabIndex = 0;
            labelClose.Text = "X";
            labelClose.Click += labelClose_Click;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.White;
            labelLogin.Location = new Point(12, 93);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(107, 37);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Логин:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(12, 149);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(126, 37);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Пароль:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(165, 93);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(210, 35);
            textBoxLogin.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(165, 149);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(210, 35);
            textBoxPassword.TabIndex = 4;
            // 
            // labelLog
            // 
            labelLog.AutoSize = true;
            labelLog.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelLog.ForeColor = Color.White;
            labelLog.Location = new Point(202, 20);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(101, 37);
            labelLog.TabIndex = 5;
            labelLog.Text = "Войти";
            // 
            // panelLoginto
            // 
            panelLoginto.BackColor = Color.SlateBlue;
            panelLoginto.Controls.Add(labelloginto);
            panelLoginto.Location = new Point(125, 210);
            panelLoginto.Name = "panelLoginto";
            panelLoginto.Size = new Size(251, 51);
            panelLoginto.TabIndex = 6;
            panelLoginto.Click += panelAutorization_Click;
            // 
            // labelloginto
            // 
            labelloginto.AutoSize = true;
            labelloginto.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelloginto.ForeColor = Color.White;
            labelloginto.Location = new Point(4, 4);
            labelloginto.Name = "labelloginto";
            labelloginto.Size = new Size(243, 37);
            labelloginto.TabIndex = 0;
            labelloginto.Text = "Авторизоваться";
            labelloginto.Click += labelAutorization_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(178, 270);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 7;
            label1.Text = "Ещё нет аккаунта?";
            label1.Click += label1_Click;
            // 
            // FrmAutorization1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(500, 300);
            Controls.Add(label1);
            Controls.Add(panelLoginto);
            Controls.Add(labelLog);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(panelClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAutorization1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAutorization";
            panelClose.ResumeLayout(false);
            panelClose.PerformLayout();
            panelLoginto.ResumeLayout(false);
            panelLoginto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelClose;
        private Label labelLogin;
        private Label labelPassword;
        private Label labelClose;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label labelLog;
        private Panel panelLoginto;
        private Label labelloginto;
        private Label label1;
    }
}