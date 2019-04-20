using System;
using System.Windows.Forms;

namespace Consumer.XRoad_End
{
    public partial class MainForm : Form
    {
        private IPersonDataManager _personDataManager;

        public MainForm()
        {
            InitializeComponent();
            _personDataManager = new XRoadPersonDataManager();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                MessageBox.Show("Please enter PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var personData = _personDataManager.GetPersonData(searchTextBox.Text);
                UpdatePersonData(personData);
            }
            catch 
            {
                MessageBox.Show("Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePersonData(PersonData model)
        {
            this.personPhotoPictureBox.Image = model.Photo;
            this.personPinTextBox.Text = model.Pin;
            this.personNameTextBox.Text = model.Name;
            this.personBirthDateTextBox.Text = model.BirthDate;
            this.personGenderTextBox.Text = model.Gender;
        }
    }
}
