using Microsoft.Maui.Controls;

namespace Maui
{
    public partial class ForgotPassword : ContentPage
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        private void SendOnClick(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            if (string.IsNullOrEmpty(email))
            {
                confirmationLabel.Text = "Enter A Valid Email Address";
                return;
            }
            else
            {
                confirmationLabel.Text = "Check Inbox For Recovery";
            }
        }
    }
}