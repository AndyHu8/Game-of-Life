﻿using System;
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
    public partial class Menu_newGame : Menuing
    {
        private int y_number;
        private int x_number;

        private string x_previousText;
        private string y_previousText;

        private bool ConfirmInput
        {
            get { return x_previousText != X_Input.Text || y_previousText != Y_Input.Text; }
            set { }
        }

        public Menu_newGame()
        {
            InitializeComponent();

            x_previousText = X_Input.Text;
            y_previousText = Y_Input.Text;
        }

        private void btn_back_to_menu_main_Click(object sender, EventArgs e)
        {
            OpenForm(Menu_main, Menu_newGame = this);
        }

        private void Y_Input_TextChanged(object sender, EventArgs e)
        {
            if (Y_Input.Text != "") btn_eingaben_uebernehmen.Enabled = Input_validation() && ConfirmInput;
        }

        private void X_Input_TextChanged(object sender, EventArgs e)
        {
            if (X_Input.Text != "") btn_eingaben_uebernehmen.Enabled = Input_validation() && ConfirmInput;
        }

        private void btn_spielfeld_zufall_Click(object sender, EventArgs e)
        {
            Y_Input.Text = new Random().Next(10, 51).ToString();
            Thread.Sleep(10);
            X_Input.Text = new Random().Next(10, 51).ToString();
        }

        private void btn_eingaben_uebernehmen_Click(object sender, EventArgs e)
        {
            Label_inserted_string.Visible = false;

            y_previousText = Y_Input.Text;
            x_previousText = X_Input.Text;

            btn_eingaben_uebernehmen.Enabled = false;

            Label_size_load.Visible = true;

            new Matchfield(x_number, y_number);

            Label_size_load.Visible = false;

            Label_input_confirmed.Visible = true;
        }

        private void btn_zellen_zufall_Click(object sender, EventArgs e)
        {
            Label_loading_done.Visible = false;
            Label_random_load.Visible = true;

            Matchfield.Btn_reset_Click(null, null);

            var cells = Matchfield.CurrentMatchfield.Controls.Cast<Button>().ToArray();
            var amount = new Random().Next(3, cells.Length / 3 + 1);

            for (var i = 0; i < amount; i++)
            {
                var ran = new Random().Next(cells.Length);

                cells[ran].BackColor = Color.Red;

                Thread.Sleep(1);
            }
            //Matchfield.CurrentMatchfield.Controls.Cast<Button>().ToList().ForEach((x) =>
            //{
            //    var ran = new Random().Next(0, 2);
            //    x.BackColor = ran == 0 ? Color.Red : Color.Transparent;
            //    Thread.Sleep(TimeSpan.FromMilliseconds(0.5));
            //});

            Label_random_load.Visible = false;
            Label_loading_done.Visible = true;
        }

        private void btn_spielfeld_aufrufen_Click(object sender, EventArgs e)
        {
            OpenForm(Matchfield, Menu_newGame = this);
        }

        private void btn_start_game_Click(object sender, EventArgs e)
        {
            OpenForm(Menu_startGame, Menu_newGame = this);
        }

        private void X_Input_Leave(object sender, EventArgs e)
        {
            X_Input.Text = X_Input.Text == "" ? x_previousText : X_Input.Text;
        }

        private void Y_Input_Leave(object sender, EventArgs e)
        {
            Y_Input.Text = Y_Input.Text == "" ? y_previousText : Y_Input.Text;
        }

        private bool Input_validation()
        {
            Label_inserted_string.Visible = !int.TryParse(Y_Input.Text, out y_number) || !int.TryParse(X_Input.Text, out x_number);

            if (x_number > 0 && y_number > 0 && !Label_inserted_string.Visible) return true;

            return false;
        }

        private void btn_eingaben_uebernehmen_EnabledChanged(object sender, EventArgs e)
        {
            Label_input_confirmed.Visible = false;
        }

        private void Menu_newGame_VisibleChanged(object sender, EventArgs e)
        {
            Label_loading_done.Visible = false;
        }
    }
}
