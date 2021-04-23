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
        public static Form CurrentForm { get; set; }
        public static bool IsSaved { get; set; }

        public Matchfield(int x, int y)
        {
            InitializeComponent();

            var btn_cell = new Tools().Btn_cell;
            var totalWidthCenter = x * btn_cell.Width / 2;
            var totalHeigthCenter = y * btn_cell.Height / 2;
            var panelWidthCenter = Panel_matchfield.Width / 2;
            var panelHeightCenter = Panel_matchfield.Height / 2;

            for (var i = 0; i < y; i++)
            {
                for (var j = 0; j < x; j++)
                {
                    btn_cell = new Tools().Btn_cell;

                    btn_cell.Location = new Point(panelWidthCenter - totalWidthCenter + j * btn_cell.Width, panelHeightCenter - totalHeigthCenter + i * btn_cell.Height);
                    Panel_matchfield.Controls.Add(btn_cell);
                }
            }

            Panel_matchfield.HorizontalScroll.SmallChange = btn_cell.Width;
            Panel_matchfield.VerticalScroll.SmallChange = btn_cell.Height;
        }

        private void Matchfield_Resize(object sender, EventArgs e)
        {
            var width = Width - 34;
            Panel_matchfield.Width = width;
            Panel_matchfield.Height = Height - 178;
            Btn_back.Width = width;
            Btn_reset.Width = width;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            IsSaved = true;
            CurrentForm = this;

            Menuing.OpenForm(Menuing.PreviousForm, this);
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            foreach (var control in Panel_matchfield.Controls)
            {
                var con = control as Button;

                con.BackColor = Color.Transparent;
            }
        }
    }
}
