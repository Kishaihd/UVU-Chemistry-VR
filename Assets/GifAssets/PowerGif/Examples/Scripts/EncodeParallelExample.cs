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
	/// 2. You should call EncodeParallel from Coroutine to display progress and result.
	/// </summary>
	public class EncodeParallelExample : ExampleBase
	{
		public AnimatedImage AnimatedImage;
		public Image ProgressFill;

		#if UNITY_EDITOR

		public IEnumerator Start()
		{
			var path = UnityEditor.EditorUtility.SaveFilePanel("Save", SampleFolder, "Encoded", "gif");

			if (path == "") yield break;

			yield return null;

			Debug.LogFormat("Decoding...");

			yield return null;

			var bytes = File.ReadAllBytes(LargeSample);
			var gif = Gif.Decode(bytes);
			var encodeProgress = new SimpleGif.Data.EncodeProgress();
			var simpleGif = Converter.Convert(gif); // Removing Unity stuff dependencies (Texture2D, Color32).

			Debug.LogFormat("Encoding using {0} threads...", SystemInfo.processorCount);

			simpleGif.EncodeParallel(progress => { encodeProgress = progress; });  // Threads are started here.

			while (!encodeProgress.Completed)
			{
				ProgressFill.fillAmount = (float) encodeProgress.Progress / encodeProgress.FrameCount;

				yield return null;
			}

			if (encodeProgress.Exception != null)
			{
				Debug.LogError(encodeProgress.Exception.Message);

				yield break;
			}

			File.WriteAllBytes(path, encodeProgress.Bytes);
			Debug.LogFormat("Saved to: {0}.", path);
			AnimatedImage.Play(gif);
		}

		#endif
	}
}