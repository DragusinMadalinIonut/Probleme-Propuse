using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        private string customAlphabet;
        private string customAlphabet2;
        private string customAlphabet3;

        private char[,] polybiusSquare = {
            { '!', '(', ')', '#', '[', ']' },
            { 'A', 'B', 'C', 'D', 'E', 'F' },
            { 'G', 'H', 'I', 'J', 'K', 'L' },
            { 'M', 'N', 'O', 'P', 'Q', 'R' },
            { 'S', 'T', 'U', 'V', 'W', 'X' },
            { 'Y', 'Z', '0', '1', '2', '3' },
            { '4', '5', '6', '7', '8', '9' }
        };

        private List<string> alphabets = new List<string>
        {
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789,.;?!()[]",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        };

        public Form4()
        {
            InitializeComponent();
            Alphabet.Items.AddRange(alphabets.ToArray());
            Alphabet.DropDownStyle = ComboBoxStyle.DropDownList;
            customAlphabet = alphabets.Last();
            customAlphabet2 = alphabets.First();
            customAlphabet3 = alphabets.Last(); // Assuming you want the third alphabet by default
        }

        private void Encrypt_button_Click(object sender, EventArgs e)
        {
            string plainText = PlainBox.Text.ToUpper();
            StringBuilder encryptedText = new StringBuilder();

            foreach (char character in plainText)
            {
                if (character == ' ')
                {
                    encryptedText.Append(' ');
                }
                else
                {
                    string currentAlphabet = GetCurrentAlphabet();

                    if (currentAlphabet.Contains(character))
                    {
                        int index = currentAlphabet.IndexOf(character);
                        int row = index / 6;
                        int col = index % 6;

                        encryptedText.Append((row + 1).ToString() + (col + 1).ToString() + " ");
                    }
                }
            }

            EncryptBox.Text = encryptedText.ToString().Trim();
        }

        private void Decrypt_button_Click(object sender, EventArgs e)
        {
            string encryptedText = EncryptBox.Text;
            StringBuilder decryptedText = new StringBuilder();

            string currentAlphabet = GetCurrentAlphabet();

            string[] pairs = encryptedText.Split(' ');

            foreach (string pair in pairs)
            {
                if (pair != "")
                {
                    int row = int.Parse(pair[0].ToString()) - 1;
                    int col = int.Parse(pair[1].ToString()) - 1;

                    int index = row * 6 + col;

                    if (index < currentAlphabet.Length)
                    {
                        decryptedText.Append(currentAlphabet[index]);
                    }
                    else
                    {
                        decryptedText.Append(' ');
                    }
                }
                else
                {
                    decryptedText.Append(' ');
                }
            }

            DecryptBox.Text = decryptedText.ToString();
        }

        private string GetCurrentAlphabet()
        {
            if (Alphabet.SelectedItem == null)
            {
                return customAlphabet;
            }

            string selectedAlphabet = Alphabet.SelectedItem.ToString();

            if (selectedAlphabet == alphabets[0])
            {
                return customAlphabet;
            }
            else if (selectedAlphabet == alphabets[1])
            {
                return customAlphabet2;
            }
            else
            {
                return customAlphabet3;
            }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alphabet_SelectedIndexChanged(object sender, EventArgs e)
        {
            customAlphabet = Alphabet.SelectedItem.ToString();
        }

        private void KeyBox_TextChanged(object sender, EventArgs e)
        {
            // Handle KeyBox text changed event if needed
        }

        private void PlainBox_TextChanged(object sender, EventArgs e)
        {
            // Handle PlainBox text changed event if needed
        }

        private void EncryptBox_TextChanged(object sender, EventArgs e)
        {
            // Handle EncryptBox text changed event if needed
        }

        private void DecryptBox_TextChanged(object sender, EventArgs e)
        {
            // Handle DecryptBox text changed event if needed
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Handle label5 click event if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label1 click event if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle label2 click event if needed
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Handle label4 click event if needed
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Handle label3 click event if needed
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Handle tableLayoutPanel1 paint event if needed
        }
    }
}
