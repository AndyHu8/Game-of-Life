
namespace Game_of_Life_Win_Form
{
    partial class Menu_newGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_back_to_menu_main = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.X_Input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Y_Input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_spielfeld_zufall = new System.Windows.Forms.Button();
            this.btn_eingaben_uebernehmen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_zellen_zufall = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_spielfeld_aufrufen = new System.Windows.Forms.Button();
            this.btn_start_game = new System.Windows.Forms.Button();
            this.Label_inserted_string = new System.Windows.Forms.Label();
            this.Label_input_confirmed = new System.Windows.Forms.Label();
            this.Label_random_load = new System.Windows.Forms.Label();
            this.Label_loading_done = new System.Windows.Forms.Label();
            this.Label_size_load = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back_to_menu_main
            // 
            this.btn_back_to_menu_main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back_to_menu_main.Location = new System.Drawing.Point(243, 395);
            this.btn_back_to_menu_main.Name = "btn_back_to_menu_main";
            this.btn_back_to_menu_main.Size = new System.Drawing.Size(121, 23);
            this.btn_back_to_menu_main.TabIndex = 0;
            this.btn_back_to_menu_main.Text = "Zurück";
            this.btn_back_to_menu_main.UseVisualStyleBackColor = true;
            this.btn_back_to_menu_main.Click += new System.EventHandler(this.btn_back_to_menu_main_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Neues Spiel erstellen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Größe des Spielfelds";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "X:";
            // 
            // X_Input
            // 
            this.X_Input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.X_Input.Location = new System.Drawing.Point(97, 123);
            this.X_Input.Name = "X_Input";
            this.X_Input.Size = new System.Drawing.Size(100, 20);
            this.X_Input.TabIndex = 4;
            this.X_Input.TextChanged += new System.EventHandler(this.X_Input_TextChanged);
            this.X_Input.Leave += new System.EventHandler(this.X_Input_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y:";
            // 
            // Y_Input
            // 
            this.Y_Input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Y_Input.Location = new System.Drawing.Point(247, 123);
            this.Y_Input.Name = "Y_Input";
            this.Y_Input.Size = new System.Drawing.Size(100, 20);
            this.Y_Input.TabIndex = 6;
            this.Y_Input.TextChanged += new System.EventHandler(this.Y_Input_TextChanged);
            this.Y_Input.Leave += new System.EventHandler(this.Y_Input_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Per Zufall:";
            // 
            // btn_spielfeld_zufall
            // 
            this.btn_spielfeld_zufall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_spielfeld_zufall.Location = new System.Drawing.Point(463, 121);
            this.btn_spielfeld_zufall.Name = "btn_spielfeld_zufall";
            this.btn_spielfeld_zufall.Size = new System.Drawing.Size(121, 23);
            this.btn_spielfeld_zufall.TabIndex = 8;
            this.btn_spielfeld_zufall.Text = "Zufällig generieren";
            this.btn_spielfeld_zufall.UseVisualStyleBackColor = true;
            this.btn_spielfeld_zufall.Click += new System.EventHandler(this.btn_spielfeld_zufall_Click);
            // 
            // btn_eingaben_uebernehmen
            // 
            this.btn_eingaben_uebernehmen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_eingaben_uebernehmen.Enabled = false;
            this.btn_eingaben_uebernehmen.Location = new System.Drawing.Point(76, 172);
            this.btn_eingaben_uebernehmen.Name = "btn_eingaben_uebernehmen";
            this.btn_eingaben_uebernehmen.Size = new System.Drawing.Size(143, 23);
            this.btn_eingaben_uebernehmen.TabIndex = 9;
            this.btn_eingaben_uebernehmen.Text = "Eingaben übernehmen";
            this.btn_eingaben_uebernehmen.UseVisualStyleBackColor = true;
            this.btn_eingaben_uebernehmen.EnabledChanged += new System.EventHandler(this.btn_eingaben_uebernehmen_EnabledChanged);
            this.btn_eingaben_uebernehmen.Click += new System.EventHandler(this.btn_eingaben_uebernehmen_Click);
            this.btn_eingaben_uebernehmen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_eingaben_uebernehmen_MouseDown);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Positionen der Zellen";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Per Zufall:";
            // 
            // btn_zellen_zufall
            // 
            this.btn_zellen_zufall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_zellen_zufall.Location = new System.Drawing.Point(161, 286);
            this.btn_zellen_zufall.Name = "btn_zellen_zufall";
            this.btn_zellen_zufall.Size = new System.Drawing.Size(121, 23);
            this.btn_zellen_zufall.TabIndex = 12;
            this.btn_zellen_zufall.Text = "Zufällig generieren";
            this.btn_zellen_zufall.UseVisualStyleBackColor = true;
            this.btn_zellen_zufall.Click += new System.EventHandler(this.btn_zellen_zufall_Click);
            this.btn_zellen_zufall.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_zellen_zufall_MouseDown);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(377, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Per Koordinaten:";
            // 
            // btn_spielfeld_aufrufen
            // 
            this.btn_spielfeld_aufrufen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_spielfeld_aufrufen.Location = new System.Drawing.Point(510, 286);
            this.btn_spielfeld_aufrufen.Name = "btn_spielfeld_aufrufen";
            this.btn_spielfeld_aufrufen.Size = new System.Drawing.Size(121, 23);
            this.btn_spielfeld_aufrufen.TabIndex = 14;
            this.btn_spielfeld_aufrufen.Text = "Spielfeld aufrufen";
            this.btn_spielfeld_aufrufen.UseVisualStyleBackColor = true;
            this.btn_spielfeld_aufrufen.Click += new System.EventHandler(this.btn_spielfeld_aufrufen_Click);
            // 
            // btn_start_game
            // 
            this.btn_start_game.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_start_game.Location = new System.Drawing.Point(393, 395);
            this.btn_start_game.Name = "btn_start_game";
            this.btn_start_game.Size = new System.Drawing.Size(121, 23);
            this.btn_start_game.TabIndex = 16;
            this.btn_start_game.Text = "Start";
            this.btn_start_game.UseVisualStyleBackColor = true;
            this.btn_start_game.Click += new System.EventHandler(this.btn_start_game_Click);
            // 
            // Label_inserted_string
            // 
            this.Label_inserted_string.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_inserted_string.AutoSize = true;
            this.Label_inserted_string.ForeColor = System.Drawing.Color.Red;
            this.Label_inserted_string.Location = new System.Drawing.Point(130, 146);
            this.Label_inserted_string.Name = "Label_inserted_string";
            this.Label_inserted_string.Size = new System.Drawing.Size(147, 13);
            this.Label_inserted_string.TabIndex = 17;
            this.Label_inserted_string.Text = "Nur natürliche Zahlen erlaubt!";
            this.Label_inserted_string.Visible = false;
            // 
            // Label_input_confirmed
            // 
            this.Label_input_confirmed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_input_confirmed.AutoSize = true;
            this.Label_input_confirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_input_confirmed.ForeColor = System.Drawing.Color.Red;
            this.Label_input_confirmed.Location = new System.Drawing.Point(73, 207);
            this.Label_input_confirmed.Name = "Label_input_confirmed";
            this.Label_input_confirmed.Size = new System.Drawing.Size(96, 16);
            this.Label_input_confirmed.TabIndex = 18;
            this.Label_input_confirmed.Text = "Gespeichert!";
            this.Label_input_confirmed.Visible = false;
            // 
            // Label_random_load
            // 
            this.Label_random_load.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_random_load.AutoSize = true;
            this.Label_random_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_random_load.ForeColor = System.Drawing.Color.Red;
            this.Label_random_load.Location = new System.Drawing.Point(158, 322);
            this.Label_random_load.Name = "Label_random_load";
            this.Label_random_load.Size = new System.Drawing.Size(54, 16);
            this.Label_random_load.TabIndex = 19;
            this.Label_random_load.Text = "Lädt ...";
            this.Label_random_load.Visible = false;
            // 
            // Label_loading_done
            // 
            this.Label_loading_done.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_loading_done.AutoSize = true;
            this.Label_loading_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_loading_done.ForeColor = System.Drawing.Color.Red;
            this.Label_loading_done.Location = new System.Drawing.Point(158, 322);
            this.Label_loading_done.Name = "Label_loading_done";
            this.Label_loading_done.Size = new System.Drawing.Size(52, 16);
            this.Label_loading_done.TabIndex = 20;
            this.Label_loading_done.Text = "Fertig!";
            this.Label_loading_done.Visible = false;
            // 
            // Label_size_load
            // 
            this.Label_size_load.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_size_load.AutoSize = true;
            this.Label_size_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_size_load.ForeColor = System.Drawing.Color.Red;
            this.Label_size_load.Location = new System.Drawing.Point(73, 207);
            this.Label_size_load.Name = "Label_size_load";
            this.Label_size_load.Size = new System.Drawing.Size(54, 16);
            this.Label_size_load.TabIndex = 1;
            this.Label_size_load.Tag = "";
            this.Label_size_load.Text = "Lädt ...";
            this.Label_size_load.Visible = false;
            // 
            // Menu_newGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_size_load);
            this.Controls.Add(this.Label_loading_done);
            this.Controls.Add(this.Label_random_load);
            this.Controls.Add(this.Label_input_confirmed);
            this.Controls.Add(this.Label_inserted_string);
            this.Controls.Add(this.btn_start_game);
            this.Controls.Add(this.btn_spielfeld_aufrufen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_zellen_zufall);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_eingaben_uebernehmen);
            this.Controls.Add(this.btn_spielfeld_zufall);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Y_Input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.X_Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back_to_menu_main);
            this.HelpButton = true;
            this.Name = "Menu_newGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neues Spiel";
            this.VisibleChanged += new System.EventHandler(this.Menu_newGame_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back_to_menu_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox X_Input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Y_Input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_spielfeld_zufall;
        private System.Windows.Forms.Button btn_eingaben_uebernehmen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_zellen_zufall;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_spielfeld_aufrufen;
        private System.Windows.Forms.Button btn_start_game;
        private System.Windows.Forms.Label Label_inserted_string;
        private System.Windows.Forms.Label Label_input_confirmed;
        private System.Windows.Forms.Label Label_random_load;
        private System.Windows.Forms.Label Label_loading_done;
        private System.Windows.Forms.Label Label_size_load;
    }
}