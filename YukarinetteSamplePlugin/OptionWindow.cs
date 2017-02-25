using System.Windows;
using System.Windows.Markup;
using Yukarinette;

namespace YukarinetteSamplePlugin
{
	public partial class OptionWindow
	{
		private OptionWindow(ConfigManager manager)
		{
			InitializeComponent();

			Owner = Application.Current.MainWindow;

			sampleSettingTextBox.Text = manager.Data.SampleSetting;
		}

		public static void Show(ConfigManager manager, string pluginName)
		{
			var optionWindow = new OptionWindow(manager);

			if (optionWindow.ShowDialog().Value)
			{
				optionWindow.Save(manager, pluginName);
			}
		}

		private void Save(ConfigManager manager, string pluginName)
		{
			manager.Data.SampleSetting = sampleSettingTextBox.Text;

			manager.Save(pluginName);
		}

		private void okButton_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = new bool?(true);
		}
	}
}