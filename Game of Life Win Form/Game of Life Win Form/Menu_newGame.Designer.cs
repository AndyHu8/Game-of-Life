﻿
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
            this.SuspendLayout();
            // 
            // btn_back_to_menu_main
            // 
            this.btn_back_to_menu_main.Location = new System.Drawing.Point(253, 415);
            this.btn_back_to_menu_main.Name = "btn_back_to_menu_main";
            this.btn_back_to_menu_main.Size = new System.Drawing.Size(75, 23);
            this.btn_back_to_menu_main.TabIndex = 0;
            this.btn_back_to_menu_main.Text = "Zurück";
            this.btn_back_to_menu_main.UseVisualStyleBackColor = true;
            this.btn_back_to_menu_main.Click += new System.EventHandler(this.btn_back_to_menu_main_Click);
            // 
            // Menu_newGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back_to_menu_main);
            this.Name = "Menu_newGame";
            this.Text = "Neues Spiel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back_to_menu_main;
    }
}