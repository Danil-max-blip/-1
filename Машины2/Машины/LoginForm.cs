using System;
using System.Data.OleDb;
using System.Windows.Forms;
using Машины;

namespace CarsharingApp
{
    public partial class LoginForm : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Carsharing.accdb;";

        public LoginForm()
        {
            InitializeComponent();
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnSwitchToUser.Click += new System.EventHandler(this.btnSwitchToUser_Click);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Введите логин и пароль администратора!", "Предупреждение");
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Администраторы WHERE Логин=? AND Пароль=?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@p1", txtLogin.Text);
                        command.Parameters.AddWithValue("@p2", txtPassword.Text);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            this.Hide();
                            Form1 adminMenu = new Form1();
                            adminMenu.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка! Неверный логин/пароль или у вас нет прав Администратора.", "Ошибка доступа");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к базе: " + ex.Message, "Ошибка");
            }
        }

        private void btnSwitchToUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLoginForm userLogin = new UserLoginForm();
            userLogin.ShowDialog();
            this.Close();
        }
    }
}
