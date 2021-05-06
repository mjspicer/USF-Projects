namespace Project2_Spicer
{
    partial class Chart_Control_Form
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Rolls_button = new System.Windows.Forms.Button();
            this.Time_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.richTextBox1.Location = new System.Drawing.Point(104, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(451, 41);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "How should the chart update?";
            // 
            // Rolls_button
            // 
            this.Rolls_button.BackgroundImage = global::Project2_Spicer.Properties.Resources.kisscc0_casino_dice_gambling_craps_board_game_five_red_dice_5b711e93a9e1f5_1435653215341400516959;
            this.Rolls_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Rolls_button.Location = new System.Drawing.Point(304, 59);
            this.Rolls_button.Name = "Rolls_button";
            this.Rolls_button.Size = new System.Drawing.Size(269, 232);
            this.Rolls_button.TabIndex = 1;
            this.Rolls_button.Text = "# of Rolls";
            this.Rolls_button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Rolls_button.UseVisualStyleBackColor = true;
            this.Rolls_button.Click += new System.EventHandler(this.Rolls_button_Click);
            // 
            // Time_button
            // 
            this.Time_button.BackgroundImage = global::Project2_Spicer.Properties.Resources.png_clipart_stopwatch_clock_clock_desktop_wallpaper_timer;
            this.Time_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Time_button.Location = new System.Drawing.Point(29, 59);
            this.Time_button.Name = "Time_button";
            this.Time_button.Size = new System.Drawing.Size(269, 232);
            this.Time_button.TabIndex = 0;
            this.Time_button.Text = "Time";
            this.Time_button.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Time_button.UseVisualStyleBackColor = true;
            this.Time_button.Click += new System.EventHandler(this.Time_button_Click);
            // 
            // Chart_Control_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 303);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Rolls_button);
            this.Controls.Add(this.Time_button);
            this.Name = "Chart_Control_Form";
            this.Text = "Chart Control";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Time_button;
        private System.Windows.Forms.Button Rolls_button;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}