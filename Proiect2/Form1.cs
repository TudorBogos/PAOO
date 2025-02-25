namespace Proiect2
{
    public partial class Form1 : Form
    {
        const String parola = "parola";
        public Form1()
        {
            InitializeComponent();
            textBox1.Visible = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton.BackColor == Color.IndianRed)
                clickedButton.BackColor = Color.Yellow;
            else
                clickedButton.BackColor = Color.IndianRed;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.YellowGreen;
            button4.Text = "Butoane apasate";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button4.Text = "Starea butoanelor";
            button4.BackColor = Color.Orange;
        }
        private void button4_Click(object sender, System.EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = "";
            if (button1.BackColor == Color.Yellow)
                textBox1.Text = textBox1.Text + 'A';
            if (button2.BackColor == Color.Yellow)
                textBox1.Text = textBox1.Text + 'B';
            if (button3.BackColor == Color.Yellow)
                textBox1.Text = textBox1.Text + 'C';
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show(parola == textBox2.Text ? "Parola Valida" : "Parola Invalida");
        }
    }
}
