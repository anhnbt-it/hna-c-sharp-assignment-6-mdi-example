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
    public partial class FrmNewAuthor : Form
    {

        private readonly string connectionString = "SERVER=DESKTOP-C270RH4;Database=pubs;uid=anhnbt;pwd=KhoaiTay@2019";

        public FrmNewAuthor()
        {
            InitializeComponent();
        }

        private void FrmNewAuthor_Load(object sender, EventArgs e)
        {
            loadDataToComboBox();
        }

        private void loadDataToComboBox()
        {
            try
            {
                // Load Cities
                string queryString = "SELECT DISTINCT city FROM authors WHERE city IS NOT NULL";
                SqlConnection connection = new SqlConnection(connectionString);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryString, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                cboCities.DataSource = dataTable;
                cboCities.DisplayMember = "city";
                cboCities.ValueMember = "city";

                // Load States
                queryString = "SELECT DISTINCT state FROM authors WHERE state IS NOT NULL";
                dataAdapter = new SqlDataAdapter(queryString, connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                cboStates.DataSource = dataTable;
                cboStates.DisplayMember = "state";
                cboStates.ValueMember = "state";
                connection.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Close this window?", "Confirm close", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string queryString = "INSERT INTO authors " +
                    "(au_id, au_lname, au_fname, phone, address, city, state, zip, contract) " +
                    "VALUES (@id, @lastName, @firstName, @phone, @address, @city, @state, @zip, @contract);";
                SqlConnection connection = new SqlConnection(connectionString);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand(queryString, connection);
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@id", SqlDbType.VarChar);
                command.Parameters["@id"].Value = txtAuthorId.Text.ToString();

                command.Parameters.Add("@lastName", SqlDbType.VarChar);
                command.Parameters["@lastName"].Value = txtLastName.Text.ToString();


                command.Parameters.Add("@firstName", SqlDbType.VarChar);
                command.Parameters["@firstName"].Value = txtFirstName.Text.ToString();

                command.Parameters.Add("@phone", SqlDbType.Char);
                command.Parameters["@phone"].Value = txtPhoneNumber.Text.ToString();

                command.Parameters.Add("@address", SqlDbType.VarChar);
                command.Parameters["@address"].Value = rtbAddress.Text.ToString();

                command.Parameters.Add("@city", SqlDbType.VarChar);
                command.Parameters["@city"].Value = cboCities.SelectedValue.ToString();

                command.Parameters.Add("@state", SqlDbType.Char);
                command.Parameters["@state"].Value = cboStates.SelectedValue.ToString();

                command.Parameters.Add("@zip", SqlDbType.Char);
                command.Parameters["@zip"].Value = txtZip.Text.ToString();

                command.Parameters.Add("@contract", SqlDbType.Bit);
                if (chkContract.Checked)
                {
                    command.Parameters["@contract"].Value = 1;
                } else
                {
                    command.Parameters["@contract"].Value = 0;
                }
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Author record inserted successfully.");
                } else
                {
                    MessageBox.Show("Something went wrong.");
                }
                connection.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmNewAuthor_Shown(object sender, EventArgs e)
        {
            Controls[0].Focus();
        }
    }
}
