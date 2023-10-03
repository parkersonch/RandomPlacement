using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Media;
using Ikc5.TypeLibrary;
using WpfApplication.Models;

namespace WpfApplication.ViewModels
{
    public class DynamicGridViewModel : BaseNotifyPropertyChanged, IDynamicGridViewModel {
		public DynamicGridViewModel()
		{
			this.SetDefaultValues();
		}

		#region Initialization and recreating

		/// <summary>
		/// Create 2-dimensional array of cells.
		/// </summary>
		/// <returns></returns>
		private ObservableCollection<ObservableCollection<ICellViewModel>> CreateCells()
		{
			var cells = new ObservableCollection<ObservableCollection<ICellViewModel>>();
			for (var posRow = 0; posRow < GridHeight; posRow++)
			{
				var row = new ObservableCollection<ICellViewModel>();
				for (var posCol = 0; posCol < GridWidth; posCol++)
				{
					var cellViewModel = new CellViewModel(Cell.Empty);
					row.Add(cellViewModel);
				}
				cells.Add(row);
			}
			return cells;
		}

		#endregion

		#region IDynamicGridViewModel

		private ObservableCollection<ObservableCollection<ICellViewModel>> _cells;
		private int _gridWidth;
		private int _gridHeight;

		private Color _emptyColor;                  // = Colors.AliceBlue;
		private Color _filledColor;                 // = Colors.DarkBlue;
		private Color _borderColor;                 // = Colors.Gray;
		private Color _selectedColor;

		public ObservableCollection<ObservableCollection<ICellViewModel>> Cells
		{
			get { return _cells; }
			set { SetProperty(ref _cells, value); }
		}

		[DefaultValue(5)]
		public int GridWidth
		{
			get { return _gridWidth; }
			set
			{
				var oldValue = _gridWidth;
				SetProperty(ref _gridWidth, value);

				if (oldValue != value)
					Cells = CreateCells();
			}
		}

		[DefaultValue(5)]
		public int GridHeight
		{
			get { return _gridHeight; }
			set
			{
				var oldValue = _gridHeight;
				SetProperty(ref _gridHeight, value);

				if (oldValue != value)
					Cells = CreateCells();
			}
		}

		/// <summary>
		/// Start, the lighter, color of cells.
		/// </summary>
		[DefaultValue(typeof(Color), "#FFFFFFFF")]
		public Color EmptyColor
		{
			get { return _emptyColor; }
			set { SetProperty(ref _emptyColor, value); }
		}

		/// <summary>
		/// Finish, the darker, color of cells.
		/// </summary>
		[DefaultValue(typeof(Color), "#FF000000")]
		public Color FilledColor
		{
			get { return _filledColor; }
			set { SetProperty(ref _filledColor, value); }
		}

		/// <summary>
		/// Color of borders around cells.
		/// </summary>
		[DefaultValue(typeof(Color), "#232323FF")]
		public Color BorderColor
		{
			get { return _borderColor; }
			set { SetProperty(ref _borderColor, value); }
		}

		[DefaultValue(typeof(Color), "#FF666666")]
        public Color SelectedColor {
			get { return _selectedColor; }
			set { SetProperty(ref _selectedColor, value); }
		}

        #endregion
    }
}
