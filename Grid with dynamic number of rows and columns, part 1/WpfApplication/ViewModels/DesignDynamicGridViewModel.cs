using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApplication.ViewModels
{
	internal class DesignDynamicGridViewModel : IDynamicGridViewModel
	{
		public ObservableCollection<ObservableCollection<ICellViewModel>> Cells { get; } = null;
		public int GridWidth { get; } = 5;
		public int GridHeight { get; } = 5;
		public Color EmptyColor { get; set; } = Colors.White;
		public Color FilledColor { get; set; } = Colors.Black;
		public Color BorderColor { get; set; } = Colors.DarkGray;
		public Color SelectedColor { get; set; } = Colors.White;

	}
}
