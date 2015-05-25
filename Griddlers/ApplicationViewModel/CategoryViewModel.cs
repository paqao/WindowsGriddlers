using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ApplicationViewModel.Annotations;

namespace ApplicationViewModel
{
	public class CategoryViewModel : INotifyPropertyChanged
	{
		private Guid _id;
		private string _categoryName;
		private ObservableCollection<LevelViewModel> _levelViewModel;
		public event PropertyChangedEventHandler PropertyChanged;

		public Guid Id
		{
			get { return _id; }
			set
			{
				if (value != _id)
				{
					_id = value;
					OnPropertyChanged();
				}
			}
		}

		public string CategoryName
		{
			get { return _categoryName; }
			set
			{
				if (value != _categoryName)
				{
					_categoryName = value;
					OnPropertyChanged();
				}
			}
		}

		public ObservableCollection<LevelViewModel> Levels
		{
			get { return _levelViewModel; }
			set
			{
				if (value != _levelViewModel)
				{
					_levelViewModel = value;
					OnPropertyChanged();
				}
			}
		}
			
		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
