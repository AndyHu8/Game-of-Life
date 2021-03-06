﻿using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Game_of_Life_Win_Form
{
    public partial class Menu_newGame : Menuing
    {
        private int y_number;
        private int x_number;

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
            OpenForm(Menu_main, Menu_newGame = this);
        }

        private void Y_Input_TextChanged(object sender, EventArgs e)
        {
            btn_eingaben_uebernehmen.Enabled = Input_validation();
        }

        private void X_Input_TextChanged(object sender, EventArgs e)
        {
            btn_eingaben_uebernehmen.Enabled = Input_validation();
        }

        private void btn_spielfeld_zufall_Click(object sender, EventArgs e)
        {
            Y_Input.Text = new Random().Next(10, 51).ToString();
            Thread.Sleep(10);
            X_Input.Text = new Random().Next(10, 51).ToString();
        }

        private void btn_eingaben_uebernehmen_Click(object sender, EventArgs e)
        {
            y_previousText = Y_Input.Text;
            x_previousText = X_Input.Text;

            btn_eingaben_uebernehmen.Enabled = false;

            Matchfield = new Matchfield(x_number, y_number);
            btn_start_game.Enabled = true;
            btn_spielfeld_aufrufen.Enabled = true;
            btn_zellen_zufall.Enabled = true;

            Label_size_load.Visible = false;
            Label_input_confirmed.Visible = true;
            Label_matchfield_zero.Visible = false;
        }

        private void btn_zellen_zufall_Click(object sender, EventArgs e)
        {
            if (Matchfield.CurrentMatchfield.Controls.Count <= 0)
            {
                Label_matchfield_zero.Visible = true;
                return;
            }

            Label_loading_done.Visible = false;

            Matchfield.Btn_reset_Click(null, null);

            var cells = Matchfield.CurrentMatchfield.Controls.Cast<Button>().ToArray();
            var amount = new Random().Next(3, cells.Length / 3 + 1);

            for (var i = 0; i < amount; i++)
            {
                var ran = new Random().Next(cells.Length);

                cells[ran].BackColor = Color.Red;

                Thread.Sleep(1);
            }

            Label_random_load.Visible = false;
            Label_loading_done.Visible = true;
        }

        private void btn_spielfeld_aufrufen_Click(object sender, EventArgs e)
        {
            OpenForm(Matchfield, Menu_newGame = this);
        }

        private void btn_start_game_Click(object sender, EventArgs e)
        {
            Menu_main.IsLoadGame = true;
            OpenForm(Menu_startGame = new Menu_startGame(true), Menu_newGame = this);
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
            bool isIntX = int.TryParse(X_Input.Text, out x_number);
            bool isIntY = int.TryParse(Y_Input.Text, out y_number);
            bool isGreaterZeroX = x_number > 0;
            bool isGreaterZeroY = y_number > 0;
            bool isOverMaxBoundsX = x_number > 50;
            bool isOverMaxBoundsY = y_number > 50;
            bool isPreviousX = X_Input.Text == x_previousText;
            bool isPreviousY = Y_Input.Text == y_previousText;

            Label_wrong_input.Visible = false;

            if (X_Input.Text != "")
            {
                if (!isIntX || !isGreaterZeroX || isOverMaxBoundsX)
                {
                    Label_wrong_input.Visible = true;

                    return false;
                }
            }

            if (Y_Input.Text != "")
            {
                if (!isIntY || !isGreaterZeroY || isOverMaxBoundsY)
                {
                    Label_wrong_input.Visible = true;

                    return false;
                }
            }

            if (X_Input.Text == "" || Y_Input.Text == "")
            {
                Label_wrong_input.Visible = false;

                return false;
            }

            if (isPreviousX && isPreviousY)
            {
                Label_wrong_input.Visible = false;

                return false;
            }

            return true;
        }

        public bool Input_validationZumTest(string X_InputText, string Y_InputText)
        {
            bool isIntX = int.TryParse(X_InputText, out x_number);
            bool isIntY = int.TryParse(Y_InputText, out y_number);
            bool isGreaterZeroX = x_number > 0;
            bool isGreaterZeroY = y_number > 0;
            bool isOverMaxBoundsX = x_number > 50;
            bool isOverMaxBoundsY = y_number > 50;
            bool isPreviousX = X_InputText == x_previousText;
            bool isPreviousY = Y_InputText == y_previousText;

            Label_wrong_input.Visible = false;

            if (X_InputText != "")
            {
                if (!isIntX || !isGreaterZeroX || isOverMaxBoundsX)
                {
                    Label_wrong_input.Visible = true;

                    return false;
                }
            }

            if (Y_InputText != "")
            {
                if (!isIntY || !isGreaterZeroY || isOverMaxBoundsY)
                {
                    Label_wrong_input.Visible = true;

                    return false;
                }
            }

            if (X_InputText == "" || Y_InputText == "")
            {
                Label_wrong_input.Visible = false;

                return false;
            }

            if (isPreviousX && isPreviousY)
            {
                Label_wrong_input.Visible = false;

                return false;
            }

            return true;
        }

        private void btn_eingaben_uebernehmen_EnabledChanged(object sender, EventArgs e)
        {
            Label_input_confirmed.Visible = false;
        }

        private void Menu_newGame_VisibleChanged(object sender, EventArgs e)
        {
            Label_loading_done.Visible = false;
        }

        private void btn_eingaben_uebernehmen_MouseDown(object sender, MouseEventArgs e)
        {
            Label_size_load.Visible = true;
            Label_wrong_input.Visible = false;
        }

        private void btn_zellen_zufall_MouseDown(object sender, MouseEventArgs e)
        {
            Label_random_load.Visible = true;
        }

        private void Menu_newGame_Load(object sender, EventArgs e)
        {
            btn_spielfeld_aufrufen.Enabled = false;
            btn_start_game.Enabled = false;
            btn_zellen_zufall.Enabled = false;
        }
    }
}
