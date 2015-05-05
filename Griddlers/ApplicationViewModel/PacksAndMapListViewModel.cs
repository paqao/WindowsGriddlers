using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using GameLogic;
using System.Runtime.Serialization.Json;

namespace ApplicationViewModel
{
	class PacksAndMapListViewModel
	{
		public PacksAndMapListViewModel()
		{
			var myData = GetJsonFromGit("http://www.google.pl"); // Docelowo sciezka gita;
			string line = "";
			while (line != null)
			{
				line = myData.ReadLine();
			}
		}

		private StreamReader GetJsonFromGit(string path)
		{
			WebRequest myRequest;
			myRequest = WebRequest.Create(path);
			Stream objStream;
			objStream = myRequest.GetResponse(); // 
			StreamReader objReader = new StreamReader(objStream);
			return objReader;

		}

	}
}
