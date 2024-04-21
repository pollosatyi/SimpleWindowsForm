using System.Drawing;
namespace SimpleForm
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        private bool[,] field;
        private int rows;
        private int cols;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            if (timer1.Enabled) return;
            nudResolution.Enabled = false;
            nudDensity.Enabled = false;
            resolution = (int)nudResolution.Value;
            rows = pictureBox1.Height / resolution;
            cols = pictureBox1.Width / resolution;
            field = new bool[cols, rows];
            Random random = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next((int)nudDensity.Value) == 0;

                }
            }
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();
        }

        private void NextGeneration()
        {
            graphics.Clear(Color.Black);

            var newField = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighboursCount = CountNeighbours(x, y);
                    var haslife = field[x, y];
                    if (!haslife && neighboursCount == 3)
                        newField[x, y] = true;
                    else if (haslife && (neighboursCount > 3 || neighboursCount < 2))
                        newField[x, y] = false;
                    else
                        newField[x, y] = field[x, y];


                    if (haslife)
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution, resolution);
                    
                }
            }
            field = newField;
            pictureBox1.Refresh();
        }

        private int CountNeighbours(int x, int y)
        {
            return 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }
        private void StopGame()
        {
            if (!timer1.Enabled) return;
            timer1.Stop();
            nudResolution.Enabled = true;
            nudDensity.Enabled = true;
        }
        private void bStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
