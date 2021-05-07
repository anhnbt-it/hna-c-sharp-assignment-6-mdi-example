using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsMDIExample
{
    public partial class FrmNewTitle : Form
    {

        private readonly string connectionString = "SERVER=DESKTOP-C270RH4;Database=pubs;uid=anhnbt;pwd=KhoaiTay@2019";

        public FrmNewTitle()
        {
            InitializeComponent();
        }

        private void FrmNewTitle_Load(object sender, EventArgs e)
        {
            loadDataToComboBox();
        }

        private void loadDataToComboBox()
        {
            try
            {
                // Load Type
                string queryString = "SELECT DISTINCT type FROM titles WHERE type IS NOT NULL";
                SqlConnection connection = new SqlConnection(connectionString);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                cboTypes.DataSource = dataTable;
                cboTypes.DisplayMember = "type";
                cboTypes.ValueMember = "type";

                // Load Publishers
                queryString = "SELECT pub_id, pub_name FROM publishers ORDER BY pub_id DESC";
                dataAdapter = new SqlDataAdapter(queryString, connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                cboPublishers.DataSource = dataTable;
                cboPublishers.DisplayMember = "pub_name";
                cboPublishers.ValueMember = "pub_id";
                connection.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Close this window?", "Confirm close", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
