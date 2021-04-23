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
            OpenForm(new Menu_newGame(), this);
        }

    }
}
