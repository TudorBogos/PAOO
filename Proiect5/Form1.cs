namespace Proiect5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFiles();
        }

        private void LoadFiles()
        {
            listBox1.Items.Clear();
            List<string> files = new List<string>();
            string folderPath = @"H:\";

            if (checkedListBox1.CheckedItems.Contains(".sh"))
            {
                files.AddRange(Directory.GetFiles(folderPath, "*.sh"));
            }
            if (checkedListBox1.CheckedItems.Contains(".txt"))
            {
                files.AddRange(Directory.GetFiles(folderPath, "*.txt"));
            }
            if (checkedListBox1.CheckedItems.Contains(".bmp"))
            {
                files.AddRange(Directory.GetFiles(folderPath, "*.bmp"));
            }

            foreach (string file in files)
            {
                listBox1.Items.Add(Path.GetFileName(file));
            }
        }
    }
}
