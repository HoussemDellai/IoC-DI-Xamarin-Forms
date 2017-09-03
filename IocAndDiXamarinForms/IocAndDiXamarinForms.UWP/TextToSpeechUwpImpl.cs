using System;
using Windows.UI.Xaml.Controls;
using IocAndDiXamarinForms.Interfaces;
using IocAndDiXamarinForms.UWP;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechUwpImpl))]
namespace IocAndDiXamarinForms.UWP
{
    public class TextToSpeechUwpImpl : ITextToSpeech
    {
        public async void Speak(string text)
        {
            var mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            var stream = await synth.SynthesizeTextToStreamAsync(text);

            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }
    }
}
