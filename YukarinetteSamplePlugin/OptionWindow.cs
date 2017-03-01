using System.Windows;

namespace YukarinetteSamplePlugin
{
	public partial class OptionWindow
	{
		private OptionWindow(ConfigManager manager)
		{
			InitializeComponent();

			Owner = Application.Current.MainWindow;

			// 現在の設定を設定欄に反映
			sampleSettingTextBox.Text = manager.Data.SampleSetting;
		}

		// 設定画面表示時実行
		public static void Show(ConfigManager manager, string pluginName)
		{
			var optionWindow = new OptionWindow(manager);

			if (optionWindow.ShowDialog().Value)
			{
				optionWindow.Save(manager, pluginName);
			}
		}

		// 設定画面閉止時実行
		private void Save(ConfigManager manager, string pluginName)
		{
			// 設定欄の内容を設定に保存
			manager.Data.SampleSetting = sampleSettingTextBox.Text;

			manager.Save(pluginName);
		}

		private void okButton_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = new bool?(true);
		}
	}
}