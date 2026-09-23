using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CarsharingApp
{
    public partial class PaymentsForm : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Carsharing.accdb;";

        public PaymentsForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.PaymentsForm_Load);
        }

        private void LoadPayments()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Код, Сумма, Дата_Платежа, Способ_Оплаты, Статус FROM Платежи";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvPayments.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке платежей: " + ex.Message, "Ошибка");
            }
        }

        private void CalculateRevenue()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT SUM(Сумма) FROM Платежи WHERE Статус = 'Успешно'";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            decimal total = Convert.ToDecimal(result);
                            txtTotalRevenue.Text = total.ToString("C2");
                        }
                        else
                        {
                            txtTotalRevenue.Text = "0,00 ₽";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при расчете выручки: " + ex.Message, "Ошибка");
            }
        }

        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            LoadPayments();
            CalculateRevenue();
        }
    }
}
