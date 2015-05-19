using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Griddlers.Common;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Griddlers
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
	    private NavigationHelper _helper;

        public MainPage()
        {
            this.InitializeComponent();
			GameManager manager = new GameManager();
	        _helper = new NavigationHelper(this);
			_helper.SaveState += _helper_SaveState;
			_helper.LoadState += _helper_LoadState;

			Loaded += MainPage_Loaded;
			
			NavigationCacheMode = NavigationCacheMode.Enabled;
        }

	    protected override void OnNavigatedTo(NavigationEventArgs e)
	    {
			_helper.OnNavigatedTo(e);
	    }

	    protected override void OnNavigatedFrom(NavigationEventArgs e)
	    {
		    _helper.OnNavigatedFrom(e);
	    }

	    private void MainPage_Loaded(object sender, RoutedEventArgs e)
		{

		}

		private void _helper_LoadState(object sender, LoadStateEventArgs e)
		{

		}

		private void _helper_SaveState(object sender, SaveStateEventArgs e)
		{
			e.PageState["klucz"] = "key";
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof (RankingPage));
		}

	    private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
	    {
		    await  CreateMuSuperFile();
	    }

	    private async Task CreateMuSuperFile()
	    {
		    var file = await Windows.Storage.ApplicationData.Current.LocalFolder.CreateFileAsync("mySuperFile",CreationCollisionOption.ReplaceExisting);
		    using (var fileStream = await file.OpenAsync(FileAccessMode.ReadWrite))
		    {
			    StreamWriter streamWriter = new StreamWriter(fileStream.AsStream());
			    streamWriter.WriteLine("to jest moja pierwsza linia");
				streamWriter.Flush();
			    fileStream.FlushAsync();
		    }
	    }
    }
}
