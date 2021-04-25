using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life_Win_Form
{
    public partial class Menu_startGame : Menuing
    {
        private int x;
        private int y;

        public Menu_startGame()
        {
            InitializeComponent();
        }

        public Menu_startGame(int x, int y)
        {
            InitializeComponent();

            this.x = x;
            this.y = y;

            Panel_matchfield = Matchfield.CurrentMatchfield;

            foreach (var button in Panel_matchfield.Controls.Cast<Button>())
            {
                button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                //button.CausesValidation = false;
            }


        }

        private void GameLogic()
        {
            var cells = Panel_matchfield.Controls.Cast<Button>().ToArray();

            // bsp: 20x20 feld: aktuelle zelle index = 20, nachbarn: index = 0, 1, 2, 19, 21, 38, 39, 40






            // Durch alle Zellen iterieren.
            for (var i = 0; i < x; i++)
            {
                // Ränder, Thorus anwenden.
                var border1 = i == i * x;
                var border2 = i < x && i >= 0;
                var border3 = i >= y * x - x && i <= x * y;
                var border4 = i == i * x - 1;

                // Nachbarn ermitteln.
                var amountNeighbors = 0;
                var b = -1;
                for (var a = 0; a < 3; a++)
                {
                    var formula1 = i - x + b;
                    amountNeighbors += cells[formula1].BackColor == Color.Red ? 1 : 0;
                    amountNeighbors -= formula1 == i ? 1 : 0;

                    var formula2 = i + b;
                    amountNeighbors += cells[formula2].BackColor == Color.Red ? 1 : 0;
                    amountNeighbors -= formula2 == i ? 1 : 0;

                    var formula3 = i + x + b;
                    amountNeighbors += cells[formula3].BackColor == Color.Red ? 1 : 0;
                    amountNeighbors -= formula3 == i ? 1 : 0;

                    b++;
                }

                // Lebende Zelle mit mehr als 3 Nachbarn, stirbt.
                bool isGreater3 = amountNeighbors > 3;

                // Lebende Zelle mit 2 oder 3 Nachbarn, überlebt.
                bool is2or3 = amountNeighbors == 2 || amountNeighbors == 3;

                // Lebende Zelle mit weniger als 2 Nachbarn, stirbt.
                bool isLess2 = amountNeighbors < 2;

                // Tote Zelle mit genau 3 Nachbarn, wird geboren.
                bool is3 = amountNeighbors == 3;

                if (isGreater3)
                {
                    cells[i].BackColor = Color.Transparent;
                }
                else if (is2or3)
                {
                    cells[i].BackColor = Color.Red;
                }
                else if (isLess2)
                {
                    cells[i].BackColor = Color.Transparent;
                }
                else if (is3)
                {
                    cells[i].BackColor = Color.Red;
                }

                Task.Delay(1000);
            }
        }
    }
}
