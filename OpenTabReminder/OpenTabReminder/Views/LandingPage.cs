using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTabReminder.Models;
using Xamarin.Forms;

namespace OpenTabReminder.Views
{
    public class LandingPage : ContentPage
    {
        public User CurrentUser { get; }

        public LandingPage()
        {
            CurrentUser = getCurrentUser();
            var controlBank = new ControlsRepository();
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = 
                {
                     CreateMainUserLabel(controlBank.GenerateHeaderLabel()),
                     controlBank.GenerateOpenTabButton()
                }
            };

        }

        private Label CreateMainUserLabel(Label headerLabel)
        {
            headerLabel.Text = CurrentUser.Name;
            return headerLabel;
        }
        private User getCurrentUser()
        {
            //jh
            //logic to get sometype of user information from native phone
            return new User();
        }

   }
}

