using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CarsharingApp
{
    public partial class UserLoginForm : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Carsharing.accdb;";

        public UserLoginForm()
        {
            InitializeComponent();
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnSwitchToAdmin.Click += new System.EventHandler(this.btnSwitchToAdmin_Click);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Введите email и пароль водителя!", "Предупреждение");
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Пользователи WHERE Почта=? AND Пароль=?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@p1", txtEmail.Text);
                        command.Parameters.AddWithValue("@p2", txtPassword.Text);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            this.Hide();
                            UserRentalForm userWindow = new UserRentalForm();
                            userWindow.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка! Неверный email/пароль или аккаунт водителя не существует.", "Ошибка входа");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message, "Ошибка");
            }
        }

        private void btnSwitchToAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm adminLogin = new LoginForm();
            adminLogin.ShowDialog();
            this.Close();
        }
    }
}
