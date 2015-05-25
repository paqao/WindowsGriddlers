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
	class CategoryListViewModel : INotifyPropertyChanged
	{
		private ObservableCollection<CategoryViewModel> _categoryList;
		public event PropertyChangedEventHandler PropertyChanged;

		public ObservableCollection<CategoryViewModel> CategoryList
		{
			get { return _categoryList; }
			set
			{
				if (value != _categoryList)
				{
					_categoryList = value;
					OnPropertyChanged();
				}
			}
		}

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (PropertyChanged != null)
				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));

		}
	}
}
