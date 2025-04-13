namespace Proiect7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;
            string birthDate = monthCalendar1.SelectionStart.ToShortDateString();

            string displayText =
                " Informatii de inregistrare:\n\n" +
                $" Nume si prenume: {name}\n" +
                $" Email: {email}\n" +
                $" Parola: {password}\n" +
                $" Data nasterii: {birthDate}";

            richTextBox1.Text = displayText;
        }
    }
}
