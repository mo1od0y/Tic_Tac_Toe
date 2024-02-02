using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;
using static System.Windows.Forms.DataFormats;

namespace TicTacToe
{
    public partial class FrmAutorization1 : Form
    {
        private object loginField;

        public FrmAutorization1()
        {
            InitializeComponent();
        }


        private void panelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelAutorization_Click(object sender, EventArgs e)
        {
            String loginUser = textBoxLogin.Text;
            String passUser = textBoxPassword.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                FrmTicTacToe MainForm = new FrmTicTacToe();
                MainForm.Show();
            }
            else
                MessageBox.Show("No");

        }

        private void labelAutorization_Click(object sender, EventArgs e)
        {
            String loginUser = textBoxLogin.Text;
            String passUser = textBoxPassword.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                FrmTicTacToe MainForm = new FrmTicTacToe();
                MainForm.Show();
            }
            else
                MessageBox.Show("No");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistration MainForm = new FrmRegistration();
            MainForm.Show();
        }

    }
}
