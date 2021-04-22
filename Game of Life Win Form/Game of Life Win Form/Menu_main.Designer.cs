
namespace Game_of_Life_Win_Form
{
    partial class Menu_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_new_game_menu_newGame = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_load_game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_new_game_menu_newGame
            // 
            this.btn_new_game_menu_newGame.Location = new System.Drawing.Point(271, 197);
            this.btn_new_game_menu_newGame.Name = "btn_new_game_menu_newGame";
            this.btn_new_game_menu_newGame.Size = new System.Drawing.Size(131, 66);
            this.btn_new_game_menu_newGame.TabIndex = 0;
            this.btn_new_game_menu_newGame.Text = "Neues Spiel";
            this.btn_new_game_menu_newGame.UseVisualStyleBackColor = true;
            this.btn_new_game_menu_newGame.Click += new System.EventHandler(this.btn_new_game_menu_newGame_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(261, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(298, 55);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Game of Life";
            // 
            // btn_load_game
            // 
            this.btn_load_game.Location = new System.Drawing.Point(428, 197);
            this.btn_load_game.Name = "btn_load_game";
            this.btn_load_game.Size = new System.Drawing.Size(131, 66);
            this.btn_load_game.TabIndex = 2;
            this.btn_load_game.Text = "Spiel laden";
            this.btn_load_game.UseVisualStyleBackColor = true;
            // 
            // menu_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_load_game);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_new_game_menu_newGame);
            this.Name = "menu_main";
            this.Text = "Hauptmenü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_new_game_menu_newGame;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_load_game;
    }
}

