namespace Proiect3
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox6.Checked && checkBox12.Checked && checkBox16.Checked && checkBox18.Checked)
            {
                MessageBox.Show("Toate raspunsurile sunt corecte");
            }
            else
            {
                MessageBox.Show("Ai gresit. Raspunsurile corecte sunt puse in textbox-urile din dreapta.");
                textBox1.Text = "Corect: 2";
                textBox2.Text = "Corect: 4";
                textBox3.Text = "Corect: 6";
                textBox4.Text = "Corect: 8";
                textBox5.Text = "Corect: 10";
            }
        }
    }
}
