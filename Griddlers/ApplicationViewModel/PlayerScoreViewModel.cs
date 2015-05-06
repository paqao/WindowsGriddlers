using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;
using GameLogic;

namespace ApplicationViewModel
{
	class PlayerScoreViewModel : INotifyPropertyChanged
	{
		public Player Gracz
		{
			private set;
			get;
		}

		public float czas { get; set; }
		public int nrPlanszy { get; set; }
		public event PropertyChangedEventHandler PropertyChanged;
	}
}
