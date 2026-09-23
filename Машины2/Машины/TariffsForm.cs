using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CarsharingApp
{
    public partial class TariffsForm : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Carsharing.accdb;";

        public TariffsForm()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.TariffsForm_Load);
            this.dgvTariffs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTariffs_CellClick);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
        }

        private void RefreshGrid()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Код, Название, Стоимость_Минуты, Стоимость_Часа, Стоимость_Брони FROM Тарифы";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvTariffs.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке тарифов: " + ex.Message, "Ошибка");
            }
        }

        private void TariffsForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dgvTariffs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTariffs.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvTariffs.SelectedRows[0];
                txtName.Text = row.Cells["Название"].Value.ToString();
                txtMinuteCost.Text = row.Cells["Стоимость_Минуты"].Value.ToString();
                txtHourCost.Text = row.Cells["Стоимость_Часа"].Value.ToString();
                txtBookingCost.Text = row.Cells["Стоимость_Брони"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTariffs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите тариф в таблице для изменения!", "Предупреждение");
                return;
            }

            int selectedId = Convert.ToInt32(dgvTariffs.SelectedRows[0].Cells["Код"].Value);

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Тарифы SET Стоимость_Минуты=?, Стоимость_Часа=?, Стоимость_Брони=? WHERE Код=?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@p1", Convert.ToDecimal(txtMinuteCost.Text));
                        command.Parameters.AddWithValue("@p2", Convert.ToDecimal(txtHourCost.Text));
                        command.Parameters.AddWithValue("@p3", Convert.ToDecimal(txtBookingCost.Text));
                        command.Parameters.AddWithValue("@id", selectedId);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Параметры тарифа успешно обновлены!", "Успех");
                RefreshGrid();
                txtName.Clear();
                txtMinuteCost.Clear();
                txtHourCost.Clear();
                txtBookingCost.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении тарифа: " + ex.Message, "Ошибка");
            }
        }
    }
}
