using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        public void isnumber(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != 45) && (e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<48 || e.KeyChar>57) && (e.KeyChar!=8) &&(e.KeyChar!=45) && (e.KeyChar != 46)){
                e.Handled = true;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text != "")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = ((Convert.ToDouble(textBox1.Text)) + (Convert.ToDouble(textBox2.Text))).ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = ((Convert.ToDouble(textBox1.Text)) - (Convert.ToDouble(textBox2.Text))).ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = ((Convert.ToDouble(textBox1.Text)) * (Convert.ToDouble(textBox2.Text))).ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = ((Convert.ToDouble(textBox1.Text)) / (Convert.ToDouble(textBox2.Text))).ToString();
        }
    }
}
