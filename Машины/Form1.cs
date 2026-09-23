using CarsharingApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Машины
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelMainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            CarsForm carsWindow = new CarsForm();

            carsWindow.ShowDialog();
        }


        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersForm usersWindow = new UsersForm();
            usersWindow.ShowDialog();
        }


        private void btnRentals_Click(object sender, EventArgs e)
        {
            RentalsForm rentalsWindow = new RentalsForm();
            rentalsWindow.ShowDialog();
        }


        private void btnPayments_Click(object sender, EventArgs e)
        {
            PaymentsForm paymentsWindow = new PaymentsForm();
            paymentsWindow.ShowDialog();
        }


        private void btnTariffs_Click(object sender, EventArgs e)
        {
            TariffsForm tariffsWindow = new TariffsForm();
            tariffsWindow.ShowDialog();
        }


    }
}
