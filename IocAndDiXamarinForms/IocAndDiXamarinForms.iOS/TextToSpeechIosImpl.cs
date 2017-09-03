using AVFoundation;
using IocAndDiXamarinForms.iOS;
using IocAndDiXamarinForms.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechIosImpl))]
namespace IocAndDiXamarinForms.iOS
{
    public class TextToSpeechIosImpl : ITextToSpeech
    {
        public void Speak(string text)  
        {
            var speechSynthesizer = new AVSpeechSynthesizer();
            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };
            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}
