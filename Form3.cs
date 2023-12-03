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
    public partial class Form3 : Form
    {

        private string customAlphabet;

        private List<string> alphabets = new List<string>
        {
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!..;/-",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        };
        public Form3()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(alphabets.ToArray());
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            customAlphabet = alphabets.First();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            customAlphabet = comboBox1.SelectedItem.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBoxa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void UncryptedBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EncryptedBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DecryptedBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxa.Text);
            int b = int.Parse(textBoxb.Text);
            string inputText = UncryptedBox.Text;

            string encryptedText = AffineEncrypt(inputText, a, b);
            EncryptedBox.Text = encryptedText;
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxa.Text);
            int b = int.Parse(textBoxb.Text);
            string inputText = EncryptedBox.Text;


            Console.WriteLine($"Decrypting: a={a}, b={b}, input={inputText}");

            string decryptedText = AffineDecrypt(inputText, a, b);
            DecryptedBox.Text = decryptedText;
        }

        private string AffineEncrypt(string input, int a, int b)
        {
            string encryptedText = "";

            foreach (char c in input)
            {
                int index = customAlphabet.IndexOf(char.ToUpper(c));
                if (index != -1)
                {
                    int encryptedIndex = (a * index + b) % customAlphabet.Length;
                    encryptedText += customAlphabet[encryptedIndex];
                }
                else
                {
                    encryptedText += c;
                }
            }

            return encryptedText;
        }

        private string AffineDecrypt(string input, int a, int b)
        {
            string decryptedText = "";

            int modInverse = ModularInverse(a, customAlphabet.Length);
            if(modInverse == 0)
            {
                this.Text = "NU SE POATE FACE DECRIPTAREA! PENTRU CA A NU ESTE INVERSABIL";
                return "0";
            }

            int decryptedIndex;

            foreach (char c in input)
            {
                int index = customAlphabet.IndexOf(char.ToUpper(c));
                if (customAlphabet.Contains(c))
                {
                    if(index -b < 0)
                    decryptedIndex = (modInverse * (index - b + customAlphabet.Length) % customAlphabet.Length);
                    else
                        if(index - b < customAlphabet.Length)
                    decryptedIndex = (modInverse * (index - b) % customAlphabet.Length);
                    else
                        decryptedIndex = (modInverse * ((index - b - customAlphabet.Length) % customAlphabet.Length) % customAlphabet.Length);
                    decryptedText += customAlphabet[decryptedIndex];
                }
                
                else
                {
                    decryptedText += c;
                }
            }

            return decryptedText;
        }

        private int ModularInverse(int a, int m)
        {
            return Enumerable.Range(1, m - 1).FirstOrDefault(x => (a * x) % m == 1);
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
