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

namespace TestControlsInPopupsNotWorking
{
	/// <summary>
	/// Interaction logic for WithPopup.xaml
	/// </summary>
	public partial class WithPopup : UserControl
	{
		public WithPopup()
		{
			InitializeComponent();
		}

		bool _isEditing;

		private void cmdOpenEditor_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			pEditor.IsOpen = true;
			pEditor.Focus();
		}

		private void cmdOpenEditor_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			UpdateOpenEditorButtonAppearance();
		}

		private void cmdOpenEditor_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
		{
			UpdateOpenEditorButtonAppearance();
		}

		private void pEditor_Opened(object sender, EventArgs e)
		{
			UpdateOpenEditorButtonAppearance();
		}

		private void pEditor_Closed(object sender, EventArgs e)
		{
			UpdateOpenEditorButtonAppearance();
		}

		void UpdateOpenEditorButtonAppearance()
		{
			if (pEditor.IsOpen || cmdOpenEditor.IsMouseOver)
			{
				cmdOpenEditor.BorderBrush = null;
				cmdOpenEditor.Background = null;
			}
			else
			{
				cmdOpenEditor.BorderBrush = Brushes.Transparent;
				cmdOpenEditor.Background = Brushes.Transparent;
			}
		}
	}
}
