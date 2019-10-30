using System;
using System.Windows.Forms;

namespace ScopeAndEvent
{
    public partial class Form1 : Form
    { // A
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 15;
        private void button1_Click(object sender, EventArgs e)
        {// C


            //sayi = sayi + 1;
            //sayi += 1;
            sayi++;
            label1.Text = sayi.ToString();
            /*D*/
        }

        private void button2_Click(object sender, EventArgs e)
        {//E 

            //sayi = 15;
            //sayi = sayi - 1;
            //sayi -= 1;
            sayi--;
            label1.Text = sayi.ToString();
            /*F*/
        }
        /*B*/
    }
}
