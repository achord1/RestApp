using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Logg(object sender, EventArgs e)
        {

            string sUsername = entUsername.Text;
            string sPassword = entPassword.Text;

            if (sUsername == "User" && sPassword == "Pass") {
                App.Current.MainPage = new purchase();
            }
        }
    }
}