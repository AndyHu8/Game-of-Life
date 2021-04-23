
namespace Game_of_Life_Win_Form
{
    partial class Matchfield
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
            this.Btn_back = new System.Windows.Forms.Button();
            this.Btn_reset = new System.Windows.Forms.Button();
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
            this.Panel_matchfield.Size = new System.Drawing.Size(910, 411);
            this.Panel_matchfield.TabIndex = 0;
            // 
            // Btn_back
            // 
            this.Btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_back.AutoSize = true;
            this.Btn_back.Location = new System.Drawing.Point(9, 491);
            this.Btn_back.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(910, 50);
            this.Btn_back.TabIndex = 1;
            this.Btn_back.Text = "Zurück";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // Btn_reset
            // 
            this.Btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_reset.AutoSize = true;
            this.Btn_reset.Location = new System.Drawing.Point(9, 430);
            this.Btn_reset.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_reset.Name = "Btn_reset";
            this.Btn_reset.Size = new System.Drawing.Size(910, 50);
            this.Btn_reset.TabIndex = 2;
            this.Btn_reset.Text = "Zurücksetzen";
            this.Btn_reset.UseVisualStyleBackColor = true;
            this.Btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // Matchfield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 550);
            this.Controls.Add(this.Btn_reset);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.Panel_matchfield);
            this.Name = "Matchfield";
            this.Text = "Spielfeld";
            this.Resize += new System.EventHandler(this.Matchfield_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_matchfield;
        private System.Windows.Forms.Button Btn_back;
        private System.Windows.Forms.Button Btn_reset;
    }
}