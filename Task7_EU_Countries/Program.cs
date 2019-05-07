using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task7_EU_Countries
{
	class Program
	{
		static readonly string textFile = @"C:\Work\Countries.txt";

		static void Main(string[] args)
		{
			
			if (File.Exists(textFile))
			{
				string[] readFile = File.ReadAllLines(textFile);
				Dictionary<int, Country> countries = new Dictionary<int, Country>();
				for (int i = 0; i < readFile.Length; i++)
				{
					Country testCountry = new Country();
					testCountry.Name = readFile[i];
					testCountry.IsTelenorSupported = false;
					countries.Add(i, testCountry);
				}
				Country ukraine = new Country();
				ukraine.Name = "Ukraine";
				countries.Add((countries.Keys.Max() + 1), ukraine);
				foreach (KeyValuePair<int, Country> keyValue in countries)
				{
					if ((keyValue.Value.Name) == "Denmark" || (keyValue.Value.Name) == "Hungary")
					{
						countries[keyValue.Key].IsTelenorSupported = true;
					}
					else
					{
						Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Name + " IsTelenorSupported - " + keyValue.Value.IsTelenorSupported);
					}
				}
			}
			else Console.WriteLine("File not found");
			Console.Read();
		}
	}

	class Country
	{
		public string Name {get; set;}
		public bool IsTelenorSupported { get; set; }

		
	}

	
}	


