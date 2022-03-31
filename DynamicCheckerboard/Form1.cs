namespace DynamicCheckerboard
{
    public partial class Form1 : Form
    {
        cell[,] cells = new cell[10, 10];


        public Form1()
        {
            InitializeComponent();
            CreateGrid();
            CheckerBoardButtons();
        }

        //creates grid of cells
        private void CreateGrid()
        {
            //goes through cell array
            for (int row = 0; row < cells.GetLength(0); row++)
            {
                for (int col = 0; col < cells.GetLength(1); col++)
                {
                    //new cell creation
                    cells[row, col] = new cell();
                    cells[row, col].Button.Click += ButtonClickHandler;
                    //32x32 grid of cells
                    cells[row, col].Location = new Point(col * cells[row, col].SizeOfCell, row * cells[row, col].SizeOfCell);
                    this.Controls.Add(cells[row, col]);
                }
            }
        }

        //events when buttons are clicked
        private void CheckerBoardButtons()
        {

            for (int row = 0; row < cells.GetLength(0); row++)
            {
                for (int col = 0; col < cells.GetLength(1); col++)
                {
                    //check if even or odd, then set to whit if true or black if false
                    cells[row, col].Button.BackColor = ((row + col) % 2 == 0) ? Color.White : Color.Black;
                }
            }
        }

        //when button clicked
        public void ButtonClickHandler(object? sender, EventArgs e)
        {
            Color targetColor = ((Button)sender).BackColor;
            Random rand = new Random();
            Color newColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            ReplaceColor(targetColor, newColor);

        }

        //random button colors
        private void ReplaceColor(Color targetColor, Color newColor)
        {

            for (int row = 0; row < cells.GetLength(0); row++)
            {
                for (int col = 0; col < cells.GetLength(1); col++)
                {
                    if (cells[row, col].Button.BackColor == targetColor)
                    {
                        cells[row, col].Button.BackColor = newColor;
                    }
                }
            }
        }
    }
}