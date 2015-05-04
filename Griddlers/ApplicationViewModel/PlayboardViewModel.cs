using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using ApplicationViewModel.Annotations;
using GameLogic;

namespace ApplicationViewModel
{
    public class PlayboardViewModel : INotifyPropertyChanged
    {
	    public Playboard Board
	    {
		    private set; 
			get; 
		}

	    public PlayboardViewModel(Playboard board)
	    {
		    Board = board;
		    GenerateHints();
	    }

	    private void GenerateHints()
	    {
			GenerateColumnsViewModel();
			GenerateRowsViewModel();
	    }

	    private void GenerateRowsViewModel()
		{
			
			Rows = new RowHintViewModel[Board.Height];

			for (int j = 0; j < Board.Height; j++)
			{
				var rowVM = new RowHintViewModel();
				rowVM.Tiles = new List<TileHintViewModel>();

				Color currentTileColor = Board.TileBoard[j, 0].SolutionColor;
				int colorLen = 1;

				for (int i = 1; i < Board.Width; i++)
				{
					if (Board.TileBoard[j, i].SolutionColor == currentTileColor)
					{
						colorLen++;
					}
					else
					{
						if (currentTileColor != Board.TransparentColor)
						{
							TileHintViewModel thvm = new TileHintViewModel();
							thvm.Color = currentTileColor;
							thvm.Amount = colorLen;
							rowVM.Tiles.Add(thvm);
						}
						currentTileColor = Board.TileBoard[j, i].SolutionColor;
						colorLen = 1;
					}
				}
				if (currentTileColor != Board.TransparentColor)
				{
					TileHintViewModel thvm = new TileHintViewModel();
					thvm.Color = currentTileColor;
					thvm.Amount = colorLen;
					rowVM.Tiles.Add(thvm);
				}
			}
	    }

	    private void GenerateColumnsViewModel()
	    {
		    Columns = new ColumnHintViewModel[Board.Width];

		    for (int i = 0; i < Board.Width; i++)
		    {
			    var columnVM = new ColumnHintViewModel();
			    columnVM.Tiles = new List<TileHintViewModel>();

			    Color currentTileColor = Board.TileBoard[0, i].SolutionColor;
			    int colorLen = 1;

			    for (int j = 1; j < Board.Height; j++)
			    {
				    if (Board.TileBoard[j, i].SolutionColor == currentTileColor)
				    {
					    colorLen++;
				    }
				    else
				    {
					    if (currentTileColor != Board.TransparentColor)
					    {
						    TileHintViewModel thvm = new TileHintViewModel();
						    thvm.Color = currentTileColor;
						    thvm.Amount = colorLen;
						    columnVM.Tiles.Add(thvm);
					    }
					    currentTileColor = Board.TileBoard[j, i].SolutionColor;
					    colorLen = 1;
				    }
			    }
			    if (currentTileColor != Board.TransparentColor)
			    {
				    TileHintViewModel thvm = new TileHintViewModel();
				    thvm.Color = currentTileColor;
				    thvm.Amount = colorLen;
				    columnVM.Tiles.Add(thvm);
			    }
		    }
	    }

	    public ColumnHintViewModel[] Columns;
	    public RowHintViewModel[] Rows;

	    public event PropertyChangedEventHandler PropertyChanged;

	    [NotifyPropertyChangedInvocator]
	    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	    {
		    var handler = PropertyChanged;
		    if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
	    }
    }
}
