namespace Proiect10
{
    public partial class Form1 : Form
    {
        public static List<string> produse = new List<string>();
        public Form1()
        {
            InitializeComponent();
            tabPage1.Text = "Produse";
            tabPage2.Text = "Informatii contact";
            tabPage3.Text = "Sumar Comanda";

            label10.Text = "";
            label10.AutoSize = true;
            label11.Text = "";
            label11.AutoSize = true;
            label13.Text = "";
            label15.Text = "";

            richTextBox1.ReadOnly = true;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.Text = "Căști Wireless EchoSound\nSunet clar și bas profund, fără fire încurcate. Perfecte pentru muzică în mișcare sau apeluri clare.";

            richTextBox2.ReadOnly = true;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.BackColor = Color.White;
            richTextBox2.ForeColor = Color.Black;
            richTextBox2.Text = "Rucsac UrbanX\nDesign minimalist și spațiu generos. Ideal pentru birou, facultate sau escapade de weekend.";

            richTextBox3.ReadOnly = true;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.BackColor = Color.White;
            richTextBox3.ForeColor = Color.Black;
            richTextBox3.Text = "Cafetieră SmartBrew\nPregătește-ți cafeaua exact cum îți place, direct de pe telefon. Dimineți mai simple, zile mai bune.";

            richTextBox4.ReadOnly = true;
            richTextBox4.BorderStyle = BorderStyle.None;
            richTextBox4.BackColor = Color.White;
            richTextBox4.ForeColor = Color.Black;
            richTextBox4.Text = "Lampa LED ZenGlow\nLumină ambientală reglabilă pentru un vibe relaxant. Potrivită pentru dormitor sau birou.";

            richTextBox5.ReadOnly = true;
            richTextBox5.BorderStyle = BorderStyle.None;
            richTextBox5.BackColor = Color.White;
            richTextBox5.ForeColor = Color.Black;
            richTextBox5.Text = "Ceas inteligent FitPulse\nMonitorizare activitate, somn și notificări direct pe încheietură. Asistentul tău de zi cu zi.";

            richTextBox6.ReadOnly = true;
            richTextBox6.BorderStyle = BorderStyle.None;
            richTextBox6.BackColor = Color.White;
            richTextBox6.ForeColor = Color.Black;
            richTextBox6.Text = "Notebook A5 EcoNote\nCopertă reciclată și hârtie premium. Gata de idei mari și schițe rapide.";

            pictureBox1.Image = Properties.Resources.product_placeholder;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Properties.Resources.product_placeholder;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.Image = Properties.Resources.product_placeholder;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox4.Image = Properties.Resources.product_placeholder;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox5.Image = Properties.Resources.product_placeholder;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox6.Image = Properties.Resources.product_placeholder;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("Adauga in cos"))
            {
                produse.Add("Căști Wireless EchoSound");
                button1.Text = "Scoate din cos";
            }
            else
            {
                produse.Remove("Căști Wireless EchoSound");
                button1.Text = "Adauga in cos";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text.Equals("Adauga in cos"))
            {
                produse.Add("Rucsac UrbanX");
                button2.Text = "Scoate din cos";
            }
            else
            {
                produse.Remove("Rucsac UrbanX");
                button2.Text = "Adauga in cos";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text.Equals("Adauga in cos"))
            {
                produse.Add("Cafetieră SmartBrew");
                button3.Text = "Scoate din cos";
            }
            else
            {
                produse.Remove("Cafetieră SmartBrew");
                button3.Text = "Adauga in cos";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text.Equals("Adauga in cos"))
            {
                produse.Add("Lampa LED ZenGlow");
                button4.Text = "Scoate din cos";
            }
            else
            {
                produse.Remove("Lampa LED ZenGlow");
                button4.Text = "Adauga in cos";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text.Equals("Adauga in cos"))
            {
                produse.Add("Ceas inteligent FitPulse");
                button5.Text = "Scoate din cos";
            }
            else
            {
                produse.Remove("Ceas inteligent FitPulse");
                button5.Text = "Adauga in cos";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text.Equals("Adauga in cos"))
            {
                produse.Add("Notebook A5 EcoNote");
                button6.Text = "Scoate din cos";
            }
            else
            {
                produse.Remove("Notebook A5 EcoNote");
                button6.Text = "Adauga in cos";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label10.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label10.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label11.Text = "Strada " + textBox3.Text + ", Bl. " + textBox4.Text + ", Sc. " + textBox5.Text + ", Ap. " + textBox6.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label11.Text = "Strada " + textBox3.Text + ", Bl. " + textBox4.Text + ", Sc. " + textBox5.Text + ", Ap. " + textBox6.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label11.Text = "Strada " + textBox3.Text + ", Bl. " + textBox4.Text + ", Sc. " + textBox5.Text + ", Ap. " + textBox6.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label11.Text = "Strada " + textBox3.Text + ", Bl. " + textBox4.Text + ", Sc. " + textBox5.Text + ", Ap. " + textBox6.Text;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage3)
            {
                // Check if any textbox is empty
                bool anyTextBoxEmpty =
                    string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox5.Text) ||
                    string.IsNullOrWhiteSpace(textBox6.Text);

                // Check if any radio button is checked
                bool anyRadioChecked = radioButton1.Checked || radioButton2.Checked || radioButton3.Checked;

                if (anyTextBoxEmpty || !anyRadioChecked)
                {
                    MessageBox.Show("Asigură-te că ai completat toate câmpurile și ai selectat o opțiune de plata.", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            label15.Text = string.Join(", ", produse);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = radioButton3.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("S-a lansat comanda multumim");
        }
    }
}
