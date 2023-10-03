using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApplication.ViewModels
{
	public interface IDynamicGridViewModel
	{
		/// <summary>
		/// 2-dimensional collections for CellViewModels.
		/// </summary>
		ObservableCollection<ObservableCollection<ICellViewModel>> Cells { get; }

		/// <summary>
		/// Count of grid columns.
		/// </summary>
		int GridWidth { get; }

		/// <summary>
		/// Count of grid rows.
		/// </summary>
		int GridHeight { get; }

		/// <summary>
		/// Empty cells.
		/// </summary>s
		Color EmptyColor { get; set; }

		/// <summary>
		/// Non-empty cells.
		/// </summary>
		Color FilledColor { get; set; }

		/// <summary>
		/// Selected cells.
		/// </summary>
		Color SelectedColor { get; set; }

		/// <summary>
		/// Color of borders around cells.
		/// </summary>
		Color BorderColor { get; set; }
	}
}