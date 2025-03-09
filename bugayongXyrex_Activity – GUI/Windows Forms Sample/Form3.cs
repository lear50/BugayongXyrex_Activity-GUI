using System;
using System.Windows.Forms;

namespace Windows_Forms_Sample
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            update.Click += update_Click;
        }

        private void update_Click(object sender, EventArgs e)
        {
 
            if (string.IsNullOrWhiteSpace(Nameee.Text) ||
                string.IsNullOrWhiteSpace(AgeLabell.Text) ||
                string.IsNullOrWhiteSpace(Address.Text) ||
                string.IsNullOrWhiteSpace(ContactNumber1.Text) ||
                string.IsNullOrWhiteSpace(EmailAddress.Text) ||
                string.IsNullOrWhiteSpace(NameOfParentGuardian.Text) ||
                string.IsNullOrWhiteSpace(ParentGuardianContactNumber.Text) ||
                string.IsNullOrWhiteSpace(Course.Text) ||
                string.IsNullOrWhiteSpace(Year.Text))
            {
                MessageBox.Show("Please complete all required fields.",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Profile updated successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
