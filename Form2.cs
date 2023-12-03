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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string customAlphabet = "";
         
    

        private string Encrypt(string text, string shift)
        {      
            StringBuilder encryptedText = new StringBuilder();
            string key = KeyBox.Text;
            string alphabet = Alphabet.SelectedItem.ToString();
            foreach (char c in key)
            {
                if (customAlphabet.Contains(c))
                {

                }
                else
                {
                    customAlphabet += c;
                }


            }
            foreach (char c in alphabet)
            {
                if (customAlphabet.Contains(c))
                {

                }
                else
                {
                    customAlphabet += c;
                }
            }
                foreach (char c in text)
            {
                int index = alphabet.IndexOf(c);
                if (index != -1)
                {
                    char encryptedChar = alphabet[(index) % customAlphabet.Length];
                    encryptedText.Append(encryptedChar);   
                }
                else if (char.IsNumber(c))
                {
                    char offset = '0';
                    encryptedText.Append((char)(((c ) % 10) + offset)); ;
                }
                else
                {
                    encryptedText.Append(c);
                }
            }
            return encryptedText.ToString();
        }

        private string Decrypt(string text, string shift)
        {
            StringBuilder decryptedText = new StringBuilder();
            string key = KeyBox.Text;
            string alphabet = Alphabet.SelectedItem.ToString();
            foreach (char c in key)
            {
                if (customAlphabet.Contains(c))
                {

                }
                else
                {
                    customAlphabet += c;
                }
            }
            foreach (char c in alphabet)
            {
                if (customAlphabet.Contains(c))
                {

                }
                else
                {
                    customAlphabet += c;
                }
            }
            foreach (char c in text)
            {
                int index = customAlphabet.IndexOf(c);
                if (index != -1)
                {
                  
                    int DecryptedIndex = (index - key.Length + customAlphabet.Length) % customAlphabet.Length;
                    char DecryptedChar = customAlphabet[DecryptedIndex];
                    decryptedText.Append(DecryptedChar);
                }
                else if (char.IsNumber(c))
                {
                    char offset = '0';
                    decryptedText.Append((char)(((index + key.Length + 10) % 10) + offset));
                }
                else
                {
                    decryptedText.Append(c);
                }

            }
            return decryptedText.ToString();
        }

            private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void KeyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Encrypt_button_Click(object sender, EventArgs e)
        {
            if (Alphabet.SelectedIndex == -1)
            {
                MessageBox.Show("Va rugam , seletati un alfabet", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string key = KeyBox.Text;
                string plainText = PlainBox.Text;
                string ciphertext = Encrypt(plainText, key);
                EncryptBox.Text = ciphertext;

            }

        }

        private void PlainBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Decrypt_button_Click(object sender, EventArgs e)
        {
            if (Alphabet.SelectedIndex == -1)
            {
                MessageBox.Show("Va rugam , seletati un alfabet", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string key = KeyBox.Text;
                string plainText = PlainBox.Text;
                string ciphertext = Decrypt(plainText, key);
                DecryptBox.Text = ciphertext;

            }

        }

        private void Alphabet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
