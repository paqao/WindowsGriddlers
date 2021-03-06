﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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

		public string PlayerName
		{
			get { return _playerName; }
			set {
				if (_playerName != value)
				{
					_playerName = value;
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

		private string _playerName;
		private int _score;
		private int _mapNumber;
		private int _collectionOrderValue;
		private ICommand _showElementByPlayerIdCommand;

		public event PropertyChangedEventHandler PropertyChanged;

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

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
