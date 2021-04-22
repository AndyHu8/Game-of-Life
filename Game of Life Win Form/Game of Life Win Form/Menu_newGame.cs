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
    public partial class Menu_newGame : Form
    {
        public int Y_Zahl { get; set; }
        public int X_Zahl { get; set; }

        public Menu_newGame()
        {
            InitializeComponent();
        }

        private void btn_back_to_menu_main_Click(object sender, EventArgs e)
        {
            Menuing.OpenForm(new Menu_main(), this);
        }

        private void Y_Input_TextChanged(object sender, EventArgs e){}

        private void X_Input_TextChanged(object sender, EventArgs e){}

        private void btn_spielfeld_zufall_Click(object sender, EventArgs e)
        {
            Y_Zahl = new Random().Next(10, 51);
            X_Zahl = new Random().Next(10, 51);
        }

        private void btn_eingaben_uebernehmen_Click(object sender, EventArgs e)
        {
            Y_Zahl = Int32.Parse(Y_Input.Text);
            X_Zahl = Int32.Parse(X_Input.Text);
        }

        private void btn_zellen_zufall_Click(object sender, EventArgs e)
        {

        }

        private void btn_spielfeld_aufrufen_Click(object sender, EventArgs e)
        {

        }

        private void btn_start_game_Click(object sender, EventArgs e)
        {

        }
    }
}
