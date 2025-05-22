using Microsoft.Maui.Controls;
namespace Maui
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            var tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += (s, e) =>
            {
                Navigation.PushAsync(new ForgotPassword());
            };
            this.FindByName<Label>("ForgotPasswordLabel")?.GestureRecognizers.Add(tapGesture);
        }
        private async void OnClickLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calculator());
        }
    }
    
}

