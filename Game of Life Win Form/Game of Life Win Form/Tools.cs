﻿using System;
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
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
        }

        private void Btn_cell_Click(object sender, EventArgs e)
        {
            Btn_cell.BackColor = Btn_cell.BackColor == Color.Red ? Color.Transparent : Color.Red;
        }
    }
}
