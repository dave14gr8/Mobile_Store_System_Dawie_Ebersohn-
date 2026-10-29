using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MobileStoreSystem
{
    public partial class Form1 : Form
    { List<int> mobileCodes = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {   mobileCodes = new List<int>();
          if (!int.TryParse(txtMobileCode.Text, out int code)) //input validation 
            {
                MessageBox.Show("Plese enter an numeric number for Mobile Code!");
                return;     
            }

            if (string.IsNullOrWhiteSpace(txtMake.Text))//input validation 
            {
                MessageBox.Show("Plese enter the Make!");
                return;
            }
           
            
            if (!int.TryParse(txtQuantity.Text, out int quantity))//input validation 
            {
                MessageBox.Show("Plese enter a numeric number for Quantity!");
                return;
            }

            int mobileCode = int.Parse(txtMobileCode.Text);
            mobileCodes.Add(mobileCode);
            string make = txtMake.Text;
            int quant = int.Parse(txtQuantity.Text);

            lblResults.Text = $"Mobile Code: {mobileCode}\n" + //Output for results label
                              $"Make: {make}\n" +
                              $"Quantity: {quant}\n" +
                              $"\n Reccord Added Successfully!!!";

        }

        private void btnDelete_Click(object sender, EventArgs e)//Clearing all inputs 
        {
            txtMobileCode.Clear();
            txtQuantity.Clear();
            txtMake.Clear();
            lblResults.Text = $"Record Deleted!";
        }

        private void btnFind_Click(object sender, EventArgs e) //Displying user input 
        {
            if (!int.TryParse(txtMobileCode.Text, out int code))
            {
                MessageBox.Show("Plese enter an numeric number!");
                return;
            }
            else
            {
                 int mobilecode = int.Parse(txtMobileCode.Text); //Output to display mobile code 
                MessageBox.Show("Searching For Mobile Code:");
                MessageBox.Show($"Mobile code is: {mobilecode}");
            }

        }
    }
}
