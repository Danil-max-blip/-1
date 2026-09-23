using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CarsharingApp
{
    public partial class CarsForm : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Carsharing.accdb;";

        public CarsForm()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.CarsForm_Load);
            this.dgvCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellClick);

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
                    string query = "SELECT Код, Марка, Модель, Госномер, Цвет, Статус, Уровень_Топлива FROM Автомобили";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvCars.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message, "Ошибка");
            }
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrand.Text) || string.IsNullOrEmpty(txtModel.Text) || string.IsNullOrEmpty(txtNumber.Text))
            {
                MessageBox.Show("Заполните обязательные поля: Марка, Модель, Госномер!", "Предупреждение");
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Автомобили (Марка, Модель, Госномер, Цвет, Статус, Уровень_Топлива) VALUES (?, ?, ?, ?, ?, ?)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@p1", txtBrand.Text);
                        command.Parameters.AddWithValue("@p2", txtModel.Text);
                        command.Parameters.AddWithValue("@p3", txtNumber.Text);
                        command.Parameters.AddWithValue("@p4", txtColor.Text);
                        command.Parameters.AddWithValue("@p5", cmbStatus.SelectedItem?.ToString() ?? "Свободна");
                        command.Parameters.AddWithValue("@p6", (int)numFuel.Value);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Автомобиль успешно добавлен в базу!", "Успех");
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
            if (dgvCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку с автомобилем в таблице!", "Предупреждение");
                return;
            }

            int selectedId = Convert.ToInt32(dgvCars.SelectedRows[0].Cells["Код"].Value);

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Автомобили SET Марка=?, Модель=?, Госномер=?, Цвет=?, Статус=?, Уровень_Топлива=? WHERE Код=?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@p1", txtBrand.Text);
                        command.Parameters.AddWithValue("@p2", txtModel.Text);
                        command.Parameters.AddWithValue("@p3", txtNumber.Text);
                        command.Parameters.AddWithValue("@p4", txtColor.Text);
                        command.Parameters.AddWithValue("@p5", cmbStatus.SelectedItem?.ToString() ?? "Свободна");
                        command.Parameters.AddWithValue("@p6", (int)numFuel.Value);
                        command.Parameters.AddWithValue("@id", selectedId);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Данные автомобиля успешно обновлены!", "Успех");
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
            if (dgvCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите автомобиль в таблице для удаления!", "Предупреждение");
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите окончательно удалить этот автомобиль?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            int selectedId = Convert.ToInt32(dgvCars.SelectedRows[0].Cells["Код"].Value);

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Автомобили WHERE Код=?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", selectedId);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Автомобиль удален из базы данных!", "Успех");
                RefreshGrid();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении: " + ex.Message, "Ошибка");
            }
        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCars.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCars.SelectedRows[0];
                txtBrand.Text = row.Cells["Марка"].Value.ToString();
                txtModel.Text = row.Cells["Модель"].Value.ToString();
                txtNumber.Text = row.Cells["Госномер"].Value.ToString();
                txtColor.Text = row.Cells["Цвет"].Value.ToString();

                string status = row.Cells["Статус"].Value.ToString();
                if (cmbStatus.Items.Contains(status)) cmbStatus.SelectedItem = status;

                numFuel.Value = Convert.ToDecimal(row.Cells["Уровень_Топлива"].Value);
            }
        }

        private void ClearFields()
        {
            txtBrand.Clear();
            txtModel.Clear();
            txtNumber.Clear();
            txtColor.Clear();
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;
            numFuel.Value = 100;
        }
    }
}
