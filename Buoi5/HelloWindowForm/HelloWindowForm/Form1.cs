using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Console.WriteLine("Test form load");

            this.button1.Location = new System.Drawing.Point(this.Width / 2 - this.button1.Width / 2, this.Height / 2 - this.button1.Height / 2);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = this.inputText.Text;
            MessageBox.Show("Gia tri cua a la: " + a);
        }

    }
}
