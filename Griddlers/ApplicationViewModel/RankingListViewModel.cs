using GameLogic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using ApplicationViewModel.Annotations;

namespace ApplicationViewModel
{
	public class RankingListViewModel : INotifyPropertyChanged
	{
		private ICommand _clearRankingCommand;
		private ICommand _showElementByPlayerIdCommand;


		public ObservableCollection<ResultViewModel> Results { get; set; }

		public ICommand ClearRankingCommand
		{
			get { return _clearRankingCommand; }
			set {
				if (_clearRankingCommand != value)
				{
					_clearRankingCommand = value;
					OnPropertyChanged();
				} }
		}

		public ICommand ShowElementByPlayerIdCommand
		{
			get { return _showElementByPlayerIdCommand; }
			set
			{
				if (_showElementByPlayerIdCommand != value)
				{
					_showElementByPlayerIdCommand = value;
					OnPropertyChanged();
				}
			}
		}

		public RankingListViewModel()
		{
			List<ResultViewModel> myResultList = new List<ResultViewModel>();

			myResultList.Add(new ResultViewModel(){CollectionOrderValue = 1, MapNumber = 1, PlayerId = 1, Score = 100});
			myResultList.Add(new ResultViewModel() { CollectionOrderValue = 1, MapNumber = 1, PlayerId = 2, Score = 130 });

			ShowElementByPlayerIdCommand = new ShowElementCommand(this);
			foreach (var resultViewModel in myResultList)
			{
				resultViewModel.ShowElementByPlayerIdCommand = ShowElementByPlayerIdCommand;
			}

			Results = new ObservableCollection<ResultViewModel>(myResultList);

			var clearRankingViewModel = new ClearRankingCommand(this);
			this.ClearRankingCommand = clearRankingViewModel;
			

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

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}

		public void RankingClear()
		{
			Results.Clear();
		}
	}

	public class ShowElementCommand : ICommand
	{
		private RankingListViewModel _rankingVM;

		public ShowElementCommand(RankingListViewModel listViewModel)
		{
			_rankingVM = listViewModel;
		}

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{

			int playerId = (int)parameter;

			var player = _rankingVM.Results.FirstOrDefault(x => x.PlayerId == playerId);

			if (player == null)
				return;

			String format = String.Format("Imie: {0} Wynik: {1}", player.PlayerId, player.Score);

			MessageDialog dialog = new MessageDialog(format);
			dialog.ShowAsync();
		}

		public event EventHandler CanExecuteChanged;
	}
}
