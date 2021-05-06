namespace World_Cities
{
	partial class Form_worldCities
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label_City = new System.Windows.Forms.Label();
            this.label_CountryText = new System.Windows.Forms.Label();
            this.label_PopulationText = new System.Windows.Forms.Label();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.label_Population = new System.Windows.Forms.Label();
            this.comboBox_Country = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Location = new System.Drawing.Point(132, 46);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(50, 25);
            this.label_City.TabIndex = 1;
            this.label_City.Text = "City";
            // 
            // label_CountryText
            // 
            this.label_CountryText.AutoSize = true;
            this.label_CountryText.Location = new System.Drawing.Point(348, 46);
            this.label_CountryText.Name = "label_CountryText";
            this.label_CountryText.Size = new System.Drawing.Size(88, 25);
            this.label_CountryText.TabIndex = 2;
            this.label_CountryText.Text = "Country";
            // 
            // label_PopulationText
            // 
            this.label_PopulationText.AutoSize = true;
            this.label_PopulationText.Location = new System.Drawing.Point(710, 46);
            this.label_PopulationText.Name = "label_PopulationText";
            this.label_PopulationText.Size = new System.Drawing.Size(114, 25);
            this.label_PopulationText.TabIndex = 3;
            this.label_PopulationText.Text = "Population";
            // 
            // comboBox_City
            // 
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Location = new System.Drawing.Point(29, 80);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(241, 32);
            this.comboBox_City.TabIndex = 1;
            this.comboBox_City.SelectedIndexChanged += new System.EventHandler(this.comboBox_City_SelectedIndexChanged);
            // 
            // label_Population
            // 
            this.label_Population.AutoSize = true;
            this.label_Population.Location = new System.Drawing.Point(710, 88);
            this.label_Population.Name = "label_Population";
            this.label_Population.Size = new System.Drawing.Size(174, 25);
            this.label_Population.TabIndex = 4;
            this.label_Population.Text = "0                         ";
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Location = new System.Drawing.Point(276, 80);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(241, 32);
            this.comboBox_Country.TabIndex = 8;
            this.comboBox_Country.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Country_SelectionChangeCommitted);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Enabled = false;
            legend2.Name = "Cities";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(464, 140);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.CustomProperties = "PieLabelStyle=Disabled";
            series2.Legend = "Cities";
            series2.Name = "Country Population";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(453, 297);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(154, 203);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(186, 65);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButtonClick);
            // 
            // Form_worldCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.comboBox_Country);
            this.Controls.Add(this.label_Population);
            this.Controls.Add(this.comboBox_City);
            this.Controls.Add(this.label_PopulationText);
            this.Controls.Add(this.label_CountryText);
            this.Controls.Add(this.label_City);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_worldCities";
            this.Text = "Cities of the World";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label_City;
		private System.Windows.Forms.Label label_CountryText;
		private System.Windows.Forms.Label label_PopulationText;
		private System.Windows.Forms.ComboBox comboBox_City;
		private System.Windows.Forms.Label label_Population;
        private System.Windows.Forms.ComboBox comboBox_Country;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button resetButton;
    }
}

