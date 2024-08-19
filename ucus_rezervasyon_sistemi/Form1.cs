namespace ucus_rezervasyon_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota:" + comboBox1.Text + "-" + comboBox2.Text + " " + "Tarih:" + dateTimePicker1.Text + " "
                + "saat:" + maskedTextBox1.Text + " Yolcu bilgileri~Ad: " + textBox1.Text + " TC Kimlik No:" + maskedTextBox2.Text + " Telefon NO:" + maskedTextBox3.Text);
            MessageBox.Show("kaydedildi");

        }

        private void button2_Click(object sender, EventArgs e)
        {
          label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
