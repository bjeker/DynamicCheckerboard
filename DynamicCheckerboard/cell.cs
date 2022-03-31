using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicCheckerboard
{
    public partial class cell : UserControl
    {
        //button
        Button button = new Button();
        //size of cell
        int sizeOfCell = 32;

        public cell()
        {
            InitializeComponent();
            //set size of cell for x and y
            this.Size = new Size(sizeOfCell, sizeOfCell);
            //removing bebbles, drop shadow???? mo natural padding???
            Button.FlatStyle = FlatStyle.Flat;
            Button.Size = new Size(sizeOfCell, sizeOfCell);
            Button.Location = new Point(0, 0);
            Button.BackColor = Color.LightGray;
            this.Controls.Add(Button);
        }

        //get size of cell
        public int SizeOfCell { get => sizeOfCell; }
        public Button Button { get => button; }
    }
}
