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
		public List<PlayerScoreViewModel> Wyniki { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
