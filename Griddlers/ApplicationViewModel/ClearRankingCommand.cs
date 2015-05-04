using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ApplicationViewModel
{
	public class ClearRankingCommand : ICommand
	{
		private RankingListViewModel _rankingVM;

		public ClearRankingCommand(RankingListViewModel listViewModel)
		{
			_rankingVM = listViewModel;
		}

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			if (CanExecute(parameter))
			{
				_rankingVM.RankingClear();
			}
		}

		public event EventHandler CanExecuteChanged;
	}
}
