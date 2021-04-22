
namespace Game_of_Life_Win_Form
{
    partial class Tools
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
            this.Btn_cell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_cell
            // 
            this.Btn_cell.BackColor = System.Drawing.Color.Transparent;
            this.Btn_cell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_cell.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_cell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Btn_cell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_cell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cell.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_cell.Location = new System.Drawing.Point(-1, -1);
            this.Btn_cell.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_cell.Name = "Btn_cell";
            this.Btn_cell.Size = new System.Drawing.Size(25, 25);
            this.Btn_cell.TabIndex = 0;
            this.Btn_cell.UseVisualStyleBackColor = false;
            this.Btn_cell.Click += new System.EventHandler(this.Btn_cell_Click);
            // 
            // Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_cell);
            this.Name = "Tools";
            this.Text = "Tools";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Btn_cell;
    }
}