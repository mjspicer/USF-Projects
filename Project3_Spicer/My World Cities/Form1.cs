using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_Cities
{
	public partial class Form_worldCities : Form
	{
		// This holds the raw data read from the City Country file
		private string[] rawCityCountryData = null;
		// Here we store the mapping from city to Country
		Dictionary<string, string> countryOf = null;
		// Here we store the mapping from city to population
		Dictionary<string, int> populationOf = null;
		// Here we store the mapping from country to its corresponding list of cities
		Dictionary<string, List<String>> countryCities = null;
				
		/// <summary>
		/// Constructor for the main form
		/// </summary>
		public Form_worldCities()
		{
			// This initializes the form and all of its components
			InitializeComponent();

			// Now that the form's components have been initialized
			// We can go load the City Country data
			loadData();
			// And then we fill the combo box
			fillListBox();
		}


		/// <summary>
		/// Handle the selection of a new city event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void comboBox_City_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Get the selected city;
			string city = comboBox_City.SelectedItem.ToString();
			// Set its country
			comboBox_Country.Text = countryOf[city];
			// Set its population
			label_Population.Text = populationOf[city].ToString("N0");
			Text = comboBox_City.Items.Count.ToString();
		}

		/// <summary>
		/// Handle the selection of a new country event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void comboBox_Country_SelectionChangeCommitted(object sender, EventArgs e)
		{
			// New Dictionary for calculating country's population
			Dictionary<string, int> countryPop = new Dictionary<string, int>();
			// Get the selected country;
			string country = comboBox_Country.SelectedItem.ToString();
			// Clear the city combobox
			comboBox_City.Items.Clear();
			// Fill combobox with selected country's cities
			foreach (string city in countryCities[country])
            {
				comboBox_City.Items.Add(city);
				countryPop.Add(city, populationOf[city]); // for calculating country population
            }
			// Sort the combobox cities by population
			sortCities(countryPop);
			// Ensure the top city is showing
			comboBox_City.SelectedIndex = 0;
			// Set the population label to the country's population
			label_Population.Text = computePopulation(countryPop).ToString("N0");
			Text = comboBox_City.Items.Count.ToString();
			// Create the pie chart of cities and population
			createChart(countryPop);
		}

		public class populationCityPair
		{
			// The population
			public int population;
			// The city
			public string city;
			/// <summary>
			/// Simple constructor for a popuation/City pair
			/// </summary>
			/// <param name="pop"></param>
			/// <param name="city"></param>
			public populationCityPair(int pop, String city) 
			{ 
				// Just set the population and city fields
				population = pop; 
				this.city = city; 
			}
		};

		/// <summary>
		/// Handle the selection of the reset button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void resetButtonClick(object sender, EventArgs e)
        {
			// Clear the city combobox
			comboBox_City.Items.Clear();
			// Clear the pie chart
			foreach (var series in chart1.Series)
			{
				series.Points.Clear();
			}
			chart1.Enabled.Equals(false);
			// Refill the city combobox like it was at the start of the app
			fillListBox();
			// Sort them by population
			sortCities(populationOf);
			// Ensure the top city is selected
			comboBox_City.SelectedIndex = 0;
        }
    }
}
