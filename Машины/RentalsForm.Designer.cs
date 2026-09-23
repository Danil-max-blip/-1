namespace CarsharingApp
{
    partial class RentalsForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.tabRentals = new System.Windows.Forms.TabPage();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.tabRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBookings);
            this.tabControl.Controls.Add(this.tabRentals);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 461);
            this.tabControl.TabIndex = 0;
            // 
            // tabBookings
            // 
            this.tabBookings.Controls.Add(this.dgvBookings);
            this.tabBookings.Location = new System.Drawing.Point(4, 26);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookings.Size = new System.Drawing.Size(876, 431);
            this.tabBookings.TabIndex = 0;
            this.tabBookings.Text = "📖 История бронирований";
            this.tabBookings.UseVisualStyleBackColor = true;
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.White;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookings.Location = new System.Drawing.Point(3, 3);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(870, 425);
            this.dgvBookings.TabIndex = 0;
            // 
            // tabRentals
            // 
            this.tabRentals.Controls.Add(this.dgvRentals);
            this.tabRentals.Location = new System.Drawing.Point(4, 26);
            this.tabRentals.Name = "tabRentals";
            this.tabRentals.Padding = new System.Windows.Forms.Padding(3);
            this.tabRentals.Size = new System.Drawing.Size(876, 431);
            this.tabRentals.TabIndex = 1;
            this.tabRentals.Text = "🚗 История поездок (Аренда)";
            this.tabRentals.UseVisualStyleBackColor = true;
            // 
            // dgvRentals
            // 
            this.dgvRentals.AllowUserToAddRows = false;
            this.dgvRentals.AllowUserToDeleteRows = false;
            this.dgvRentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentals.BackgroundColor = System.Drawing.Color.White;
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentals.Location = new System.Drawing.Point(3, 3);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.ReadOnly = true;
            this.dgvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentals.Size = new System.Drawing.Size(870, 425);
            this.dgvRentals.TabIndex = 0;
            // 
            // RentalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RentalsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Мониторинг аренды и бронирований";
            this.tabControl.ResumeLayout(false);
            this.tabBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.tabRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBookings;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.TabPage tabRentals;
        private System.Windows.Forms.DataGridView dgvRentals;
    }
}
