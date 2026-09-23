namespace CarsharingApp
{
    partial class UserRentalForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvAvailableCars = new System.Windows.Forms.DataGridView();
            this.cmbTariffs = new System.Windows.Forms.ComboBox();
            this.lblSelectTariff = new System.Windows.Forms.Label();
            this.btnStartRental = new System.Windows.Forms.Button();
            this.btnEndRental = new System.Windows.Forms.Button();
            this.lblCurrentRental = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timerRental = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvailableCars
            // 
            this.dgvAvailableCars.AllowUserToAddRows = false;
            this.dgvAvailableCars.AllowUserToDeleteRows = false;
            this.dgvAvailableCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableCars.BackgroundColor = System.Drawing.Color.White;
            this.dgvAvailableCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableCars.Location = new System.Drawing.Point(12, 12);
            this.dgvAvailableCars.MultiSelect = false;
            this.dgvAvailableCars.Name = "dgvAvailableCars";
            this.dgvAvailableCars.ReadOnly = true;
            this.dgvAvailableCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableCars.Size = new System.Drawing.Size(760, 200);
            this.dgvAvailableCars.TabIndex = 0;
            // 
            // cmbTariffs
            // 
            this.cmbTariffs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTariffs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTariffs.FormattingEnabled = true;
            this.cmbTariffs.Location = new System.Drawing.Point(140, 235);
            this.cmbTariffs.Name = "cmbTariffs";
            this.cmbTariffs.Size = new System.Drawing.Size(180, 25);
            // 
            // lblSelectTariff
            // 
            this.lblSelectTariff.AutoSize = true;
            this.lblSelectTariff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSelectTariff.Location = new System.Drawing.Point(16, 238);
            this.lblSelectTariff.Name = "lblSelectTariff";
            this.lblSelectTariff.Size = new System.Drawing.Size(111, 19);
            this.lblSelectTariff.Text = "Выберите тариф:";
            // 
            // btnStartRental
            // 
            this.btnStartRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnStartRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartRental.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnStartRental.ForeColor = System.Drawing.Color.White;
            this.btnStartRental.Location = new System.Drawing.Point(12, 310);
            this.btnStartRental.Name = "btnStartRental";
            this.btnStartRental.Size = new System.Drawing.Size(220, 45);
            this.btnStartRental.TabIndex = 3;
            this.btnStartRental.Text = "🚀 Начать поездку";
            this.btnStartRental.UseVisualStyleBackColor = false;
            // 
            // btnEndRental
            // 
            this.btnEndRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnEndRental.Enabled = false;
            this.btnEndRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndRental.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEndRental.ForeColor = System.Drawing.Color.White;
            this.btnEndRental.Location = new System.Drawing.Point(250, 310);
            this.btnEndRental.Name = "btnEndRental";
            this.btnEndRental.Size = new System.Drawing.Size(220, 45);
            this.btnEndRental.TabIndex = 4;
            this.btnEndRental.Text = "🛑 Завершить аренду";
            this.btnEndRental.UseVisualStyleBackColor = false;
            // 
            // lblCurrentRental
            // 
            this.lblCurrentRental.AutoSize = true;
            this.lblCurrentRental.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentRental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.lblCurrentRental.Location = new System.Drawing.Point(510, 238);
            this.lblCurrentRental.Name = "lblCurrentRental";
            this.lblCurrentRental.Size = new System.Drawing.Size(124, 21);
            this.lblCurrentRental.Text = "Время в пути:";
            this.lblCurrentRental.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTimer.Location = new System.Drawing.Point(510, 275);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(88, 25);
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.Visible = false;
            // 
            // timerRental
            // 
            this.timerRental.Interval = 1000;
            // 
            // UserRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 380);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblCurrentRental);
            this.Controls.Add(this.btnEndRental);
            this.Controls.Add(this.btnStartRental);
            this.Controls.Add(this.lblSelectTariff);
            this.Controls.Add(this.cmbTariffs);
            this.Controls.Add(this.dgvAvailableCars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UserRentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Аренда автомобиля";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvailableCars;
        private System.Windows.Forms.ComboBox cmbTariffs;
        private System.Windows.Forms.Label lblSelectTariff;
        private System.Windows.Forms.Button btnStartRental;
        private System.Windows.Forms.Button btnEndRental;
        private System.Windows.Forms.Label lblCurrentRental;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timerRental;
    }
}
