using System;
using System.Windows.Forms;

namespace ScopeAndEvent
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtYaziAlani_TextChanged(object sender, EventArgs e)
        {
            lblYaziAlani.Text = txtYaziAlani.Text;
        }
    }
}
