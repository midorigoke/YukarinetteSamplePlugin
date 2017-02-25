using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yukarinette

namespace YukarinetteSamplePlugin
{
	public class SamplePlugin : IYukarinetteInterface
	{
		ConfigManager configManager;

		SampleManager sampleManager;

		public override string Name
		{
			get
			{
				return "SamplePlugin";
			}
		}

		public override void Loaded()
		{
			configManager = new ConfigManager();
			configManager.Load(Name);

			sampleManager = new SampleManager();
		}

		public override void Closed()
		{
			configManager.Save(Name);
		}

		public override void Setting()
		{
			OptionWindow.Show(configManager, Name);
		}

		public override void SpeechRecognitionStart()
		{
			sampleManager.Create(configManager.Data.SampleSetting);
		}

		public override void SpeechRecognitionStop()
		{
			sampleManager.Dispose();
		}

		public override void Speech(string text)
		{
			sampleManager.Speech(text);
		}
	}
}
