namespace ucus_rezervasyon_sistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            textBox1 = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 196);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            // 
            // button2
            // 
            button2.Location = new Point(230, 57);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(103, 128);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(68, 23);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 133);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 6;
            label7.Text = "saat:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(103, 99);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(176, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 105);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 4;
            label3.Text = "Tarih:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ANTALYA", "OSMANİYE", "İSTANBUL", "SİVAS", "SAMSUN", "KONYA" });
            comboBox2.Location = new Point(103, 74);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ANTALYA", "OSMANİYE", "İSTANBUL", "SİVAS", "SAMSUN", "KONYA" });
            comboBox1.Location = new Point(103, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 77);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "nereye:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 45);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "nereden:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(425, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 196);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu bilgileri";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(141, 133);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(116, 105);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(100, 23);
            maskedTextBox3.TabIndex = 7;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(116, 69);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 6;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 105);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 3;
            label6.Text = "Telefon No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 74);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 2;
            label5.Text = "Tc Kimlik:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 45);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 1;
            label4.Text = "Yolcu Ad Soyad:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 344);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(717, 94);
            listBox1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 79);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(499, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Brush Script MT", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 0);
            label8.Name = "label8";
            label8.Size = new Size(473, 79);
            label8.TabIndex = 0;
            label8.Text = "Jüpiter Hava Yolları";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(230, 132);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 9;
            label9.Text = "label9";
            label9.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label7;
        private Button button1;
        private ListBox listBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label8;
        private Button button2;
        private Label label9;
    }
}
