using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CarsharingApp
{
    public partial class RentalsForm : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Carsharing.accdb;";

        public RentalsForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.RentalsForm_Load);
        }

        private void LoadBookings()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Бронирования.Код, Пользователи.ФИО, Автомобили.Марка, Автомобили.Модель, Бронирования.Дата_Начала, Бронирования.Дата_Окончания, Бронирования.Статус " +
                                   "FROM (Бронирования INNER JOIN Пользователи ON Бронирования.Код_Пользователя = Пользователи.Код) " +
                                   "INNER JOIN Автомобили ON Бронирования.Код_Автомобиля = Автомобили.Код";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvBookings.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки бронирований: " + ex.Message, "Ошибка");
            }
        }

        private void LoadRentals()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Аренда.Код, Пользователи.ФИО, Автомобили.Марка, Автомобили.Модель, Тарифы.Название AS Тариф, Аренда.Дата_Начала, Аренда.Дата_Окончания, Аренда.Время_Аренды, Аренда.Стоимость, Аренда.Статус " +
                                   "FROM ((Аренда INNER JOIN Пользователи ON Аренда.Код_Пользователя = Пользователи.Код) " +
                                   "INNER JOIN Автомобили ON Аренда.Код_Автомобиля = Автомобили.Код) " +
                                   "INNER JOIN Тарифы ON Аренда.Код_Тарифа = Тарифы.Код";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvRentals.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки поездок: " + ex.Message, "Ошибка");
            }
        }

        private void RentalsForm_Load(object sender, EventArgs e)
        {
            LoadBookings();
            LoadRentals();
        }
    }
}
