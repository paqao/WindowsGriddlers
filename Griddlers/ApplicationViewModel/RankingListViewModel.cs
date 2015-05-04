using GameLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationViewModel
{
	class RankingListViewModel : INotifyPropertyChanged
	{

		public event PropertyChangedEventHandler PropertyChanged;



		public void RankMyResults()
		{
			List<Results> myResultList = new List<Results>();

			//myResultList.Add(new Results(1, 232, 1));
			//myResultList.Add(new Results(2, 213, 1));
			// Add a lot of more results

			
			// sortowanie ??
		//	myResultList.OrderBy(n => n)
	   //.Select((n, index) => new NumberRank(n, index));

			var RankedPlayers = myResultList.OrderByDescending(p => p.score)
							.GroupBy(p => p.score)
							.Select((grp, i, nr) => new
							{
								Rank = i,
								Players = grp.OrderByDescending(g => g.playerId),
								Map = n.OrderByDescending(n=>n.mapNumber)
							})
							.Dump();

		//public void showBest20(int nrPlanszy)
		//{
		//int licznik =20;
		//	while(licznik != 0)
		//	{
		//	for(int i =0; i<Ranked)
			
			
		//	}
		
		
		//}


		}











	}
}
