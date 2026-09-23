namespace CarsharingApp
{
    partial class TariffsForm
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
            this.dgvTariffs = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMinuteCost = new System.Windows.Forms.TextBox();
            this.txtHourCost = new System.Windows.Forms.TextBox();
            this.txtBookingCost = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMinuteCost = new System.Windows.Forms.Label();
            this.lblHourCost = new System.Windows.Forms.Label();
            this.lblBookingCost = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTariffs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTariffs
            // 
            this.dgvTariffs.AllowUserToAddRows = false;
            this.dgvTariffs.AllowUserToDeleteRows = false;
            this.dgvTariffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTariffs.BackgroundColor = System.Drawing.Color.White;
            this.dgvTariffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTariffs.Location = new System.Drawing.Point(12, 12);
            this.dgvTariffs.MultiSelect = false;
            this.dgvTariffs.Name = "dgvTariffs";
            this.dgvTariffs.ReadOnly = true;
            this.dgvTariffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTariffs.Size = new System.Drawing.Size(560, 200);
            this.dgvTariffs.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 235);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(150, 20);
            // 
            // txtMinuteCost
            // 
            this.txtMinuteCost.Location = new System.Drawing.Point(140, 270);
            this.txtMinuteCost.Name = "txtMinuteCost";
            this.txtMinuteCost.Size = new System.Drawing.Size(150, 20);
            // 
            // txtHourCost
            // 
            this.txtHourCost.Location = new System.Drawing.Point(420, 235);
            this.txtHourCost.Name = "txtHourCost";
            this.txtHourCost.Size = new System.Drawing.Size(150, 20);
            // 
            // txtBookingCost
            // 
            this.txtBookingCost.Location = new System.Drawing.Point(420, 270);
            this.txtBookingCost.Name = "txtBookingCost";
            this.txtBookingCost.Size = new System.Drawing.Size(150, 20);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 238);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 13);
            this.lblName.Text = "Название тарифа:";
            // 
            // lblMinuteCost
            // 
            this.lblMinuteCost.AutoSize = true;
            this.lblMinuteCost.Location = new System.Drawing.Point(20, 273);
            this.lblMinuteCost.Name = "lblMinuteCost";
            this.lblMinuteCost.Size = new System.Drawing.Size(104, 13);
            this.lblMinuteCost.Text = "Стоимость минуты:";
            // 
            // lblHourCost
            // 
            this.lblHourCost.AutoSize = true;
            this.lblHourCost.Location = new System.Drawing.Point(310, 238);
            this.lblHourCost.Name = "lblHourCost";
            this.lblHourCost.Size = new System.Drawing.Size(91, 13);
            this.lblHourCost.Text = "Стоимость часа:";
            // 
            // lblBookingCost
            // 
            this.lblBookingCost.AutoSize = true;
            this.lblBookingCost.Location = new System.Drawing.Point(310, 273);
            this.lblBookingCost.Name = "lblBookingCost";
            this.lblBookingCost.Size = new System.Drawing.Size(96, 13);
            this.lblBookingCost.Text = "Стоимость брони:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(200, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 35);
            this.btnUpdate.Text = "🔄 Обновить тариф";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // TariffsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 371);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblBookingCost);
            this.Controls.Add(this.lblHourCost);
            this.Controls.Add(this.lblMinuteCost);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBookingCost);
            this.Controls.Add(this.txtHourCost);
            this.Controls.Add(this.txtMinuteCost);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvTariffs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TariffsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление тарифами";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTariffs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTariffs;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMinuteCost;
        private System.Windows.Forms.TextBox txtHourCost;
        private System.Windows.Forms.TextBox txtBookingCost;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMinuteCost;
        private System.Windows.Forms.Label lblHourCost;
        private System.Windows.Forms.Label lblBookingCost;
        private System.Windows.Forms.Button btnUpdate;
    }
}
