using Microsoft.Maui.Controls;
namespace Maui
{
    public partial class Signup : ContentPage
    {
        public Signup()
        {
            InitializeComponent();
        }
        private void SignUpOnClick(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string email = emailEntry.Text;
            string password = passwrdEntry.Text;
            string confirmPassword = confirmPasswrdEntry.Text;
            if (username != null && email != null && password != null)
            {
                messageLabel.Text = "Please Complete the Form";
                return;
            }
            if (password != confirmPassword)
            {
                messageLabel.Text = "Passwords dont match";
                return;
            }
            
        }
    }
}