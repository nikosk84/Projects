using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SQLConnector
{
    public partial class SQLConnector : Form
    {
        public SQLConnector()
        {
            InitializeComponent();
        }

        List<Person> person = new List<Person>();

        private void UpdateBindingPerson()
        {
            SearchResultsListBox.DataSource = person;
            SearchResultsListBox.DisplayMember = "FullPersonInfo";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Connector getPerson = new Connector();

            if (string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                MessageBox.Show("Please enter a last name to search for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                person = getPerson.GetPerson(LastNameTextBox.Text);
                UpdateBindingPerson();
            }
        }
    }
}
