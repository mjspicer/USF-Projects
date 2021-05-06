namespace Project2_Spicer
{
    partial class Set_Rolls_Interval_Form
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
            this.Rolls_interval_value = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Done_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Rolls_interval_value)).BeginInit();
            this.SuspendLayout();
            // 
            // Rolls_interval_value
            // 
            this.Rolls_interval_value.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Rolls_interval_value.Location = new System.Drawing.Point(156, 26);
            this.Rolls_interval_value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Rolls_interval_value.Name = "Rolls_interval_value";
            this.Rolls_interval_value.Size = new System.Drawing.Size(120, 26);
            this.Rolls_interval_value.TabIndex = 0;
            this.Rolls_interval_value.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Rolls_interval_value.ValueChanged += new System.EventHandler(this.Rolls_interval_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Roll Interval";
            // 
            // Done_button
            // 
            this.Done_button.Location = new System.Drawing.Point(116, 69);
            this.Done_button.Name = "Done_button";
            this.Done_button.Size = new System.Drawing.Size(102, 44);
            this.Done_button.TabIndex = 2;
            this.Done_button.Text = "Done";
            this.Done_button.UseVisualStyleBackColor = true;
            this.Done_button.Click += new System.EventHandler(this.Done_button_Click);
            // 
            // Set_Rolls_Interval_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 136);
            this.Controls.Add(this.Done_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rolls_interval_value);
            this.Name = "Set_Rolls_Interval_Form";
            this.Text = "Set Roll Interval";
            ((System.ComponentModel.ISupportInitialize)(this.Rolls_interval_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Rolls_interval_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Done_button;
    }
}