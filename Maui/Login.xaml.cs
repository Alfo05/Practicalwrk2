using Microsoft.Maui.Controls;
namespace Maui
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            var tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += (s, e) =>
            {
                Navigation.PopAsync(new ForgotPasswrd());
            };
            this.FindByName<Label>("ForgotPasswordLabel")?.GestureRecognizers.Add(tapGesture);
        }
    }
    
}

