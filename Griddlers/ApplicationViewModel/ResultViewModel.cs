using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ApplicationViewModel.Annotations;

namespace ApplicationViewModel
{
	public class ResultViewModel : INotifyPropertyChanged
	{
		public int CollectionOrderValue
		{
			get { return _collectionOrderValue; }
			set
			{
				if (_collectionOrderValue != value)
				{
					_collectionOrderValue = value;
					OnPropertyChanged();
				}
			}
		}

		public int PlayerId
		{
			get { return _playerId; }
			set {
				if (_playerId != value)
				{
					_playerId = value;
					OnPropertyChanged();
				} 
			}
		}

		public int Score
		{
			get { return _score; }
			set
			{
				if (_score != value)
				{
					_score = value;
					OnPropertyChanged();
				}
			}
		}

		public int MapNumber
		{
			get { return _mapNumber; }
			set
			{
				if (_mapNumber != value)
				{
					_mapNumber = value;
					OnPropertyChanged();
				}
			}
		}

		private int _playerId;
		private int _score;
		private int _mapNumber;
		private int _collectionOrderValue;

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
