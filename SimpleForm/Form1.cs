using System.Drawing;
namespace SimpleForm
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void bStart_Click(object sender, EventArgs e)
        {
            resolution = (int)nudResolution.Value;
            pictureBox1.Image=new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics=Graphics.FromImage(pictureBox1.Image);
            graphics.FillRectangle(Brushes.Crimson,0,0,resolution,resolution);

        }

        private void bStop_Click(object sender, EventArgs e)
        {

        }
    }
}
