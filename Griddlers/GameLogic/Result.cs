using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
	public class Result
	{


		public int PlayerId { get; set; }
		public int Score { get; set; }
		public int MapNumber { get; set; }
			
			public Result(int playerId, int score, int mapNumber)
			{
				PlayerId = playerId;
				Score = score;
				MapNumber=mapNumber;
			}
		
	}
}
