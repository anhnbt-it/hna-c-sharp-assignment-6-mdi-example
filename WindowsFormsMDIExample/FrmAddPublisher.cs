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
    public partial class FrmAddPublisher : Form
    {

        private readonly string connectionString = "SERVER=DESKTOP-C270RH4;Database=pubs;uid=anhnbt;pwd=KhoaiTay@2019";

        public FrmAddPublisher()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddPublisher_Load(object sender, EventArgs e)
        {
            loadDataToComboBox();
        }

        private void loadDataToComboBox()
        {
            // Load States
            try
            {
                string queryString = "SELECT DISTINCT state FROM publishers WHERE state IS NOT NULL";
                SqlConnection connection = new SqlConnection(connectionString);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                cboStates.DataSource = dataTable;
                cboStates.DisplayMember = "state";
                cboStates.ValueMember = "state";

                // loadCities
                queryString = "SELECT DISTINCT city FROM publishers WHERE city IS NOT NULL";
                dataAdapter = new SqlDataAdapter(queryString, connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                cboCities.DataSource = dataTable;
                cboCities.DisplayMember = "city";
                cboCities.ValueMember = "city";

                // loadCountries
                queryString = "SELECT DISTINCT country FROM publishers WHERE country IS NOT NULL";
                dataAdapter = new SqlDataAdapter(queryString, connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                cboCountries.DataSource = dataTable;
                cboCountries.DisplayMember = "country";
                cboCountries.ValueMember = "country";

                connection.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "INSERT INTO publishers (pub_id, pub_name, city, state, country) VALUES (@pubId, @pubName, @city, @state, @country)";
                SqlConnection connection = new SqlConnection(connectionString);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand(queryString, connection);
                command.CommandType = CommandType.Text;

                command.Parameters.Add("@pubId", SqlDbType.Char);
                command.Parameters["@pubId"].Value = txtPublisherId.Text;

                command.Parameters.Add("@pubName", SqlDbType.NVarChar);
                command.Parameters["@pubName"].Value = txtPublisherName.Text;

                command.Parameters.Add("@city", SqlDbType.NVarChar);
                command.Parameters["@city"].Value = cboCities.SelectedValue.ToString();

                command.Parameters.Add("@state", SqlDbType.NVarChar);
                command.Parameters["@state"].Value = cboStates.SelectedValue.ToString();

                command.Parameters.Add("@country", SqlDbType.NVarChar);
                command.Parameters["@country"].Value = cboCountries.SelectedValue.ToString();

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Publisher record inserted successfully.");
                }
                else
                {
                    MessageBox.Show("Something went wrong.");
                }

                connection.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Close this window?",
                "Confirm close",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
