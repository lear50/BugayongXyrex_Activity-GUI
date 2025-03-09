using System;
using System.Windows.Forms;

namespace Windows_Forms_Sample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void EditUpdate_Click(object sender, EventArgs e)
        {
            
            Form3 editPage = new Form3();
            editPage.ShowDialog();  
        }
    }
}
