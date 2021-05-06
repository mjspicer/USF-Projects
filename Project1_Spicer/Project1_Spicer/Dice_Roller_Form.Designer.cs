namespace Project1_Spicer
{
    partial class Dice_Roller_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dice_Roller_Form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Button_Roll_Single = new System.Windows.Forms.Button();
            this.Roll_Number = new System.Windows.Forms.NumericUpDown();
            this.label_RollAmt = new System.Windows.Forms.Label();
            this.dice_histo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Button_Roll_Double = new System.Windows.Forms.Button();
            this.Clear_Button1 = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.RichTextBox();
            this.instructionsTextBox = new System.Windows.Forms.RichTextBox();
            this.Random_Seed = new System.Windows.Forms.NumericUpDown();
            this.label_seed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Roll_Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_histo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Random_Seed)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Roll_Single
            // 
            this.Button_Roll_Single.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Roll_Single.BackgroundImage")));
            this.Button_Roll_Single.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Roll_Single.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Roll_Single.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Roll_Single.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Roll_Single.Location = new System.Drawing.Point(16, 194);
            this.Button_Roll_Single.Name = "Button_Roll_Single";
            this.Button_Roll_Single.Size = new System.Drawing.Size(140, 120);
            this.Button_Roll_Single.TabIndex = 0;
            this.Button_Roll_Single.Text = "Single Die Roll";
            this.Button_Roll_Single.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Roll_Single.UseVisualStyleBackColor = true;
            this.Button_Roll_Single.Click += new System.EventHandler(this.Button_Roll_Click);
            // 
            // Roll_Number
            // 
            this.Roll_Number.Location = new System.Drawing.Point(160, 111);
            this.Roll_Number.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Roll_Number.Name = "Roll_Number";
            this.Roll_Number.Size = new System.Drawing.Size(120, 26);
            this.Roll_Number.TabIndex = 1;
            this.Roll_Number.Value = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.Roll_Number.ValueChanged += new System.EventHandler(this.Roll_Number_ValueChanged);
            // 
            // label_RollAmt
            // 
            this.label_RollAmt.AutoSize = true;
            this.label_RollAmt.Location = new System.Drawing.Point(41, 114);
            this.label_RollAmt.Name = "label_RollAmt";
            this.label_RollAmt.Size = new System.Drawing.Size(115, 20);
            this.label_RollAmt.TabIndex = 2;
            this.label_RollAmt.Text = "Number of rolls";
            // 
            // dice_histo
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.Title = "Value Rolled";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea1.AxisY.Title = "No. of Occurences";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.dice_histo.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.dice_histo.Legends.Add(legend1);
            this.dice_histo.Location = new System.Drawing.Point(164, 194);
            this.dice_histo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dice_histo.Name = "dice_histo";
            this.dice_histo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Dice Roll Values";
            this.dice_histo.Series.Add(series1);
            this.dice_histo.Size = new System.Drawing.Size(840, 462);
            this.dice_histo.TabIndex = 3;
            this.dice_histo.Tag = "";
            this.dice_histo.Text = "Dice Rolls";
            // 
            // Button_Roll_Double
            // 
            this.Button_Roll_Double.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Roll_Double.BackgroundImage")));
            this.Button_Roll_Double.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Roll_Double.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_Roll_Double.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Roll_Double.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Roll_Double.Location = new System.Drawing.Point(16, 320);
            this.Button_Roll_Double.Name = "Button_Roll_Double";
            this.Button_Roll_Double.Size = new System.Drawing.Size(140, 120);
            this.Button_Roll_Double.TabIndex = 4;
            this.Button_Roll_Double.Text = "Double Die Roll";
            this.Button_Roll_Double.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Roll_Double.UseVisualStyleBackColor = true;
            this.Button_Roll_Double.Click += new System.EventHandler(this.Button_Roll_Double_Click);
            // 
            // Clear_Button1
            // 
            this.Clear_Button1.Location = new System.Drawing.Point(21, 558);
            this.Clear_Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Clear_Button1.Name = "Clear_Button1";
            this.Clear_Button1.Size = new System.Drawing.Size(135, 40);
            this.Clear_Button1.TabIndex = 5;
            this.Clear_Button1.Text = "Clear Graph";
            this.Clear_Button1.UseVisualStyleBackColor = true;
            this.Clear_Button1.Click += new System.EventHandler(this.Clear_Button1_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.titleTextBox.Location = new System.Drawing.Point(103, 12);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(801, 69);
            this.titleTextBox.TabIndex = 6;
            this.titleTextBox.Text = "Dice Roller - Six Sided Dice Statistics";
            // 
            // instructionsTextBox
            // 
            this.instructionsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.instructionsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsTextBox.Location = new System.Drawing.Point(405, 73);
            this.instructionsTextBox.Name = "instructionsTextBox";
            this.instructionsTextBox.Size = new System.Drawing.Size(599, 101);
            this.instructionsTextBox.TabIndex = 7;
            this.instructionsTextBox.Text = resources.GetString("instructionsTextBox.Text");
            // 
            // Random_Seed
            // 
            this.Random_Seed.Location = new System.Drawing.Point(21, 630);
            this.Random_Seed.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Random_Seed.Name = "Random_Seed";
            this.Random_Seed.Size = new System.Drawing.Size(120, 26);
            this.Random_Seed.TabIndex = 8;
            this.Random_Seed.Value = new decimal(new int[] {
            123,
            0,
            0,
            0});
            this.Random_Seed.ValueChanged += new System.EventHandler(this.Random_Seed_ValueChanged);
            // 
            // label_seed
            // 
            this.label_seed.AutoSize = true;
            this.label_seed.Location = new System.Drawing.Point(26, 607);
            this.label_seed.Name = "label_seed";
            this.label_seed.Size = new System.Drawing.Size(84, 20);
            this.label_seed.TabIndex = 9;
            this.label_seed.Text = "RNG seed";
            // 
            // Dice_Roller_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 686);
            this.Controls.Add(this.label_seed);
            this.Controls.Add(this.Random_Seed);
            this.Controls.Add(this.instructionsTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.Clear_Button1);
            this.Controls.Add(this.Button_Roll_Double);
            this.Controls.Add(this.dice_histo);
            this.Controls.Add(this.label_RollAmt);
            this.Controls.Add(this.Roll_Number);
            this.Controls.Add(this.Button_Roll_Single);
            this.Name = "Dice_Roller_Form";
            this.Text = "Dice Roller";
            ((System.ComponentModel.ISupportInitialize)(this.Roll_Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_histo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Random_Seed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Roll_Single;
        private System.Windows.Forms.NumericUpDown Roll_Number;
        private System.Windows.Forms.Label label_RollAmt;
        private System.Windows.Forms.DataVisualization.Charting.Chart dice_histo;
        private System.Windows.Forms.Button Button_Roll_Double;
        private System.Windows.Forms.Button Clear_Button1;
        private System.Windows.Forms.RichTextBox titleTextBox;
        private System.Windows.Forms.RichTextBox instructionsTextBox;
        private System.Windows.Forms.NumericUpDown Random_Seed;
        private System.Windows.Forms.Label label_seed;
    }
}

