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
using System.Text.RegularExpressions;

namespace Storage_Database
{
    public partial class Dashboard : Form
    {
        string ConnectionString;
        public Dashboard()
        {
            InitializeComponent();
            ConnectionString = ConfigurationManager.ConnectionStrings["Storage_Database.Properties.Settings.InventoryDBConnectionString"].ConnectionString;
        }
        private void listPCInfo_SelectedIndexChanged(object sender, EventArgs e){}
        private void Dashboard_Load(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void PopulateList()
        {
            string query = "SELECT * FROM PCInfo";
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                Connection.Open();
                listPCInfo.Items.Clear();
                SqlDataReader DataReader = command.ExecuteReader();

                while (DataReader.Read())
                {
                    ListViewItem Item = new ListViewItem(DataReader["InventoryNum"].ToString());
                    Item.SubItems.Add(DataReader["OS"].ToString());
                    Item.SubItems.Add(DataReader["Ram"].ToString());
                    Item.SubItems.Add(DataReader["CPU"].ToString());
                    Item.SubItems.Add(DataReader["Storage"].ToString());
                    Item.SubItems.Add(DataReader["GPU"].ToString());
                    listPCInfo.Items.Add(Item);
                }
            }
        }

        private void btnAddPC_Click(object sender, EventArgs e)
        {
            this.Hide();
            PCAddition Addition = new PCAddition();
            Addition.Show();
        }

        private void btnDeletePC_Click(object sender, EventArgs e)
        {
            if (listPCInfo.SelectedItems.Count > 0)
            {
                string resultString;
                string num = listPCInfo.FocusedItem.ToString();
                resultString = Regex.Match(num, @"\d+").Value;
                int item = Int32.Parse(resultString);
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm deletion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM PCInfo WHERE InventoryNum ='" + item + "'";
                    using (SqlConnection Connection = new SqlConnection(ConnectionString))
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        Connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please select an item to delete", "ERROR");
            }
            PopulateList();
        }

        public static int variable1;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listPCInfo.SelectedItems.Count > 0)
            {
                string resultString;
                string num = listPCInfo.FocusedItem.ToString();
                resultString = Regex.Match(num, @"\d+").Value;
                int item = Int32.Parse(resultString);
                variable1 = item;
                EditPC frm2 = new EditPC();
                this.Hide();
                frm2.Show();
              
            }
            else
            {
                MessageBox.Show("Please select an item to edit", "ERROR");
            }
        }
    }
}
