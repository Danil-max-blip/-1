using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CarsharingApp
{
    public partial class UsersForm : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Carsharing.accdb;";

        public UsersForm()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);

            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
        }

        private void RefreshGrid()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Код, ФИО, Телефон, Почта, Пароль, Водительское_Удостоверение FROM Пользователи";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvUsers.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message, "Ошибка");
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtLicense.Text))
            {
                MessageBox.Show("Заполните обязательные поля: ФИО, Телефон, Водительское удостоверение!", "Предупреждение");
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Пользователи (ФИО, Телефон, Почта, Пароль, Водительское_Удостоверение) VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@p1", txtFullName.Text);
                        command.Parameters.AddWithValue("@p2", txtPhone.Text);
                        command.Parameters.AddWithValue("@p3", txtEmail.Text);
                        command.Parameters.AddWithValue("@p4", txtPassword.Text);
                        command.Parameters.AddWithValue("@p5", txtLicense.Text);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Пользователь успешно зарегистрирован!", "Успех");
                RefreshGrid();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении: " + ex.Message, "Ошибка");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пользователя в таблице!", "Предупреждение");
                return;
            }

            int selectedId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["Код"].Value);

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Пользователи SET ФИО=?, Телефон=?, Почта=?, Пароль=?, Водительское_Удостоверение=? WHERE Код=?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@p1", txtFullName.Text);
                        command.Parameters.AddWithValue("@p2", txtPhone.Text);
                        command.Parameters.AddWithValue("@p3", txtEmail.Text);
                        command.Parameters.AddWithValue("@p4", txtPassword.Text);
                        command.Parameters.AddWithValue("@p5", txtLicense.Text);
                        command.Parameters.AddWithValue("@id", selectedId);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Данные пользователя обновлены!", "Успех");
                RefreshGrid();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении: " + ex.Message, "Ошибка");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пользователя в таблице для удаления!", "Предупреждение");
                return;
            }

            var result = MessageBox.Show("Удалить выбранного пользователя из базы данных?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            int selectedId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["Код"].Value);

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Пользователи WHERE Код=?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", selectedId);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Пользователь успешно удален!", "Успех");
                RefreshGrid();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении: " + ex.Message, "Ошибка");
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvUsers.SelectedRows[0];
                txtFullName.Text = row.Cells["ФИО"].Value.ToString();
                txtPhone.Text = row.Cells["Телефон"].Value.ToString();
                txtEmail.Text = row.Cells["Почта"].Value.ToString();
                txtPassword.Text = row.Cells["Пароль"].Value.ToString();
                txtLicense.Text = row.Cells["Водительское_Удостоверение"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtLicense.Clear();
        }
    }
}
