
namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DecryptBox = new System.Windows.Forms.TextBox();
            this.Alphabet = new System.Windows.Forms.ComboBox();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.PlainBox = new System.Windows.Forms.TextBox();
            this.EncryptBox = new System.Windows.Forms.TextBox();
            this.Encrypt_button = new System.Windows.Forms.Button();
            this.Decrypt_button = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.21862F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.78138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.DecryptBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Alphabet, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.KeyBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PlainBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EncryptBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Encrypt_button, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.Decrypt_button, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.EXIT, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // DecryptBox
            // 
            this.DecryptBox.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.DecryptBox.Location = new System.Drawing.Point(81, 398);
            this.DecryptBox.Name = "DecryptBox";
            this.DecryptBox.Size = new System.Drawing.Size(346, 29);
            this.DecryptBox.TabIndex = 7;
            // 
            // Alphabet
            // 
            this.Alphabet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Alphabet.FormattingEnabled = true;
            this.Alphabet.Items.AddRange(new object[] {
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ ",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789,.;?!()[]"});
            this.Alphabet.Location = new System.Drawing.Point(81, 3);
            this.Alphabet.Name = "Alphabet";
            this.Alphabet.Size = new System.Drawing.Size(346, 21);
            this.Alphabet.TabIndex = 0;
            this.Alphabet.SelectedIndexChanged += new System.EventHandler(this.Alphabet_SelectedIndexChanged);
            // 
            // KeyBox
            // 
            this.KeyBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyBox.Location = new System.Drawing.Point(81, 142);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(346, 29);
            this.KeyBox.TabIndex = 4;
            this.KeyBox.TextChanged += new System.EventHandler(this.KeyBox_TextChanged);
            // 
            // PlainBox
            // 
            this.PlainBox.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.PlainBox.Location = new System.Drawing.Point(81, 263);
            this.PlainBox.Name = "PlainBox";
            this.PlainBox.Size = new System.Drawing.Size(346, 29);
            this.PlainBox.TabIndex = 5;
            this.PlainBox.TextChanged += new System.EventHandler(this.PlainBox_TextChanged);
            // 
            // EncryptBox
            // 
            this.EncryptBox.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.EncryptBox.Location = new System.Drawing.Point(81, 320);
            this.EncryptBox.Name = "EncryptBox";
            this.EncryptBox.Size = new System.Drawing.Size(346, 29);
            this.EncryptBox.TabIndex = 6;
            // 
            // Encrypt_button
            // 
            this.Encrypt_button.BackColor = System.Drawing.SystemColors.ControlText;
            this.Encrypt_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Encrypt_button.Location = new System.Drawing.Point(433, 398);
            this.Encrypt_button.Name = "Encrypt_button";
            this.Encrypt_button.Size = new System.Drawing.Size(114, 45);
            this.Encrypt_button.TabIndex = 2;
            this.Encrypt_button.Text = "Decriptare";
            this.Encrypt_button.UseVisualStyleBackColor = false;
            this.Encrypt_button.Click += new System.EventHandler(this.Encrypt_button_Click);
            // 
            // Decrypt_button
            // 
            this.Decrypt_button.AutoSize = true;
            this.Decrypt_button.BackColor = System.Drawing.SystemColors.InfoText;
            this.Decrypt_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Decrypt_button.Location = new System.Drawing.Point(581, 398);
            this.Decrypt_button.Name = "Decrypt_button";
            this.Decrypt_button.Size = new System.Drawing.Size(105, 45);
            this.Decrypt_button.TabIndex = 3;
            this.Decrypt_button.Text = "Criptare";
            this.Decrypt_button.UseVisualStyleBackColor = false;
            this.Decrypt_button.Click += new System.EventHandler(this.Decrypt_button_Click);
            // 
            // EXIT
            // 
            this.EXIT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EXIT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EXIT.Location = new System.Drawing.Point(702, 398);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(84, 49);
            this.EXIT.TabIndex = 1;
            this.EXIT.Text = "Exit";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(3, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 40);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mesaj Criptat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 58);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mesaj Decriptat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 57);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mesaj Necriptat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cheie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Alfabet";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox DecryptBox;
        private System.Windows.Forms.ComboBox Alphabet;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.TextBox PlainBox;
        private System.Windows.Forms.TextBox EncryptBox;
        private System.Windows.Forms.Button Encrypt_button;
        private System.Windows.Forms.Button Decrypt_button;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}