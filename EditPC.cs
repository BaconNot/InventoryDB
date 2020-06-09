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
    public partial class EditPC : Form
    {
        int temp = Dashboard.variable1;
        string ConnectionString;

        public EditPC()
        {
            InitializeComponent();
            ConnectionString = ConfigurationManager.ConnectionStrings["Storage_Database.Properties.Settings.InventoryDBConnectionString"].ConnectionString;
        }

        private void EditPC_Load(object sender, EventArgs e)
        {
            string INlbl = temp.ToString();
            lblIN.Text = INlbl;
            string query = "SELECT OS, Ram, CPU, Storage, GPU  FROM PCInfo WHERE InventoryNum = '" + temp + "'";
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                Connection.Open();
                SqlDataReader DataReader = command.ExecuteReader();
                while(DataReader.Read())
                {
                    txtOS.AppendText(DataReader["OS"].ToString());
                    txtRam.AppendText(DataReader["Ram"].ToString());
                    txtCPU.AppendText(DataReader["CPU"].ToString());
                    txtStorage.AppendText(DataReader["Storage"].ToString());
                    txtGPU.AppendText(DataReader["GPU"].ToString());
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                string query = "UPDATE PCInfo SET OS = '" + txtOS.Text + "', Ram =  '" + txtRam.Text + "', CPU =  '" + txtCPU.Text + "', Storage = '" + txtStorage.Text + "', GPU = '" + txtGPU.Text + "' WHERE InventoryNum = '" + temp +"'";
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(query, Connection))
                {
                    Connection.Open();
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("PC updated", "Success");
                this.Hide();
                Dashboard InvenDashboard = new Dashboard();
                InvenDashboard.Show();
            }
        }
     

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard InvenDashboard = new Dashboard();
            InvenDashboard.Show();
        }

        private void txtRam_TextChanged_1(object sender, EventArgs e)
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
