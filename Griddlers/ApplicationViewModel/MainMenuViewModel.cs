using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationViewModel
{
	public class MainMenuViewModel : INotifyPropertyChanged
	{
		private bool _busyMode;
		public event PropertyChangedEventHandler PropertyChanged;

		public bool BusyMode
		{
			get { return _busyMode; }
			set
			{
				if (_busyMode != value)
				{
					_busyMode = value;
					OnPropertyChanged();
				}
			}
		}


		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
