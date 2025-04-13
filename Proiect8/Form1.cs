
namespace Proiect8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("Name", 250);
            listView1.Columns.Add("Size", 100);
            listView1.Columns.Add("Date Modified", 150);
            LoadDirectory("C:\\");
        }

        private void LoadDirectory(string path)
        {
            listView1.Items.Clear();

            try
            {
                // Folders
                foreach (string dir in Directory.GetDirectories(path))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(dir);
                    ListViewItem item = new ListViewItem(dirInfo.Name);
                    item.SubItems.Add(""); // Folders don't have a size
                    item.SubItems.Add(dirInfo.LastWriteTime.ToString());
                    item.Tag = dir;
                    listView1.Items.Add(item);
                }

                // Files
                foreach (string file in Directory.GetFiles(path))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    ListViewItem item = new ListViewItem(fileInfo.Name);
                    item.SubItems.Add(fileInfo.Length.ToString() + " B");
                    item.SubItems.Add(fileInfo.LastWriteTime.ToString());
                    item.Tag = file;
                    listView1.Items.Add(item);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Access denied to some items:\n" + ex.Message);
            }

        }
    }
}
