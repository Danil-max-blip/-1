using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CarsharingApp
{
    public partial class UserRentalForm : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Carsharing.accdb;";
        private int currentUserId = 1;
        private int activeRentalId = -1;
        private int activeCarId = -1;
        private decimal currentMinuteCost = 0;
        private string currentTariffName = "";
        private DateTime startTime;
        private Label lblTariffInfo;

        public UserRentalForm()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.UserRentalForm_Load);
            this.btnStartRental.Click += new System.EventHandler(this.btnStartRental_Click);
            this.btnEndRental.Click += new System.EventHandler(this.btnEndRental_Click);
            this.timerRental.Tick += new System.EventHandler(this.timerRental_Tick);
            this.cmbTariffs.SelectedIndexChanged += new System.EventHandler(this.cmbTariffs_SelectedIndexChanged);

            InitializeAdditionalComponents();
        }

        private void InitializeAdditionalComponents()
        {
            this.lblTariffInfo = new System.Windows.Forms.Label();
            this.lblTariffInfo.AutoSize = true;
            this.lblTariffInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblTariffInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTariffInfo.Location = new System.Drawing.Point(20, 275);
            this.lblTariffInfo.Name = "lblTariffInfo";
            this.lblTariffInfo.Size = new System.Drawing.Size(140, 19);
            this.lblTariffInfo.Text = "Параметры тарифа...";
            this.Controls.Add(this.lblTariffInfo);
        }

        private void LoadAvailableCars()
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

                        DataTable filteredDt = dt.Clone();
                        foreach (DataRow row in dt.Rows)
                        {
                            string status = row["Статус"].ToString().Trim();
                            int fuel = Convert.ToInt32(row["Уровень_Топлива"]);

                            if (status == "Свободна" && fuel > 0)
                            {
                                filteredDt.ImportRow(row);
                            }
                        }
                        dgvAvailableCars.DataSource = filteredDt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки машин: " + ex.Message, "Ошибка");
            }
        }

        private void LoadTariffs()
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

                        DataTable filteredDt = dt.Clone();
                        System.Collections.Generic.List<string> addedTariffs = new System.Collections.Generic.List<string>();

                        foreach (DataRow row in dt.Rows)
                        {
                            string name = row["Название"].ToString().Trim();
                            if (name != "Бизнес" && !addedTariffs.Contains(name))
                            {
                                addedTariffs.Add(name);
                                filteredDt.ImportRow(row);
                            }
                        }

                        cmbTariffs.DataSource = filteredDt;
                        cmbTariffs.DisplayMember = "Nazvanie";
                        if (filteredDt.Columns.Contains("Название")) cmbTariffs.DisplayMember = "Название";
                        cmbTariffs.ValueMember = "Код";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки тарифов: " + ex.Message, "Ошибка");
            }
        }

        private void UserRentalForm_Load(object sender, EventArgs e)
        {
            LoadAvailableCars();
            LoadTariffs();
            UpdateTariffDisplay();
        }

        private void cmbTariffs_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTariffDisplay();
        }

        private void UpdateTariffDisplay()
        {
            if (cmbTariffs.SelectedItem != null)
            {
                DataRowView row = (DataRowView)cmbTariffs.SelectedItem;
                currentTariffName = row["Название"].ToString();
                currentMinuteCost = Convert.ToDecimal(row["Стоимость_Минуты"]);
                decimal hourCost = Convert.ToDecimal(row["Стоимость_Часа"]);
                decimal bookingCost = Convert.ToDecimal(row["Стоимость_Брони"]);

                lblTariffInfo.Text = $"Цена: {currentMinuteCost:C2}/мин | {hourCost:C2}/час | Бронь: {bookingCost:C2}";
            }
        }

        private void btnStartRental_Click(object sender, EventArgs e)
        {
            if (dgvAvailableCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите автомобиль для поездки из списка!", "Предупреждение");
                return;
            }

            activeCarId = Convert.ToInt32(dgvAvailableCars.SelectedRows[0].Cells["Код"].Value);
            int tariffId = Convert.ToInt32(cmbTariffs.SelectedValue);
            startTime = DateTime.Now;

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string updateCarQuery = "UPDATE Автомобили SET Статус = 'В пути' WHERE Код = ?";
                    using (OleDbCommand cmd = new OleDbCommand(updateCarQuery, connection))
                    {
                        cmd.Parameters.Add("@id", OleDbType.Integer).Value = activeCarId;
                        cmd.ExecuteNonQuery();
                    }

                    string insertRentalQuery = "INSERT INTO Аренда (Код_Пользователя, Код_Автомобиля, Код_Тарифа, Дата_Начала, Статус) VALUES (?, ?, ?, ?, 'Активна')";
                    using (OleDbCommand cmd = new OleDbCommand(insertRentalQuery, connection))
                    {
                        cmd.Parameters.Add("@p1", OleDbType.Integer).Value = currentUserId;
                        cmd.Parameters.Add("@p2", OleDbType.Integer).Value = activeCarId;
                        cmd.Parameters.Add("@p3", OleDbType.Integer).Value = tariffId;
                        cmd.Parameters.Add("@p4", OleDbType.Date).Value = startTime;
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "SELECT @@IDENTITY";
                        activeRentalId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                btnStartRental.Enabled = false;
                btnEndRental.Enabled = true;
                cmbTariffs.Enabled = false;
                dgvAvailableCars.Enabled = false;

                lblCurrentRental.Visible = true;
                lblTimer.Visible = true;
                timerRental.Start();

                MessageBox.Show("Автомобиль успешно запущен. Приятной поездки!", "Каршеринг");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при старте поездки: " + ex.Message, "Ошибка");
            }
        }

        private void btnEndRental_Click(object sender, EventArgs e)
        {
            timerRental.Stop();
            DateTime endTime = DateTime.Now;
            TimeSpan duration = endTime - startTime;

            double totalMinutes = Math.Ceiling(duration.TotalMinutes);
            if (totalMinutes < 1) totalMinutes = 1;

            decimal totalCost = 0;

            if (currentTariffName.ToLower().Contains("суточн"))
            {
                totalCost = 2500;
            }
            else
            {
                totalCost = (decimal)totalMinutes * currentMinuteCost;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string insertPaymentQuery = "INSERT INTO Платежи (Сумма, Дата_Платежа, Способ_Оплаты, Статус) VALUES (?, ?, 'Карта', 'Успешно')";
                    int paymentId = -1;
                    using (OleDbCommand cmd = new OleDbCommand(insertPaymentQuery, connection))
                    {
                        cmd.Parameters.Add("@p1", OleDbType.Currency).Value = totalCost;
                        cmd.Parameters.Add("@p2", OleDbType.Date).Value = endTime;
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "SELECT @@IDENTITY";
                        paymentId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string updateRentalQuery = "UPDATE Аренда SET Дата_Окончания = ?, Время_Аренды = ?, Стоимость = ?, Код_Платежа = ?, Статус = 'Завершена' WHERE Код = ?";
                    using (OleDbCommand cmd = new OleDbCommand(updateRentalQuery, connection))
                    {
                        cmd.Parameters.Add("@p1", OleDbType.Date).Value = endTime;
                        cmd.Parameters.Add("@p2", OleDbType.VarChar).Value = currentTariffName.ToLower().Contains("суточн") ? "1 сутки" : $"{totalMinutes} мин";
                        cmd.Parameters.Add("@p3", OleDbType.Currency).Value = totalCost;
                        cmd.Parameters.Add("@p4", OleDbType.Integer).Value = paymentId;
                        cmd.Parameters.Add("@id", OleDbType.Integer).Value = activeRentalId;
                        cmd.ExecuteNonQuery();
                    }

                    string updateCarQuery = "UPDATE Автомобили SET Статус = 'Свободна', Уровень_Топлива = Уровень_Топлива - 3 WHERE Код = ?";
                    using (OleDbCommand cmd = new OleDbCommand(updateCarQuery, connection))
                    {
                        cmd.Parameters.Add("@id", OleDbType.Integer).Value = activeCarId;
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Поездка завершена!\nТариф: {currentTariffName}\nИтоговая стоимость: {totalCost:C2}\nЧек сформирован, оплата успешно списана.", "Детали поездки");

                btnStartRental.Enabled = true;
                btnEndRental.Enabled = false;
                cmbTariffs.Enabled = true;
                dgvAvailableCars.Enabled = true;
                lblCurrentRental.Visible = false;
                lblTimer.Visible = false;

                LoadAvailableCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при завершении поездки: " + ex.Message, "Ошибка");
            }
        }

        private void timerRental_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - startTime;
            lblTimer.Text = string.Format("{0:00}:{1:00}:{2:00}", elapsed.Hours, elapsed.Minutes, elapsed.Seconds);
        }
    }
}
