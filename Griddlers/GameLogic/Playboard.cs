using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI;

namespace GameLogic
{
    public class Playboard
    {
	    public Playboard(string platformName)
	    {
		    Platform = platformName;
	    }

		public string Platform { get; set; }

		public uint Width { get; set; }

		public uint Height { get; set; }

		public Color[] Colours { get; set; }

	    public Color TransparentColor { get; set; }

		public PlayboardTile[,] TileBoard { get; set; }
	}
}
