using Android.Speech.Tts;
using Xamarin.Forms;
using Java.Lang;
using MinhasTarefas.Droid;

[assembly: Dependency(typeof(TextToSpeech_Droid))]
namespace MinhasTarefas.Droid
{
	public class TextToSpeech_Droid : Object, ITextToSpeech, TextToSpeech.IOnInitListener
	{
		TextToSpeech speaker;
		string toSpeak;

		public void Speak(string text)
		{
			if (!string.IsNullOrWhiteSpace(text))
			{
				toSpeak = text;
				if (speaker == null)
					speaker = new TextToSpeech(Forms.Context, this);
				else
				{
					var p = new Android.OS.Bundle();
					speaker.Speak(toSpeak, QueueMode.Flush, p, null);
				}
			}
		}

		#region IOnInitListener implementation
		public void OnInit(OperationResult status)
		{
			if (status.Equals(OperationResult.Success))
			{
				var p = new Android.OS.Bundle();
				speaker.Speak(toSpeak, QueueMode.Flush, p, null);
			}
		}
		#endregion
	}
}
