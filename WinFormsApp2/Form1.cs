using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Nie podano wszystkich danych";
            string Imie = textBox1.Text;
            string Nazwisko = textBox2.Text;
            string Data = dateTimePicker1.Text;
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Podane imie: " + Imie + ", nazwisko: " + Nazwisko + ", data urocdzenia: " + Data);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}