using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace GameLogic
{
	public class PlayboardTile
	{
		public Color? Color { get; set; }

		public Color SolutionColor { get; set; }

		public uint PositionX { get; set; }

		public uint PositionY { get; set; }
	}
}
