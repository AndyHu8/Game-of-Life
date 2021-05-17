using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game_of_Life_Win_Form
{
    public class Menuing : Form
    {

        public static Menu_main Menu_main = new Menu_main();
        public static Menu_newGame Menu_newGame = new Menu_newGame();
        public static Matchfield Matchfield = new Matchfield();
        public static Menu_startGame Menu_startGame = new Menu_startGame();
        public static Menu_gameOver Menu_gameOver = new Menu_gameOver();

        public static void OpenForm(Form newForm, Form oldForm)
        {
            newForm.WindowState = oldForm.WindowState;
            newForm.Show();
            oldForm.Hide();
        }
    }
}
