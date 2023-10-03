using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApplication.Views
{
	/// <summary>
	/// Interaction logic for CellControl
	/// </summary>
	public partial class CellView : UserControl
	{
		public CellView()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Start color - the darkest color of the cell.
		/// </summary>
		public Color EmptyColor
		{
			get { return (Color)GetValue(EmptyColorProperty); }
			set { SetValue(EmptyColorProperty, value); }
		}

		public static readonly DependencyProperty EmptyColorProperty =
			DependencyProperty.Register(
				"EmptyColor",
				typeof(Color),
				typeof(CellView));

		/// <summary>
		/// Finish color - the lightest color of the cell.
		/// </summary>
		public Color FilledColor
		{
			get { return (Color)GetValue(FilledColorProperty); }
			set { SetValue(FilledColorProperty, value); }
		}

		public static readonly DependencyProperty FilledColorProperty =
			DependencyProperty.Register(
				"FilledColor",
				typeof(Color),
				typeof(CellView));

		/// <summary>
		/// Border color.
		/// </summary>
		public Color BorderColor
		{
			get { return (Color)GetValue(BorderColorProperty); }
			set { SetValue(BorderColorProperty, value); }
		}

		public static readonly DependencyProperty BorderColorProperty =
			DependencyProperty.Register(
				"BorderColor",
				typeof(Color),
				typeof(CellView));

		/// <summary>
		/// Selected Color
		/// </summary>
		/// 

		public Color SelectedColor {
			get { return (Color)GetValue(SelectedColorProperty); }
			set { SetValue(SelectedColorProperty, value); }
		}

		public static readonly DependencyProperty SelectedColorProperty =
			DependencyProperty.Register(
				"SelectedColor",
				typeof(Color),
				typeof(CellView));

	}

}
