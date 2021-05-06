namespace Project1_Spicer
{
    partial class Double_Dice_Roller_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Double_Dice_Roller_Form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.titleTextBox2 = new System.Windows.Forms.RichTextBox();
            this.instructionTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Button_Roll2 = new System.Windows.Forms.Button();
            this.Roll_Number2 = new System.Windows.Forms.NumericUpDown();
            this.Random_Seed2 = new System.Windows.Forms.NumericUpDown();
            this.Clear_Button2 = new System.Windows.Forms.Button();
            this.dice_histo2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_RollAmt2 = new System.Windows.Forms.Label();
            this.label_seed2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Roll_Number2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Random_Seed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_histo2)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTextBox2
            // 
            this.titleTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.titleTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.titleTextBox2.Location = new System.Drawing.Point(103, 12);
            this.titleTextBox2.Name = "titleTextBox2";
            this.titleTextBox2.Size = new System.Drawing.Size(885, 65);
            this.titleTextBox2.TabIndex = 0;
            this.titleTextBox2.Text = "Dice Roller - Six Sided Dice (x2) Statistics";
            // 
            // instructionTextBox2
            // 
            this.instructionTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.instructionTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructionTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionTextBox2.Location = new System.Drawing.Point(405, 73);
            this.instructionTextBox2.Name = "instructionTextBox2";
            this.instructionTextBox2.Size = new System.Drawing.Size(599, 101);
            this.instructionTextBox2.TabIndex = 1;
            this.instructionTextBox2.Text = resources.GetString("instructionTextBox2.Text");
            // 
            // Button_Roll2
            // 
            this.Button_Roll2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Roll2.BackgroundImage")));
            this.Button_Roll2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Roll2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Roll2.Location = new System.Drawing.Point(16, 194);
            this.Button_Roll2.Name = "Button_Roll2";
            this.Button_Roll2.Size = new System.Drawing.Size(140, 120);
            this.Button_Roll2.TabIndex = 0;
            this.Button_Roll2.Text = "Double Die Roll";
            this.Button_Roll2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Roll2.UseVisualStyleBackColor = true;
            this.Button_Roll2.Click += new System.EventHandler(this.Button_Roll2_Click);
            // 
            // Roll_Number2
            // 
            this.Roll_Number2.Location = new System.Drawing.Point(160, 111);
            this.Roll_Number2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Roll_Number2.Name = "Roll_Number2";
            this.Roll_Number2.Size = new System.Drawing.Size(120, 26);
            this.Roll_Number2.TabIndex = 1;
            this.Roll_Number2.Value = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.Roll_Number2.ValueChanged += new System.EventHandler(this.Roll_Number2_ValueChanged);
            // 
            // Random_Seed2
            // 
            this.Random_Seed2.Location = new System.Drawing.Point(21, 630);
            this.Random_Seed2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Random_Seed2.Name = "Random_Seed2";
            this.Random_Seed2.Size = new System.Drawing.Size(120, 26);
            this.Random_Seed2.TabIndex = 8;
            this.Random_Seed2.Value = new decimal(new int[] {
            123,
            0,
            0,
            0});
            this.Random_Seed2.ValueChanged += new System.EventHandler(this.Random_Seed2_ValueChanged);
            // 
            // Clear_Button2
            // 
            this.Clear_Button2.Location = new System.Drawing.Point(21, 558);
            this.Clear_Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Clear_Button2.Name = "Clear_Button2";
            this.Clear_Button2.Size = new System.Drawing.Size(135, 40);
            this.Clear_Button2.TabIndex = 5;
            this.Clear_Button2.Text = "Clear Graph";
            this.Clear_Button2.UseVisualStyleBackColor = true;
            this.Clear_Button2.Click += new System.EventHandler(this.Clear_Button2_Click);
            // 
            // dice_histo2
            // 
            chartArea5.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisX.Title = "Value Rolled";
            chartArea5.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisY.Title = "No. of Occurences";
            chartArea5.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.Name = "ChartArea1";
            this.dice_histo2.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.dice_histo2.Legends.Add(legend5);
            this.dice_histo2.Location = new System.Drawing.Point(164, 194);
            this.dice_histo2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dice_histo2.Name = "dice_histo2";
            this.dice_histo2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Dice Roll Values";
            this.dice_histo2.Series.Add(series5);
            this.dice_histo2.Size = new System.Drawing.Size(840, 462);
            this.dice_histo2.TabIndex = 8;
            this.dice_histo2.Text = "Dice Rolls";
            // 
            // label_RollAmt2
            // 
            this.label_RollAmt2.AutoSize = true;
            this.label_RollAmt2.Location = new System.Drawing.Point(41, 114);
            this.label_RollAmt2.Name = "label_RollAmt2";
            this.label_RollAmt2.Size = new System.Drawing.Size(115, 20);
            this.label_RollAmt2.TabIndex = 9;
            this.label_RollAmt2.Text = "Number of rolls";
            // 
            // label_seed2
            // 
            this.label_seed2.AutoSize = true;
            this.label_seed2.Location = new System.Drawing.Point(26, 607);
            this.label_seed2.Name = "label_seed2";
            this.label_seed2.Size = new System.Drawing.Size(84, 20);
            this.label_seed2.TabIndex = 9;
            this.label_seed2.Text = "RNG seed";
            // 
            // Double_Dice_Roller_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 686);
            this.Controls.Add(this.label_seed2);
            this.Controls.Add(this.label_RollAmt2);
            this.Controls.Add(this.dice_histo2);
            this.Controls.Add(this.Clear_Button2);
            this.Controls.Add(this.Random_Seed2);
            this.Controls.Add(this.Roll_Number2);
            this.Controls.Add(this.Button_Roll2);
            this.Controls.Add(this.instructionTextBox2);
            this.Controls.Add(this.titleTextBox2);
            this.Name = "Double_Dice_Roller_Form";
            this.Text = "Double Dice Roller";
            ((System.ComponentModel.ISupportInitialize)(this.Roll_Number2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Random_Seed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_histo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox titleTextBox2;
        private System.Windows.Forms.RichTextBox instructionTextBox2;
        private System.Windows.Forms.Button Button_Roll2;
        private System.Windows.Forms.NumericUpDown Roll_Number2;
        private System.Windows.Forms.NumericUpDown Random_Seed2;
        private System.Windows.Forms.Button Clear_Button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart dice_histo2;
        private System.Windows.Forms.Label label_RollAmt2;
        private System.Windows.Forms.Label label_seed2;
    }
}