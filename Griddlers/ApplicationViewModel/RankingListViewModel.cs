using GameLogic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationViewModel
{
	class RankingListViewModel : INotifyPropertyChanged
	{

		public event PropertyChangedEventHandler PropertyChanged;

		public ObservableCollection<ResultViewModel> Results { get; set; } 

		public void RankMyResults()
		{
			List<ResultViewModel> myResultList = new List<ResultViewModel>();

			myResultList.Add(new ResultViewModel(){CollectionOrderValue = 1, MapNumber = 1, PlayerId = 1, Score = 100});
			myResultList.Add(new ResultViewModel() { CollectionOrderValue = 1, MapNumber = 1, PlayerId = 2, Score = 130 });

			Results = new ObservableCollection<ResultViewModel>(myResultList);
			//myResultList.Add(new Result(1, 232, 1));
			//myResultList.Add(new Result(2, 213, 1));
			// Add a lot of more results


			// sortowanie ??
			//	myResultList.OrderBy(n => n)
			//.Select((n, index) => new NumberRank(n, index));

			/*	var RankedPlayers = myResultList.OrderByDescending(p => p.Score)
							.GroupBy(p => p.Score)
							.Select((grp, i, nr) => new
							{
								Rank = i,
								Players = grp.OrderByDescending(g => g.PlayerId),
								Map = n.OrderByDescending(n=>n.MapNumber)
							})
							.Dump();*/

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
