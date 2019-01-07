namespace HarcosokApplication
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.letrehozButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
            this.hozzaadButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.harcosokListBox = new System.Windows.Forms.ListBox();
            this.kepessegListBox = new System.Windows.Forms.ListBox();
            this.kepessegLeirasTextBox = new System.Windows.Forms.TextBox();
            this.torolButton = new System.Windows.Forms.Button();
            this.modositButton = new System.Windows.Forms.Button();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.kepessegNevTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harcos létrehozása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // nevTextBox
            // 
            this.nevTextBox.Location = new System.Drawing.Point(49, 42);
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(100, 20);
            this.nevTextBox.TabIndex = 2;
            // 
            // letrehozButton
            // 
            this.letrehozButton.Location = new System.Drawing.Point(180, 42);
            this.letrehozButton.Name = "letrehozButton";
            this.letrehozButton.Size = new System.Drawing.Size(75, 23);
            this.letrehozButton.TabIndex = 3;
            this.letrehozButton.Text = "Létrehozás";
            this.letrehozButton.UseVisualStyleBackColor = true;
            this.letrehozButton.Click += new System.EventHandler(this.letrehozButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Képesség hozzáadása";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Használó:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Név:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Leírás:";
            // 
            // hasznaloComboBox
            // 
            this.hasznaloComboBox.FormattingEnabled = true;
            this.hasznaloComboBox.Location = new System.Drawing.Point(70, 109);
            this.hasznaloComboBox.Name = "hasznaloComboBox";
            this.hasznaloComboBox.Size = new System.Drawing.Size(156, 21);
            this.hasznaloComboBox.TabIndex = 8;
            // 
            // hozzaadButton
            // 
            this.hozzaadButton.Location = new System.Drawing.Point(16, 178);
            this.hozzaadButton.Name = "hozzaadButton";
            this.hozzaadButton.Size = new System.Drawing.Size(75, 23);
            this.hozzaadButton.TabIndex = 10;
            this.hozzaadButton.Text = "Hozzáad";
            this.hozzaadButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Harcosok:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Képességei:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Képesség leírása";
            // 
            // harcosokListBox
            // 
            this.harcosokListBox.FormattingEnabled = true;
            this.harcosokListBox.Location = new System.Drawing.Point(16, 256);
            this.harcosokListBox.Name = "harcosokListBox";
            this.harcosokListBox.Size = new System.Drawing.Size(120, 212);
            this.harcosokListBox.TabIndex = 14;
            // 
            // kepessegListBox
            // 
            this.kepessegListBox.FormattingEnabled = true;
            this.kepessegListBox.Location = new System.Drawing.Point(164, 256);
            this.kepessegListBox.Name = "kepessegListBox";
            this.kepessegListBox.Size = new System.Drawing.Size(120, 212);
            this.kepessegListBox.TabIndex = 15;
            // 
            // kepessegLeirasTextBox
            // 
            this.kepessegLeirasTextBox.Location = new System.Drawing.Point(308, 256);
            this.kepessegLeirasTextBox.Multiline = true;
            this.kepessegLeirasTextBox.Name = "kepessegLeirasTextBox";
            this.kepessegLeirasTextBox.Size = new System.Drawing.Size(180, 105);
            this.kepessegLeirasTextBox.TabIndex = 16;
            // 
            // torolButton
            // 
            this.torolButton.Location = new System.Drawing.Point(164, 474);
            this.torolButton.Name = "torolButton";
            this.torolButton.Size = new System.Drawing.Size(75, 23);
            this.torolButton.TabIndex = 17;
            this.torolButton.Text = "Törlés";
            this.torolButton.UseVisualStyleBackColor = true;
            // 
            // modositButton
            // 
            this.modositButton.Location = new System.Drawing.Point(413, 367);
            this.modositButton.Name = "modositButton";
            this.modositButton.Size = new System.Drawing.Size(75, 23);
            this.modositButton.TabIndex = 18;
            this.modositButton.Text = "Módosít";
            this.modositButton.UseVisualStyleBackColor = true;
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Location = new System.Drawing.Point(269, 110);
            this.leirasTextBox.Multiline = true;
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(219, 53);
            this.leirasTextBox.TabIndex = 19;
            // 
            // kepessegNevTextBox
            // 
            this.kepessegNevTextBox.Location = new System.Drawing.Point(70, 143);
            this.kepessegNevTextBox.Name = "kepessegNevTextBox";
            this.kepessegNevTextBox.Size = new System.Drawing.Size(156, 20);
            this.kepessegNevTextBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 510);
            this.Controls.Add(this.kepessegNevTextBox);
            this.Controls.Add(this.leirasTextBox);
            this.Controls.Add(this.modositButton);
            this.Controls.Add(this.torolButton);
            this.Controls.Add(this.kepessegLeirasTextBox);
            this.Controls.Add(this.kepessegListBox);
            this.Controls.Add(this.harcosokListBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hozzaadButton);
            this.Controls.Add(this.hasznaloComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.letrehozButton);
            this.Controls.Add(this.nevTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.Button modositButton;
        private System.Windows.Forms.Button torolButton;
        private System.Windows.Forms.TextBox kepessegLeirasTextBox;
        private System.Windows.Forms.ListBox kepessegListBox;
        private System.Windows.Forms.ListBox harcosokListBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button hozzaadButton;
        private System.Windows.Forms.ComboBox hasznaloComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button letrehozButton;
        private System.Windows.Forms.TextBox nevTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kepessegNevTextBox;
    }
}

