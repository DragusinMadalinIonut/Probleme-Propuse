using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Encrypt(string text, int shift)
        {
            StringBuilder result = new StringBuilder();
            int key = int.Parse(textBox1.Text);
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    result.Append((char)(((c + key - 'A') % 26) + 'A'));
                }
                else if (char.IsNumber(c))
                {
                    char offset = '0';
                    result.Append((char)(((c + key - 'A' - 10) % 10) + offset)); ;
                }
                else
                {
                    result.Append(c);
                }

            }
            return result.ToString();
        }

        private string Decrypt(string text, int shift)
        {
            StringBuilder result = new StringBuilder();
            int key = int.Parse(textBox1.Text);
            foreach (char c in text)
            {
                if (char.IsLetter(c))
            {
                    char offset = 'A' ;
                result.Append((char)(((c - key - 'A' + 26) % 26) + offset));
            }
                else if (char.IsNumber(c))
                {
                    char offset = '0';
                    result.Append((char)(((c - key - 'A' + 10) % 10) + offset));
                }
                else
                {
                    result.Append(c);
                }

            }
            return result.ToString();
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Va rugam , seletati un alfabet", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int key = int.Parse(textBox1.Text);
                string plainText = textBox3.Text;
                string ciphertext = Decrypt(plainText, key);
                textBox4.Text = ciphertext;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Va rugam , seletati un alfabet", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else 
             {
                int key = int.Parse(textBox1.Text);
                string plainText = textBox2.Text;
                string ciphertext = Encrypt(plainText, key);
                textBox3.Text = ciphertext;

            }
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
