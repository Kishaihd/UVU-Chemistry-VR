using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.GifAssets.PowerGif.Examples.Scripts
{
	/// <summary>
	/// Decoding GIF example.
	/// Important note: we can't work with UI and Texture2D in threads. To workaround this:
	/// 1. SimpleGif deals with SimpleGif.Texture2D, which contains pixel array the same as UnityEngine.Texture2D.
	/// 2. You should call DecodeParallel from Coroutine to display progress and result.
	/// </summary>
	public class DecodeParallelExample : ExampleBase
	{
		public AnimatedImage AnimatedImage;
		public Image ProgressFill;

		public IEnumerator Start()
		{
			Debug.LogFormat("Decoding using {0} threads...", SystemInfo.processorCount);

			var bytes = File.ReadAllBytes(LargeSample);
			var decodeProgress = new SimpleGif.Data.DecodeProgress();

			SimpleGif.Gif.DecodeParallel(bytes, progress => { decodeProgress = progress; }); // Threads are started here.

			while (!decodeProgress.Completed)
			{
				ProgressFill.fillAmount = (float) decodeProgress.Progress / decodeProgress.FrameCount;

				yield return null;
			}

			if (decodeProgress.Exception != null)
			{
				Debug.LogError(decodeProgress.Exception.Message);

				yield break;
			}

			var frames = Converter.ConvertFrames(decodeProgress.Gif.Frames);
			var gif = new Gif(frames);

			AnimatedImage.Play(gif);
		}
	}
}