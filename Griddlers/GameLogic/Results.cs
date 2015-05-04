using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
	public class Results
	{


		public int playerId { get; set; }
		public int score { get; set; }
		public int mapNumber { get; set; }
			
			public Results(int _playerId, int _score, int _mapNumber)
			{
				playerId = _playerId;
				score = _score;
				mapNumber=_mapNumber;
			}
		
	}
}
