using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Storage_Database
{
    public partial class PCAddition : Form
    {
        string ConnectionString;

        public PCAddition()
        {
            InitializeComponent();
            ConnectionString = ConfigurationManager.ConnectionStrings["Storage_Database.Properties.Settings.InventoryDBConnectionString"].ConnectionString;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool txtBox = false;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        txtBox = true;
                    }
                }
            }
            if (txtBox == true)
            {
                MessageBox.Show("Please fill out all the Textboxes", "ERROR");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO PCInfo (InventoryNum, OS, Ram, CPU, Storage, GPU) VALUES('" + txtIN.Text + "', '" + txtOS.Text + "', '" + txtRam.Text + "', '" + txtCPU.Text + "', '" + txtStorage.Text + "', '" + txtGPU.Text + "')";
                    using (SqlConnection Connection = new SqlConnection(ConnectionString))
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        Connection.Open();
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("PC added", "Success");
                    this.Hide();
                    Dashboard InvenDashboard = new Dashboard();
                    InvenDashboard.Show();
                }
                catch(SqlException)
                {
                    MessageBox.Show("Duplicate inventory number, please type in a non-duplicate inventory number ", "ERROR");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard InvenDashboard = new Dashboard();
            InvenDashboard.Show();
        }

        private void txtIN_TextChanged(object sender, EventArgs e)
        {
            string tString = txtIN.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid number", "ERROR");
                    txtIN.Text = "";
                    return;
                }

            }
        }

        private void txtRam_TextChanged(object sender, EventArgs e)
        {
            string tString = txtRam.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid number", "ERROR");
                    txtRam.Text = "";
                    return;
                }

            }
        }

        private void txtStorage_TextChanged(object sender, EventArgs e)
        {
            string tString = txtStorage.Text;
            if (tString.Trim() == "") return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid number", "ERROR");
                    txtStorage.Text = "";
                    return;
                }

            }
        }
    }
}
