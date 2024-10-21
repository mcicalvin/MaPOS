using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Masoft.POS
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Close_Click(object sender, RoutedEventArgs e)
		{
			var msgBox = MessageBox.Show("Are you sure you want to close this system?",
				"Exit application", MessageBoxButton.YesNo, MessageBoxImage.Question);

			if(msgBox == MessageBoxResult.Yes)
			{
				Application.Current.Shutdown();
			}
        }

    }
}