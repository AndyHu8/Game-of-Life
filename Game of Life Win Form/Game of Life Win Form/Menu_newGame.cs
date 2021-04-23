using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Game_of_Life_Win_Form
{
    public partial class Menu_newGame : Form
    {
        public int Y_Zahl { get; set; }
        public int X_Zahl { get; set; }

        private string x_previousText;
        private string y_previousText;

        public Menu_newGame()
        {
            InitializeComponent();

            x_previousText = X_Input.Text;
            y_previousText = Y_Input.Text;
        }

        private void btn_back_to_menu_main_Click(object sender, EventArgs e)
        {
            Menuing.OpenForm(new Menu_main(), this);
        }

        private void Y_Input_TextChanged(object sender, EventArgs e)
        {
            btn_eingaben_uebernehmen.Enabled = (y_previousText != Y_Input.Text || x_previousText != X_Input.Text) && y_previousText != "" ? true : false;
        }

        private void X_Input_TextChanged(object sender, EventArgs e)
        {
            btn_eingaben_uebernehmen.Enabled = (x_previousText != X_Input.Text || y_previousText != Y_Input.Text) && x_previousText != "" ? true : false;
        }

        private void btn_spielfeld_zufall_Click(object sender, EventArgs e)
        {
            Y_Input.Text = new Random().Next(10, 51).ToString();
            Thread.Sleep(10);
            X_Input.Text = new Random().Next(10, 51).ToString();
        }

        private void btn_eingaben_uebernehmen_Click(object sender, EventArgs e)
        {
            Y_Zahl = int.Parse(Y_Input.Text);
            X_Zahl = int.Parse(X_Input.Text);

            y_previousText = Y_Input.Text;
            x_previousText = X_Input.Text;

            btn_eingaben_uebernehmen.Enabled = false;
        }

        private void btn_zellen_zufall_Click(object sender, EventArgs e)
        {

        }

        private void btn_spielfeld_aufrufen_Click(object sender, EventArgs e)
        {
            Menuing.OpenForm(new Matchfield(X_Zahl, Y_Zahl), this);
        }

        private void btn_start_game_Click(object sender, EventArgs e)
        {

        }

        private void X_Input_Leave(object sender, EventArgs e)
        {
            X_Input.Text = X_Input.Text == "" ? "0" : X_Input.Text;
        }

        private void Y_Input_Leave(object sender, EventArgs e)
        {
            Y_Input.Text = Y_Input.Text == "" ? "0" : Y_Input.Text;
        }
    }
}
