namespace Proiect12
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            // Set up timer
            timer.Interval = 300; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Start();

            this.DoubleBuffered = true; // reduce flicker
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Redraw the form
            this.Invalidate();

            // Play random beep
            int freq = 300 + rnd.Next(1000); // between 300 and 1300 Hz
            Console.Beep(freq, 150); // Beep for 150ms
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            int size = 10 + rnd.Next(50); // radius
            int x = rnd.Next(this.ClientSize.Width - size);
            int y = rnd.Next(this.ClientSize.Height - size);

            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            Pen pen = new Pen(randomColor, 2);

            g.DrawEllipse(pen, x, y, size, size);
        }
    }
}
