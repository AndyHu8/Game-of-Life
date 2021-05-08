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
    public partial class Menu_main : Menuing
    {
        public Menu_main()
        {
            InitializeComponent();
        }

        private void btn_new_game_menu_newGame_Click(object sender, EventArgs e)
        {
            Label_no_existing_game.Visible = false;
            OpenForm(Menu_newGame, Menu_main = this);
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_load_game_Click(object sender, EventArgs e)
        {
            if (Menu_startGame != null) OpenForm(Menu_startGame, Menu_main = this);
            else Label_no_existing_game.Visible = true;
        }

        private void Menu_main_Load(object sender, EventArgs e)
        {
            if (Menu_startGame != null) btn_load_game.Enabled = true;
            else btn_load_game.Enabled = false;
        }
    }
}
