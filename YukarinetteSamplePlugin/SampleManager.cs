namespace YukarinetteSamplePlugin
{
	// プラグインごとの動作
	public class SampleManager
	{
		public void Create(string sampleSetting)
		{
			// 音声認識開始時の初期化とか
		}

		public void Dispose()
		{
			// 音声認識終了時のリソース破棄とか
		}

		public void Speech(string text)
		{
			// 音声認識時のメイン処理
			// textに認識した本文が入っている
		}
	}
}