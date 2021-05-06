using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// This part establishes some utilities
/// Was created by adding a new item --> Text File
/// </summary>
namespace World_Cities
{
	// Let's add a loading method
	public partial class Form_worldCities : Form
	{
		/// <summary>
		/// This method reads the file of Cities and Countrues
		/// </summary>
		/// <returns>void</returns>
		private  void loadData()
		{
			// Get the filepath to the file
			// First let us get the path to bin
			string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
			// Now walk back up twice to get to the solution folder
			_filePath = Directory.GetParent(_filePath).FullName;
			_filePath = Directory.GetParent(_filePath).FullName;
			// Now add the name of the file
			_filePath += @"\City Country.txt";
			// Read each line of the file into a string array. Each element
			// of the array is one line of the file.
			rawCityCountryData = System.IO.File.ReadAllLines(_filePath);
			// Now go fill the dictionaries
			fillDictionaries();
			return;
		}

		/// <summary>
		/// Fill in the function that will fill the dictionaries
		/// </summary>
		public bool fillDictionaries()
		{
			// First, we instantiate the dictionaries we will use
			// First the country dictionary
			countryOf = new Dictionary<string, string>();
			// Then the city population dictionary
			populationOf = new Dictionary<string, int>();
			// Finally, the country's cities dictionary
			countryCities = new Dictionary<string, List<string>>();
						
			// Those will be the delimiters between our strings
			// The fields are separated by tabs ('\t')
			// We do not use space (' ') because of cities like "Abu Dhabi"
			char[] delimiterChars = { '\t' };
			// This will mark success or not
			bool success = true;
			// Scan the lines
			foreach (string line in rawCityCountryData)
			{
				// Now parse the line into substrings
				string[] words = line.Split(delimiterChars);
				// Get the city
				string cityString = words[1];
				// The population
				string popString = words[2];
				// The country
				string countryString = words[3];
				// Convert population string to int
				success = Int32.TryParse(popString, out int pop);
				// If this failed
				if (!success)
				{
					// Throw an execption
					throw new Exception("Bad population string:" + popString);
				}

				// Ok, we successfully read the information about 1 city
				// For now we simply skip existing cities
				if (countryOf.ContainsKey(cityString) == false)
				{
					// Update the dictionary of city/country
					countryOf.Add(cityString, countryString);
					// Update dictionary of city/population
					populationOf.Add(cityString, pop);
				}
			}
			// Now using the data from the first two dictionaries, we fill the final dictionary
			// First we group countryOf by country (value) then convert to a dictionary using the country as the key
			// and compressing the cities into a list https://stackoverflow.com/questions/19518531/reverse-key-and-value-in-dictionary
			countryCities = countryOf.GroupBy(p => p.Value).ToDictionary(g => g.Key, g => g.Select(pp => pp.Key).ToList());
			
			// We made it to here. Thus success
			return success;
		}

		/// <summary>
		/// Fill the combo boxes from the dictionaries
		/// </summary>
		public void fillListBox()
		{
			// Scan the countries dictionary and fill the associated listboxes
			// This is done by scanning the KeyValuePairs 
			foreach (KeyValuePair<string, string> cityCountry in countryOf)
			{
				// From each KeyValuePair we have 
				// the city
				string city = cityCountry.Key;
				// Add it to the city combo box
				comboBox_City.Items.Add(city);

			}

			// Scan the countries dictionary and fill the associated listboxes
			// This is done by scanning the KeyValuePairs 
			foreach (KeyValuePair<string, string> cityCountry in countryOf)
			{
				// From each KeyValuePair we have 
				// the country
				string country = cityCountry.Value;
				// Add it to the country combo box
				if (comboBox_Country.Items.Contains(country) == false)
				{
					comboBox_Country.Items.Add(country);
				}
			}

			// Set the selected item to be the first one
			comboBox_City.SelectedIndex = 0;
			// Get the selected city
			string selectedCity = comboBox_City.Text;
			// display its country
			comboBox_Country.Text = countryOf[selectedCity];
			// and display its population
			label_Population.Text = populationOf[selectedCity].ToString("N0");
		}

		/// <summary>
		/// This sorts the cities and sets the combo box and labels
		/// </summary>
		public void sortCities(Dictionary<string, int> population_param)
		{
			// Instantiate alist of population/city pairs
			List<populationCityPair> listOfPairs = new List<populationCityPair>();

			// Scan all the KeyValuePairs of the population dictionary
			foreach (KeyValuePair<string, int> kvp in population_param)
			{
				// Get the city
				string city = kvp.Key; 
				int pop = kvp.Value;
				// Add the pair to a list of pairs 
				listOfPairs.Add(new populationCityPair(pop, city));
			}
			// Now that we have all the pairs, we sort them
			// You are passed 2 pairs (x and y)
			// We compare their populations to sort them
			listOfPairs.Sort((x, y) => (y.population.CompareTo(x.population)));

			// We have sorted the list of pairs
			// We now clear the combo list box
			comboBox_City.Items.Clear();
			// We now want to fill the combo box wiht the cities 
			foreach (populationCityPair pcp in listOfPairs)
			{
				// Get the city
				string city = pcp.city;
				// Add it to the city combo box
				comboBox_City.Items.Add(pcp.city);
			}

			// Set the selected city to be the first one
			comboBox_City.SelectedIndex = 0;
			// Get the selected city
			string selectedCity = comboBox_City.Text;
			// display its country
			comboBox_Country.Text = countryOf[selectedCity];
			// and display its population
			// label_Population.Text = populationOf[selectedCity].ToString("N0");
		}

		/// <summary>
		/// Compute the population of all the cities in the ComboBox
		/// </summary>
		public int computePopulation(Dictionary<string, int> population_param)
		{
			// Compute the total population
			// Get all the cities
			int population = 0;		// Initialize the population to zero
			foreach (KeyValuePair<string, int> kvp in population_param)
			{
				// Get the population of the current keyValuePair
				int p = kvp.Value;
				// Add it to the total population
				population += p;
			}
			return population;
		}

		/// <summary>
		/// Create a pie chart that displays the cities of a given country using the population as the data
		/// </summary>
		public void createChart(Dictionary<string, int> series_param)
        {
			// Enable the chart
			chart1.Enabled.Equals(true);
			// Clear any previous chart data
			foreach (var series in chart1.Series)
            {
				series.Points.Clear();
            }
			// Set the chart to a pie chart
			chart1.Series["Country Population"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			// Populate the chart with data from each city of the selected country
			foreach (var kvp in series_param)
            {
				chart1.Series["Country Population"].Points.AddXY(kvp.Key, kvp.Value);
            }
		}
	}
}