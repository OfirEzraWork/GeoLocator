using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using GeoLocator.Model.DAOs;

namespace GeoLocator
{
    public partial class MainWindow : Form
    {
        private FileReader reader = new CsvReader();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChooseSourceFileButton_Click(object sender, EventArgs e)
        {

            if (SourceFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SourceTextBox.Text = SourceFileDialog.FileName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\nDetails:\n\n{ex.StackTrace}");
                }
            }

        }

        private void LoadCsvButton_Click(object sender, EventArgs e)
        {
            reader.ReadFile(SourceTextBox.Text);
            GeoLocationApiConnector.GetCoordsMany(reader.GetLocations());
            if (reader.ContainsRecords())
            {
                InsertToDBButton.Enabled = true;
                MessageBox.Show("Csv Loaded.\n\nThe data is ready to be inserted to a database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Csv Loaded.\n\nNo data was found", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void InsertToDBButton_Click(object sender, EventArgs e)
        {
            if (LocationDAO.InsertMany(reader.GetLocations()))
            {
                MessageBox.Show("Entries added to the DB.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error accessing DB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
