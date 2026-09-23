namespace CarsharingApp
{
    partial class PaymentsForm
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
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.txtTotalRevenue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(12, 12);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(760, 300);
            this.dgvPayments.TabIndex = 0;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.Location = new System.Drawing.Point(450, 343);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(126, 20);
            this.lblTotalRevenue.Text = "Общая выручка:";
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtTotalRevenue.Location = new System.Drawing.Point(585, 340);
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.ReadOnly = true;
            this.txtTotalRevenue.Size = new System.Drawing.Size(187, 27);
            this.txtTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.txtTotalRevenue);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.dgvPayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PaymentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Финансовый учет и платежи";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.TextBox txtTotalRevenue;
    }
}
