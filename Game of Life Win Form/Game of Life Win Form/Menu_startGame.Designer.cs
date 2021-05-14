
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
            this.Btn_resume = new System.Windows.Forms.Button();
            this.Btn_back_to_menu_main = new System.Windows.Forms.Button();
            this.Btn_steps = new System.Windows.Forms.Button();
            this.trackBar_speed = new System.Windows.Forms.TrackBar();
            this.Label_speed = new System.Windows.Forms.Label();
            this.Label_speed_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_matchfield
            // 
            this.Panel_matchfield.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_matchfield.AutoScroll = true;
            this.Panel_matchfield.BackColor = System.Drawing.Color.Transparent;
            this.Panel_matchfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_matchfield.Location = new System.Drawing.Point(9, 9);
            this.Panel_matchfield.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_matchfield.Name = "Panel_matchfield";
            this.Panel_matchfield.Size = new System.Drawing.Size(782, 311);
            this.Panel_matchfield.TabIndex = 3;
            // 
            // Btn_resume
            // 
            this.Btn_resume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_resume.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_resume.Location = new System.Drawing.Point(211, 393);
            this.Btn_resume.Name = "Btn_resume";
            this.Btn_resume.Size = new System.Drawing.Size(75, 23);
            this.Btn_resume.TabIndex = 4;
            this.Btn_resume.Text = "Fortsetzen";
            this.Btn_resume.UseVisualStyleBackColor = true;
            this.Btn_resume.Click += new System.EventHandler(this.Btn_resume_Click);
            this.Btn_resume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_resume_MouseDown);
            // 
            // Btn_back_to_menu_main
            // 
            this.Btn_back_to_menu_main.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_back_to_menu_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_back_to_menu_main.Location = new System.Drawing.Point(451, 393);
            this.Btn_back_to_menu_main.Name = "Btn_back_to_menu_main";
            this.Btn_back_to_menu_main.Size = new System.Drawing.Size(131, 23);
            this.Btn_back_to_menu_main.TabIndex = 5;
            this.Btn_back_to_menu_main.Text = "Zurück zum Hauptmenü";
            this.Btn_back_to_menu_main.UseVisualStyleBackColor = true;
            this.Btn_back_to_menu_main.Click += new System.EventHandler(this.Btn_back_to_menu_main_Click);
            // 
            // Btn_steps
            // 
            this.Btn_steps.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_steps.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_steps.Location = new System.Drawing.Point(292, 393);
            this.Btn_steps.Name = "Btn_steps";
            this.Btn_steps.Size = new System.Drawing.Size(75, 23);
            this.Btn_steps.TabIndex = 6;
            this.Btn_steps.Text = "Schritt";
            this.Btn_steps.UseVisualStyleBackColor = true;
            this.Btn_steps.Click += new System.EventHandler(this.Btn_steps_Click);
            // 
            // trackBar_speed
            // 
            this.trackBar_speed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar_speed.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar_speed.Location = new System.Drawing.Point(49, 381);
            this.trackBar_speed.Maximum = 20;
            this.trackBar_speed.Minimum = 1;
            this.trackBar_speed.Name = "trackBar_speed";
            this.trackBar_speed.Size = new System.Drawing.Size(156, 45);
            this.trackBar_speed.TabIndex = 7;
            this.trackBar_speed.Value = 4;
            this.trackBar_speed.ValueChanged += new System.EventHandler(this.trackBar_speed_ValueChanged);
            // 
            // Label_speed
            // 
            this.Label_speed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label_speed.AutoSize = true;
            this.Label_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_speed.Location = new System.Drawing.Point(77, 362);
            this.Label_speed.Name = "Label_speed";
            this.Label_speed.Size = new System.Drawing.Size(106, 16);
            this.Label_speed.TabIndex = 8;
            this.Label_speed.Text = "Geschwindigkeit";
            // 
            // Label_speed_value
            // 
            this.Label_speed_value.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label_speed_value.AutoSize = true;
            this.Label_speed_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_speed_value.Location = new System.Drawing.Point(103, 410);
            this.Label_speed_value.Name = "Label_speed_value";
            this.Label_speed_value.Size = new System.Drawing.Size(47, 16);
            this.Label_speed_value.TabIndex = 9;
            this.Label_speed_value.Text = "debug";
            this.Label_speed_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu_startGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_speed_value);
            this.Controls.Add(this.Label_speed);
            this.Controls.Add(this.trackBar_speed);
            this.Controls.Add(this.Btn_steps);
            this.Controls.Add(this.Btn_back_to_menu_main);
            this.Controls.Add(this.Btn_resume);
            this.Controls.Add(this.Panel_matchfield);
            this.Name = "Menu_startGame";
            this.Text = "Menu_startGame";
            this.Load += new System.EventHandler(this.Menu_startGame_Load);
            this.ResizeEnd += new System.EventHandler(this.Menu_startGame_ResizeEnd);
            this.Resize += new System.EventHandler(this.Menu_startGame_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Panel_matchfield;
        private System.Windows.Forms.Button Btn_resume;
        private System.Windows.Forms.Button Btn_back_to_menu_main;
        private System.Windows.Forms.Button Btn_steps;
        private System.Windows.Forms.TrackBar trackBar_speed;
        private System.Windows.Forms.Label Label_speed;
        private System.Windows.Forms.Label Label_speed_value;
    }
}