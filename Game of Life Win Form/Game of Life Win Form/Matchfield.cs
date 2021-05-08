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
    public partial class Matchfield : Menuing
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Panel CurrentMatchfield { get { return Matchfield.Panel_matchfield; } set { } }

        public Matchfield()
        {
            InitializeComponent();
        }

        public Matchfield(int x, int y)
        {
            InitializeComponent();

            this.X = x;
            this.Y = y;

            CreateField();
        }

        private void Matchfield_Resize(object sender, EventArgs e)
        {
            //var width = Width - 34;
            //Panel_matchfield.Width = width;
            //Panel_matchfield.Height = Height - 178;
            //Btn_back.Width = width;
            //Btn_reset.Width = width;

            //RepositionButtons(x, y, null);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            OpenForm(Menu_newGame, Matchfield = this);
        }

        public void Btn_reset_Click(object sender, EventArgs e)
        {
            foreach (var control in Panel_matchfield.Controls.Cast<Button>())
            {
                control.BackColor = Color.Transparent;
            }
        }

        private Button RepositionButtons(int x, int y, Button button)
        {
            var btn = button ?? new Tools().Btn_cell;

            var totalWidthCenter = x * btn.Width / 2;
            var totalHeigthCenter = y * btn.Height / 2;
            var panelWidthCenter = Panel_matchfield.Width / 2;
            var panelHeightCenter = Panel_matchfield.Height / 2;

            if (button != null) Panel_matchfield.Controls.Clear();

            var buttons = Panel_matchfield.Controls.Cast<Button>().ToArray();
            var k = 0;

            for (var i = 0; i < y; i++)
            {
                for (var j = 0; j < x; j++)
                {
                    btn = button == null ? buttons[k] : new Tools().Btn_cell;

                    btn.Location = new Point(panelWidthCenter - totalWidthCenter + j * btn.Width, panelHeightCenter - totalHeigthCenter + i * btn.Height);

                    if (button != null) Panel_matchfield.Controls.Add(btn);

                    k++;
                }
            }

            return btn;
        }

        public Button CreateField()
        {
            Panel_matchfield.Controls.Clear();

            var btn = new Tools().Btn_cell;

            for (var i = 0; i < Y; i++)
            {
                for (var j = 0; j < X; j++)
                {
                    btn = new Tools().Btn_cell;

                    btn.Size = new Size(Panel_matchfield.Height / Y, Panel_matchfield.Height / Y);
                    btn.Location = new Point(j * btn.Width, i * btn.Height);

                    Panel_matchfield.Controls.Add(btn);
                }
            }

            return btn;
        }

        private void ResizeCells()
        {
            var k = 0;

            for (var i = 0; i < Y; i++)
            {
                for (var j = 0; j < X; j++)
                {
                    var btn = Panel_matchfield.Controls[k];

                    btn.Size = new Size(Panel_matchfield.Height / Y, Panel_matchfield.Height / Y);
                    btn.Location = new Point(j * btn.Width, i * btn.Height);

                    k++;
                }
            }
        }

        private void Matchfield_Load(object sender, EventArgs e)
        {
            ResizeCells();
            //Refresh();
        }

        private void Matchfield_SizeChanged(object sender, EventArgs e)
        {
            ResizeCells();
        }

        private void Panel_matchfield_Paint(object sender, PaintEventArgs e)
        {
            ResizeCells();
        }
    }
}
