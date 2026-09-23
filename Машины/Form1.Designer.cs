namespace Машины
{
    partial class Form1
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnTariffs = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnRentals = new System.Windows.Forms.Button();
            this.btnCars = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelSidebar.Controls.Add(this.lblRole);
            this.panelSidebar.Controls.Add(this.btnTariffs);
            this.panelSidebar.Controls.Add(this.btnPayments);
            this.panelSidebar.Controls.Add(this.btnRentals);
            this.panelSidebar.Controls.Add(this.btnCars);
            this.panelSidebar.Controls.Add(this.btnUsers);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(220, 600);
            this.panelSidebar.TabIndex = 0;
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(12, 25);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(196, 40);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Администратор";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTariffs
            // 
            this.btnTariffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTariffs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTariffs.ForeColor = System.Drawing.Color.White;
            this.btnTariffs.Location = new System.Drawing.Point(12, 340);
            this.btnTariffs.Name = "btnTariffs";
            this.btnTariffs.Size = new System.Drawing.Size(196, 45);
            this.btnTariffs.TabIndex = 4;
            this.btnTariffs.Text = "📊 Тарифы";
            this.btnTariffs.UseVisualStyleBackColor = true;
            this.btnTariffs.Click += new System.EventHandler(this.btnTariffs_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.Location = new System.Drawing.Point(12, 280);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(196, 45);
            this.btnPayments.TabIndex = 3;
            this.btnPayments.Text = "💳 Платежи";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnRentals
            // 
            this.btnRentals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentals.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRentals.ForeColor = System.Drawing.Color.White;
            this.btnRentals.Location = new System.Drawing.Point(12, 220);
            this.btnRentals.Name = "btnRentals";
            this.btnRentals.Size = new System.Drawing.Size(196, 45);
            this.btnRentals.TabIndex = 2;
            this.btnRentals.Text = "⏱️ Аренда и бронь";
            this.btnRentals.UseVisualStyleBackColor = true;
            this.btnRentals.Click += new System.EventHandler(this.btnRentals_Click);
            // 
            // btnCars
            // 
            this.btnCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCars.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCars.ForeColor = System.Drawing.Color.White;
            this.btnCars.Location = new System.Drawing.Point(12, 160);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(196, 45);
            this.btnCars.TabIndex = 1;
            this.btnCars.Text = "🚗 Автомобили";
            this.btnCars.UseVisualStyleBackColor = true;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(12, 100);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(196, 45);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "👥 Пользователи";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(220, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(780, 80);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(396, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Система Управления Каршерингом";
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.Color.White;
            this.panelMainContent.Controls.Add(this.lblWelcome);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(220, 80);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(780, 520);
            this.panelMainContent.TabIndex = 2;
            this.panelMainContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainContent_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblWelcome.ForeColor = System.Drawing.Color.Gray;
            this.lblWelcome.Location = new System.Drawing.Point(220, 220);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(386, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Выберите раздел меню для начала работы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню — Каршеринг";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.panelMainContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Button btnRentals;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnTariffs;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.Label lblWelcome;
    }
}
