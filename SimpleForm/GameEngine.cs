using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace SimpleForm
{
    public class GameEngine
    {
        public uint CurrentGeneration {  get; private set; }
        private bool[,] field;
        private readonly int cols;
        private readonly int rows;
        private Random random = new Random();

        public GameEngine(int rows, int cols, int density)
        {
            this.cols = cols;
            this.rows = rows;
            field = new bool[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next(density) == 0;

                }
            }
        }

        public void NextGeneration()
        {
            

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



                }
            }
            field = newField;
            CurrentGeneration++;
        }

        public bool[,] GetCurrentGeneration()
        {
            var result = new bool[cols, rows];
            for(int x = 0;x < cols; x++)
            {
                for(int y = 0;y < rows; y++)
                {
                    result[x,y] = field[x, y];
                }
            }
            return result;
        }



        private int CountNeighbours(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;
                    var isSelfChecking = col == x && row == y;
                    var hasLife = field[col, row];
                    if (hasLife && !isSelfChecking)
                        count++;


                }
            }
            return count;
        }

    }
}
