
namespace Game_of_Life_Win_Form
{
    partial class Menu_startGame
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
            this.Panel_matchfield = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Panel_matchfield
            // 
            this.Panel_matchfield.AutoScroll = true;
            this.Panel_matchfield.BackColor = System.Drawing.Color.Transparent;
            this.Panel_matchfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_matchfield.Location = new System.Drawing.Point(9, 9);
            this.Panel_matchfield.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_matchfield.Name = "Panel_matchfield";
            this.Panel_matchfield.Size = new System.Drawing.Size(782, 311);
            this.Panel_matchfield.TabIndex = 3;
            // 
            // Menu_startGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel_matchfield);
            this.Name = "Menu_startGame";
            this.Text = "Menu_startGame";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_matchfield;
    }
}