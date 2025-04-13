namespace Proiect6
{
    public partial class Form1 : Form
    {
        private Image gif1;
        private Image gif2;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            gif1 = Image.FromFile("./gif1.gif");
            gif2 = Image.FromFile("./gif2.gif");

            ImageAnimator.Animate(gif1, OnFrameChanged);
            ImageAnimator.Animate(gif2, OnFrameChanged);
        }
        private void OnFrameChanged(object sender, EventArgs e)
        {
            this.Invalidate(); // Force repaint for new frame
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ImageAnimator.UpdateFrames(gif1);
            ImageAnimator.UpdateFrames(gif2);

            Graphics g = e.Graphics;
            g.DrawImage(gif1, 50, 50);   // Draw gif1 at (50, 50)
            g.DrawImage(gif2, 300, 50);  // Draw gif2 at (300, 50)
        }
    }
}
