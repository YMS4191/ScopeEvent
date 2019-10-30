using System;
using System.Windows.Forms;

namespace ScopeAndEvent
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();  
        }

        int maxLengt = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            maxLengt = Convert.ToInt32(lblKalanKarakterSayisi.Text);
        }
   
        private void txtMetinAlani_TextChanged(object sender, EventArgs e)
        {
            lblKalanKarakterSayisi.Text = (maxLengt - txtMetinAlani.TextLength).ToString();
        } 
    }
}
