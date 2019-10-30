using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScopeAndEvent
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            textBox1.ForeColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            // sistemde, tanımlı olan rengi teslim eder.
            textBox1.BackColor = default;
            textBox1.ForeColor = default;
        }
    }
}
