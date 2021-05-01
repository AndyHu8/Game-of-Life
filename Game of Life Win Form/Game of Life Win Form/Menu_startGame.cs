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

        public Menu_startGame()
        {
            InitializeComponent();
        }

        public Menu_startGame(int x, int y)
        {
            InitializeComponent();

            this.x = x;
            this.y = y;

            //Panel_matchfield = Matchfield.CurrentMatchfield;

            CreateField();

            buttonArray = CreateButtonArray2Dim();

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

            Panel_matchfield.Controls.Clear();
            var cPA = Matchfield.CurrentMatchfield.Controls.Cast<Button>().ToList();

            for (var i = 0; i < cPA.Count; i++)
            {
                var cell = new Tools().Btn_cell;

                cell.BackColor = cPA[i].BackColor;
                cell.Location = cPA[i].Location;

                Panel_matchfield.Controls.Add(cell);
                //Thread.Sleep(1);
            }

            //currentPanel.Controls.Cast<Button>().ToList().ForEach(x =>
            //{
            //    Panel_matchfield.Controls.Add(x);
            //});

            //Matchfield.CurrentMatchfield = currentPanel;
        }

        private Button[,] CreateButtonArray2Dim()
        {
            var cells = Panel_matchfield.Controls.Cast<Button>().ToArray();
            var buttonArray = new Button[x, y];

            var k = 0;
            for (var i = 0; i < y; i++)
            {
                for (var j = 0; j < x; j++)
                {
                    buttonArray[j, i] = cells[k];

                    k++;
                }
            }

            return buttonArray;
        }

        private Button[,] GameLogic(Button[,] cells)
        {
            var counter = 0;
            var nextGen = new Button[x, y];

            for (var row = 0; row < y; row++)
            {
                for (var column = 0; column < x; column++)
                {
                    var amountNeighbors = 0;
                    var currentCell = cells[column, row];

                    var isBorderUp = row == 0;
                    var isBorderLeft = column == 0;
                    var isBorderDown = row == y - 1;
                    var isBorderRight = column == x - 1;

                    var tempRow = row;
                    var tempColumn = column;

                    var r = -1;
                    var c = -1;

                    if (isBorderUp) { r = 1; tempRow = y - 1 - r; }
                    if (isBorderLeft) { c = 1; tempColumn = x - 1 - c; }
                    if (isBorderDown) { r = 1; tempRow = 0 - r; }
                    if (isBorderRight) { c = 1; tempColumn = 0 - c; }

                    for (; r <= 1; r++)
                    {
                        for (; c <= 1; c++)
                        {
                            amountNeighbors += cells[tempColumn + c, tempRow + r].BackColor == Color.Red ? 1 : 0;

                            //tempRow = row;
                            //tempColumn = column;
                        }
                    }

                    amountNeighbors -= currentCell.BackColor == Color.Red ? 1 : 0;



                    //// Durch alle Zellen iterieren.
                    //for (var i = 0; i < x; i++)
                    //{
                    //    // Ränder, Thorus anwenden.
                    //    var border1 = i == i * x;
                    //    var border2 = i < x && i >= 0;
                    //    var border3 = i >= y * x - x && i <= x * y;
                    //    var border4 = i == i * x - 1;

                    //    // Nachbarn ermitteln.
                    //    var amountNeighbors = 0;
                    //    var b = -1;
                    //    for (var a = 0; a < 3; a++)
                    //    {
                    //        var formula1 = i - x + b;
                    //        amountNeighbors += cells[formula1].BackColor == Color.Red ? 1 : 0;
                    //        amountNeighbors -= formula1 == i ? 1 : 0;

                    //        var formula2 = i + b;
                    //        amountNeighbors += cells[formula2].BackColor == Color.Red ? 1 : 0;
                    //        amountNeighbors -= formula2 == i ? 1 : 0;

                    //        var formula3 = i + x + b;
                    //        amountNeighbors += cells[formula3].BackColor == Color.Red ? 1 : 0;
                    //        amountNeighbors -= formula3 == i ? 1 : 0;

                    //        b++;
                    //    }

                    // Lebende Zelle mit mehr als 3 Nachbarn, stirbt.
                    bool isGreater3 = (currentCell.BackColor == Color.Red) && (amountNeighbors > 3);

                    // Lebende Zelle mit 2 oder 3 Nachbarn, überlebt.
                    bool is2or3 = (currentCell.BackColor == Color.Red) && (amountNeighbors == 2 || amountNeighbors == 3);

                    // Lebende Zelle mit weniger als 2 Nachbarn, stirbt.
                    bool isLess2 = (currentCell.BackColor == Color.Red) && (amountNeighbors < 2);

                    // Tote Zelle mit genau 3 Nachbarn, wird geboren.
                    bool is3 = (currentCell.BackColor == Color.Transparent) && (amountNeighbors == 3);

                    if (isGreater3)
                    {
                        currentCell.BackColor = Color.Transparent;
                    }
                    else if (is2or3)
                    {
                        currentCell.BackColor = Color.Red;
                    }
                    else if (isLess2)
                    {
                        currentCell.BackColor = Color.Transparent;
                    }
                    else if (is3)
                    {
                        currentCell.BackColor = Color.Red;
                    }

                    Panel_matchfield.Controls[counter].BackColor = currentCell.BackColor;
                    nextGen[column, row] = currentCell;

                    //CreateField();

                    counter++;
                }
            }
            //CreateField();
            Refresh();

            return nextGen;
        }

        private async void Btn_resume_Click(object sender, EventArgs e)
        {

            Btn_resume.Text = Btn_resume.Text == "Pause" ? "Fortsetzen" : "Pause";
            isRunning = Btn_resume.Text == "Pause";

            var nextGen = buttonArray;

            while (isRunning)
            {
                nextGen = GameLogic(nextGen);
                await Task.Delay(1000);
            }
        }

        private void Btn_back_to_menu_main_Click(object sender, EventArgs e)
        {
            Menu_newGame = new Menu_newGame();
            OpenForm(Menu_main, Menu_startGame = this);
        }

        private void Btn_resume_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Btn_steps_Click(object sender, EventArgs e)
        {
            var cells = CreateButtonArray2Dim();

            GameLogic(cells);
        }
    }
}

