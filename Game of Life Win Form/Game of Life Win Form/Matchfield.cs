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
    public partial class Matchfield : Form
    {
        private Tools tools { get { return new Tools(); } }

        public Matchfield()
        {
            InitializeComponent();

            for (var i = 0; i < 50; i++)
            {
                for (var j = 0; j < 50; j++)
                {
                    var btn_cell = tools.Btn_cell;

                    btn_cell.Location.Offset(j * btn_cell.Width, i * btn_cell.Height);
                    Panel_matchfield.Controls.Add(btn_cell);
                }
            }
            Panel_matchfield.HorizontalScroll.SmallChange = tools.Btn_cell.Width;
            Panel_matchfield.VerticalScroll.SmallChange = tools.Btn_cell.Height;
        }

        private void Matchfield_Resize(object sender, EventArgs e)
        {
            Panel_matchfield.Width = this.Width - 34;
            Panel_matchfield.Height = this.Height - 108;
        }
    }
}
