/*Name: David Lockwood
 *Date: 1/19/2021
 *Purpose: Build a complete database management system for the books database.
 */
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
using System.IO;

namespace Authors_Table_Input_Form_Project
{
    public partial class frmPublishers : Form
    {
        SqlConnection booksConnection;
        SqlCommand publishersCommand;
        SqlDataAdapter publishersAdapter;
        DataTable publishersTable;
        CurrencyManager publishersManager;
        public frmPublishers()
        {
            InitializeComponent();
        }

        private void frmPublishers_Load(object sender, EventArgs e)
        {
            try
            {
                hlpPublishers.HelpNamespace = Application.StartupPath + "\\publishers.chm";
                booksConnection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;"
                                                  + "AttachDbFilename=" + Path.GetFullPath("SQLBooksDB.mdf")
                                                  + ";Integrated Security=True;"
                                                  + "Connect Timeout=30;");
                booksConnection.Open();
                publishersCommand = new SqlCommand("Select * FROM Publishers ORDER BY Name;", booksConnection);
                publishersAdapter = new SqlDataAdapter();
                publishersAdapter.SelectCommand = publishersCommand;
                publishersTable = new DataTable();
                publishersAdapter.Fill(publishersTable);
                txtPubID.DataBindings.Add("Text", publishersTable, "PubID");
                txtPubName.DataBindings.Add("Text", publishersTable, "Name");
                txtCompanyName.DataBindings.Add("Text", publishersTable, "Company_Name");
                txtPubAddress.DataBindings.Add("Text", publishersTable, "Address");
                txtPubCity.DataBindings.Add("Text", publishersTable, "City");
                txtPubState.DataBindings.Add("Text", publishersTable, "State");
                txtPubZip.DataBindings.Add("Text", publishersTable, "Zip");
                txtPubTelephone.DataBindings.Add("Text", publishersTable, "Telephone");
                txtPubFAX.DataBindings.Add("Text", publishersTable, "FAX");
                txtPubComments.DataBindings.Add("Text", publishersTable, "Comments");
                publishersManager = (CurrencyManager)this.BindingContext[publishersTable];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error establishing Publisherss table.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Show();
            SetState("View");
        }
        private void frmPublishers_FormClosing(object sender, FormClosingEventArgs e)
        {
            booksConnection.Close();
            booksConnection.Dispose();
            publishersCommand.Dispose();
            publishersAdapter.Dispose();
            publishersTable.Dispose();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (publishersManager.Position == 0)
            {
                Console.Beep();
            }
            publishersManager.Position--;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (publishersManager.Position == publishersManager.Count - 1)
            {
                Console.Beep();
            }
            publishersManager.Position++;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            try
            {
                MessageBox.Show("Record saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetState("View");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(response == DialogResult.No)
            {
                return;
            }
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetState(string appState)
        {
            switch (appState)
            {
                case "View":
                    txtPubID.BackColor = Color.White;
                    txtPubID.ForeColor = Color.Black;
                    txtPubName.ReadOnly = true;
                    txtCompanyName.ReadOnly = true;
                    txtPubAddress.ReadOnly = true;
                    txtPubCity.ReadOnly = true;
                    txtPubState.ReadOnly = true;
                    txtPubZip.ReadOnly = true;
                    txtPubTelephone.ReadOnly = true;
                    txtPubFAX.ReadOnly = true;
                    txtPubComments.ReadOnly = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDone.Enabled = true;
                    txtPubName.Focus();
                    break;
                default:
                    txtPubID.BackColor = Color.Red;
                    txtPubID.ForeColor = Color.White;
                    txtPubName.ReadOnly = false;
                    txtCompanyName.ReadOnly = false;
                    txtPubAddress.ReadOnly = false;
                    txtPubCity.ReadOnly = false;
                    txtPubState.ReadOnly = false;
                    txtPubZip.ReadOnly = false;
                    txtPubTelephone.ReadOnly = false;
                    txtPubFAX.ReadOnly = false;
                    txtPubComments.ReadOnly = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnDone.Enabled = false;
                    txtPubName.Focus();
                    break;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                SetState("Add");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetState("Edit");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetState("View");
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox whichBox = (TextBox)sender;
            if ((int) e.KeyChar == 13)
            {
                switch(whichBox.Name)
                {
                    case "txtPubName":
                        txtCompanyName.Focus();
                        break;
                    case "txtCompanyName":
                        txtPubAddress.Focus();
                        break;
                    case "txtPubAddress":
                        txtPubCity.Focus();
                        break;
                    case "txtPubCity":
                        txtPubState.Focus();
                        break;
                    case "txtPubState":
                        txtPubZip.Focus();
                        break;
                    case "txtPubZip":
                        txtPubTelephone.Focus();
                        break;
                    case "txtPubTelephone":
                        txtPubFAX.Focus();
                        break;
                    case "txtPubFAX":
                        txtPubComments.Focus();
                        break;
                    case "txtPubComments":
                        txtPubName.Focus();
                        break;
                }
            }
        }
        private bool ValidateData()
        {
            string message = "";
            bool allOK = true;

            if (txtPubName.Text.Trim().Equals(""))
            {
                message = "You must enter an Publisher Name." + "\r\n";
                txtPubName.Focus();
                allOK = false;
            }

            if (!allOK)
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (allOK);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpPublishers.HelpNamespace);
        }
    }
}
