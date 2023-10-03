using System.Windows.Input;
using Ikc5.TypeLibrary;
using WpfApplication.Models;

namespace WpfApplication.ViewModels
{
	public class CellViewModel : BaseNotifyPropertyChanged, ICellViewModel
	{
		public CellViewModel(ICell cell = null)
		{
			ChangeCellStateCommand = new DelegateCommand(ChangeCellState, CanChangeCellState);
			if (cell != null)
			{
				Cell = cell;
			}
		}

		#region Cell model

		private ICell _cell;

		public ICell Cell
		{
			get { return _cell; }
			set { SetProperty(ref _cell, value); }
		}

		#endregion Cell model

		#region Commands

		public ICommand ChangeCellStateCommand { get; }

		private void ChangeCellState(object obj)
		{
			if (Cell == null) return;

			if (Cell.State == State.Empty) {
				Cell.State = State.Filled;
			} else if (Cell.State == State.Filled) {
				Cell.State = State.Empty;
			}
				
		}

		private static bool CanChangeCellState(object obj)
		{
			return true;
		}

		#endregion

	}
}
