using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
	public class Level
	{
		public string LevelName { get; set; }

		public Guid Id { get; set; }

		public Guid CategoryId { get; set; }

		public string Path { get; set; }

		public byte Difficulty { get; set; }

	}
}
