namespace IocAndDiXamarinForms.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new IocAndDiXamarinForms.App(new TextToSpeechUwpImpl()));
        }
    }
}
