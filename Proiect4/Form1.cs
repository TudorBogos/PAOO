namespace Proiect4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            string filePath = Path.Combine(Application.StartupPath, "P1.pdf");
            if (File.Exists(filePath))
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true // Required to open the file with default app
                };
                System.Diagnostics.Process.Start(psi);
            }
            else
            {
                MessageBox.Show("File not found: " + filePath);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            string filePath = Path.Combine(Application.StartupPath, "P2.pdf");
            if (File.Exists(filePath))
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true // Required to open the file with default app
                };
                System.Diagnostics.Process.Start(psi);
            }
            else
            {
                MessageBox.Show("File not found: " + filePath);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            string filePath = Path.Combine(Application.StartupPath, "P3.pdf");
            if (File.Exists(filePath))
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true // Required to open the file with default app
                };
                System.Diagnostics.Process.Start(psi);
            }
            else
            {
                MessageBox.Show("File not found: " + filePath);
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkVisited = true;
            string filePath = Path.Combine(Application.StartupPath, "P4.pdf");
            if (File.Exists(filePath))
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true // Required to open the file with default app
                };
                System.Diagnostics.Process.Start(psi);
            }
            else
            {
                MessageBox.Show("File not found: " + filePath);
            }
        }
    }
}
