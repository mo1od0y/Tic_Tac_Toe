namespace TicTacToe
{
    partial class FrmRegistration
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
            panelAutorization = new Panel();
            labelAutorization = new Label();
            labelReg = new Label();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            labelPassword = new Label();
            labelLogin = new Label();
            panelClose = new Panel();
            labelClose = new Label();
            label1 = new Label();
            panelAutorization.SuspendLayout();
            panelClose.SuspendLayout();
            SuspendLayout();
            // 
            // panelAutorization
            // 
            panelAutorization.BackColor = Color.SlateBlue;
            panelAutorization.Controls.Add(labelAutorization);
            panelAutorization.Location = new Point(100, 210);
            panelAutorization.Name = "panelAutorization";
            panelAutorization.Size = new Size(309, 51);
            panelAutorization.TabIndex = 13;
            panelAutorization.Click += panelAutorization_Click;
            // 
            // labelAutorization
            // 
            labelAutorization.AutoSize = true;
            labelAutorization.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelAutorization.ForeColor = Color.White;
            labelAutorization.Location = new Point(4, 4);
            labelAutorization.Name = "labelAutorization";
            labelAutorization.Size = new Size(306, 37);
            labelAutorization.TabIndex = 0;
            labelAutorization.Text = "Зарегистрироваться";
            labelAutorization.Click += labelAutorization_Click;
            // 
            // labelReg
            // 
            labelReg.AutoSize = true;
            labelReg.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelReg.ForeColor = Color.White;
            labelReg.Location = new Point(152, 20);
            labelReg.Name = "labelReg";
            labelReg.Size = new Size(196, 37);
            labelReg.TabIndex = 12;
            labelReg.Text = "Регистрация";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(165, 149);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(210, 35);
            textBoxPassword.TabIndex = 11;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(165, 93);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(210, 35);
            textBoxLogin.TabIndex = 10;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(12, 149);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(126, 37);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Пароль:";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.White;
            labelLogin.Location = new Point(12, 93);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(107, 37);
            labelLogin.TabIndex = 8;
            labelLogin.Text = "Логин:";
            // 
            // panelClose
            // 
            panelClose.BackColor = Color.Indigo;
            panelClose.Controls.Add(labelClose);
            panelClose.Location = new Point(446, 12);
            panelClose.Name = "panelClose";
            panelClose.Size = new Size(42, 42);
            panelClose.TabIndex = 7;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(193, 270);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 14;
            label1.Text = "Есть аккаунт? Войти";
            label1.Click += label1_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(500, 300);
            Controls.Add(label1);
            Controls.Add(panelAutorization);
            Controls.Add(labelReg);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(panelClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAutorization2";
            panelAutorization.ResumeLayout(false);
            panelAutorization.PerformLayout();
            panelClose.ResumeLayout(false);
            panelClose.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void panelAutorization_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelAutorization;
        private Label labelAutorization;
        private Label labelReg;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Label labelPassword;
        private Label labelLogin;
        private Panel panelClose;
        private Label labelClose;
        private Label label1;
    }
}