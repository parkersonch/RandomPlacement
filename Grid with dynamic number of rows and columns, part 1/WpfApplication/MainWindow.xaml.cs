using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication.ViewModels;

namespace WpfApplication
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			var dynamicGridViewModel = new DynamicGridViewModel
			{
				GridWidth = 3,
				GridHeight = 3,
				BorderColor = Colors.Gray,
				EmptyColor = Colors.White,
				FilledColor = Colors.CornflowerBlue,
				SelectedColor = Colors.OrangeRed
			};

			DataContext = dynamicGridViewModel;
		}
	}
}
