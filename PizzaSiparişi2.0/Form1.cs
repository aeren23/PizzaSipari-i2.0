namespace PizzaSiparişi2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] dizi = new string[5];
            dizi[0] = "Ad Soyad: " + textBox1.Text;
            dizi[1] = "Telefon: " + textBox2.Text;
            dizi[2] = "Adres: " + textBox3.Text;
            dizi[3] = "Pizza Boy: " + comboBox1.Text;
            dizi[4] = "İçecek: " + comboBox2.Text;
            listBox1.Items.AddRange(dizi);
            MessageBox.Show("SİPARİŞİNİZ ALINMIŞTIR");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}