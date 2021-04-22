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
    public partial class Menu_main : Form
    {
        public Menu_main()
        {
            InitializeComponent();
        }

        private void btn_new_game_menu_newGame_Click(object sender, EventArgs e)
        {
            Menuing.OpenForm(new Menu_newGame(), this);
        }

        private void Menu_main_DpiChanged(object sender, DpiChangedEventArgs e)
        {
            Menuing.CurrentForm = this;
            Menuing.RepositionComponents();
        }

        private void Menu_main_DpiChangedBeforeParent(object sender, EventArgs e)
        {
            Menuing.PreviousSize = Size;
        }
    }
}
