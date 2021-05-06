namespace Project2_Spicer
{
    partial class Dice_roller_form_v2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TitleBox1 = new System.Windows.Forms.RichTextBox();
            this.Dice_Data = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Roll_Number = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Seed_value = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Dbl_Roll_button = new System.Windows.Forms.Button();
            this.Roll_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dice_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Roll_Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seed_value)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBox1
            // 
            this.TitleBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.TitleBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TitleBox1.Location = new System.Drawing.Point(25, 19);
            this.TitleBox1.Name = "TitleBox1";
            this.TitleBox1.Size = new System.Drawing.Size(515, 89);
            this.TitleBox1.TabIndex = 1;
            this.TitleBox1.Text = "Dice Roller (v2) \n\t-with near real-time updates";
            // 
            // Dice_Data
            // 
            chartArea1.AxisX.Title = "Value Rolled";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea1.AxisY.Title = "Number of Occurences";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.Dice_Data.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.Dice_Data.Legends.Add(legend1);
            this.Dice_Data.Location = new System.Drawing.Point(219, 114);
            this.Dice_Data.Name = "Dice_Data";
            this.Dice_Data.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Dice Roll Values";
            this.Dice_Data.Series.Add(series1);
            this.Dice_Data.Size = new System.Drawing.Size(898, 572);
            this.Dice_Data.TabIndex = 2;
            this.Dice_Data.Text = "Dice Roll Values";
            // 
            // Roll_Number
            // 
            this.Roll_Number.Location = new System.Drawing.Point(78, 141);
            this.Roll_Number.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Roll_Number.Name = "Roll_Number";
            this.Roll_Number.Size = new System.Drawing.Size(120, 26);
            this.Roll_Number.TabIndex = 3;
            this.Roll_Number.Value = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.Roll_Number.ValueChanged += new System.EventHandler(this.Roll_Number_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Rolls";
            // 
            // Seed_value
            // 
            this.Seed_value.Location = new System.Drawing.Point(78, 481);
            this.Seed_value.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Seed_value.Name = "Seed_value";
            this.Seed_value.Size = new System.Drawing.Size(120, 26);
            this.Seed_value.TabIndex = 5;
            this.Seed_value.Value = new decimal(new int[] {
            123,
            0,
            0,
            0});
            this.Seed_value.ValueChanged += new System.EventHandler(this.Seed_value_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seed";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Dbl_Roll_button
            // 
            this.Dbl_Roll_button.BackgroundImage = global::Project2_Spicer.Properties.Resources.red_dice_pair;
            this.Dbl_Roll_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dbl_Roll_button.Location = new System.Drawing.Point(25, 315);
            this.Dbl_Roll_button.Name = "Dbl_Roll_button";
            this.Dbl_Roll_button.Size = new System.Drawing.Size(141, 134);
            this.Dbl_Roll_button.TabIndex = 8;
            this.Dbl_Roll_button.Text = "Dice (x2) Roll";
            this.Dbl_Roll_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dbl_Roll_button.UseVisualStyleBackColor = true;
            this.Dbl_Roll_button.Click += new System.EventHandler(this.Dbl_Roll_button_Click);
            // 
            // Roll_button
            // 
            this.Roll_button.BackgroundImage = global::Project2_Spicer.Properties.Resources.red_dice_pair;
            this.Roll_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Roll_button.Location = new System.Drawing.Point(25, 178);
            this.Roll_button.Name = "Roll_button";
            this.Roll_button.Size = new System.Drawing.Size(141, 131);
            this.Roll_button.TabIndex = 0;
            this.Roll_button.Text = "Roll Single Die";
            this.Roll_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Roll_button.UseVisualStyleBackColor = true;
            this.Roll_button.Click += new System.EventHandler(this.Roll_button_Click);
            // 
            // Dice_roller_form_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 698);
            this.Controls.Add(this.Dbl_Roll_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Seed_value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Roll_Number);
            this.Controls.Add(this.Dice_Data);
            this.Controls.Add(this.TitleBox1);
            this.Controls.Add(this.Roll_button);
            this.Name = "Dice_roller_form_v2";
            this.Text = "Dice Roller (v2)";
            ((System.ComponentModel.ISupportInitialize)(this.Dice_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Roll_Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seed_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Roll_button;
        private System.Windows.Forms.RichTextBox TitleBox1;
        protected System.Windows.Forms.DataVisualization.Charting.Chart Dice_Data;
        protected System.Windows.Forms.NumericUpDown Roll_Number;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.NumericUpDown Seed_value;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button Dbl_Roll_button;
        protected System.Windows.Forms.Timer timer1;
    }
}

