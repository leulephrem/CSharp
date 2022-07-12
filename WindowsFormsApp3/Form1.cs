using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model m1 = new model
            {
                number = int.Parse(textBox1.Text),
                date = datetxt.Text,
                invnumb = int.Parse(textBox3.Text),
                objname = textBox4.Text,
                count = int.Parse(textBox5.Text),
                price = double.Parse(textBox6.Text),
            };
            MessageBox.Show("YOU HAVE COMPLETED THE SUBMISSION");
            m1.save();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int tim = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            tim++;

            if (tim == 200)
            {
                MessageBox.Show("Are you dumb start writing");
            }


        }

        private void datetxt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
