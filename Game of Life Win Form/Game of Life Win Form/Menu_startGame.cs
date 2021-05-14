using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life_Win_Form
{
    public partial class Menu_startGame : Menuing
    {
        private int x;
        private int y;
        private bool isRunning;
        private Button[,] buttonArray;
        private double speed = 1;
        private const double delay = 500;
        private double modDelay;

        public Menu_startGame()
        {
            InitializeComponent();
        }

        public Menu_startGame(bool isCreated)
        {
            InitializeComponent();

            x = Matchfield.X;
            y = Matchfield.Y;

            //Panel_matchfield = Matchfield.CurrentMatchfield;

            CreateField();

            buttonArray = CreateButtonArray2Dim();

            trackBar_speed.Value = 4;
            trackBar_speed_ValueChanged(null, null);

            //foreach (var button in Panel_matchfield.Controls.Cast<Button>())
            //{
            //    button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            //    button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            //    //button.CausesValidation = false;
            //}
        }

        private void CreateField()
        {
            //currentPanel = Matchfield.CurrentMatchfield;

            //Panel_matchfield.Controls.Clear();
            //var cPA = Matchfield.CurrentMatchfield.Controls.Cast<Button>().ToList();

            //for (var i = 0; i < cPA.Count; i++)
            //{
            //    var cell = new Tools().Btn_cell;

            //    cell.BackColor = cPA[i].BackColor;
            //    cell.Location = cPA[i].Location;
            //    cell.Size = cPA[i].Size;

            //    Panel_matchfield.Controls.Add(cell);
            //    //Thread.Sleep(1);
            //}

            Matchfield.CurrentMatchfield.Controls.Cast<Button>().ToList().ForEach(x =>
            {
                Panel_matchfield.Controls.Add(x);
            });

            //Matchfield.CurrentMatchfield = currentPanel;
        }

        private Button[,] CreateButtonArray2Dim()
        {
            var cells = Panel_matchfield.Controls.Cast<Button>().ToArray();
            var buttonArray = new Button[y, x];

            var k = 0;
            for (var i = 0; i < y; i++)
            {
                for (var j = 0; j < x; j++)
                {
                    buttonArray[i, j] = cells[k];

                    k++;
                }
            }

            return buttonArray;
        }

        private Button[,] GameLogic(Button[,] cells)
        {
            var counter = 0;
            var nextGen = new Button[y, x];

            for (var row = 0; row < y; row++)
            {
                for (var column = 0; column < x; column++)
                {
                    var amountNeighbors = 0;
                    var currentCell = cells[row, column];

                    var isBorderUp = row == 0;
                    var isBorderLeft = column == 0;
                    var isBorderDown = row == y - 1;
                    var isBorderRight = column == x - 1;

                    var tempRow = row;
                    var tempColumn = column;

                    for (var r = -1; r <= 1; r++)
                    {
                        if (isBorderUp && r == -1) tempRow = y;
                        if (isBorderDown && r == 1) tempRow = -1;
                        for (var c = -1; c <= 1; c++)
                        {
                            if (isBorderLeft && c == -1) tempColumn = x;
                            if (isBorderRight && c == 1) tempColumn = -1;
                            if (cells[tempRow + r, tempColumn + c].BackColor == Color.Red)
                            {
                                amountNeighbors++;
                            }

                            tempColumn = column;
                        }

                        tempRow = row;
                    }

                    amountNeighbors -= currentCell.BackColor == Color.Red ? 1 : 0;

                    // Lebende Zelle mit mehr als 3 Nachbarn, stirbt.
                    bool isGreater3 = (currentCell.BackColor == Color.Red) && (amountNeighbors > 3);

                    // Lebende Zelle mit 2 oder 3 Nachbarn, überlebt.
                    bool is2or3 = (currentCell.BackColor == Color.Red) && (amountNeighbors == 2 || amountNeighbors == 3);

                    // Lebende Zelle mit weniger als 2 Nachbarn, stirbt.
                    bool isLess2 = (currentCell.BackColor == Color.Red) && (amountNeighbors < 2);

                    // Tote Zelle mit genau 3 Nachbarn, wird geboren.
                    bool is3 = (currentCell.BackColor == Color.Transparent) && (amountNeighbors == 3);

                    nextGen[row, column] = new Tools().Btn_cell;

                    if (isGreater3)
                    {
                        nextGen[row, column].BackColor = Color.Transparent;
                    }
                    else if (is2or3)
                    {
                        nextGen[row, column].BackColor = Color.Red;
                    }
                    else if (isLess2)
                    {
                        nextGen[row, column].BackColor = Color.Transparent;
                    }
                    else if (is3)
                    {
                        nextGen[row, column].BackColor = Color.Red;
                    }

                    counter++;
                }
            }

            return nextGen;
        }

        private void RefreshGrid(Button[,] grid)
        {
            var k = 0;

            for (var i = 0; i < y; i++)
            {
                for (var j = 0; j < x; j++)
                {
                    Panel_matchfield.Controls[k].BackColor = grid[i, j].BackColor;

                    k++;
                }
            }

            Panel_matchfield.Refresh();

            Thread.Sleep(TimeSpan.FromMilliseconds(modDelay));
        }

        private async void Btn_resume_Click(object sender, EventArgs e)
        {

            if (Btn_resume.Text == "Pause")
            {
                Btn_resume.Text = "Fortsetzen";
                Btn_steps.Enabled = true;
                isRunning = false;
            }
            else
            {
                Btn_resume.Text = "Pause";
                Btn_steps.Enabled = false;
                isRunning = true;
            }

            var nextGen = buttonArray;

            while (isRunning)
            {
                nextGen = GameLogic(nextGen);
                RefreshGrid(nextGen);
                await Delay();
            }
        }

        private async Task Delay()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(modDelay));
        }

        private void Btn_back_to_menu_main_Click(object sender, EventArgs e)
        {
            Menu_newGame = new Menu_newGame();
            OpenForm(new Menu_main(), Menu_startGame = this);
        }

        private void Btn_resume_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Btn_steps_Click(object sender, EventArgs e)
        {
            buttonArray = GameLogic(buttonArray);
            RefreshGrid(buttonArray);
        }

        private async void trackBar_speed_ValueChanged(object sender, EventArgs e)
        {
            speed = (trackBar_speed.Value) * 0.25;
            modDelay = delay / speed;
            Label_speed_value.Text = (speed).ToString() + "x\nspeed";

            await Task.Delay(1);
        }

        private void ResizeCells()
        {
            var k = 0;
            var dim = Panel_matchfield.Height / y < Panel_matchfield.Width / x ? Panel_matchfield.Height / y : Panel_matchfield.Width / x;

            for (var i = 0; i < y; i++)
            {
                for (var j = 0; j < x; j++)
                {
                    var btn = Panel_matchfield.Controls[k];

                    btn.Size = new Size(dim, dim);
                    btn.Location = new Point(j * btn.Width, i * btn.Height);

                    k++;
                }
            }
        }

        private void Menu_startGame_Load(object sender, EventArgs e)
        {
            ResizeCells();
        }

        private void Menu_startGame_Resize(object sender, EventArgs e)
        {
            ResizeCells();
        }

        private void Menu_startGame_ResizeEnd(object sender, EventArgs e)
        {
            ResizeCells();
        }
    }
}

