using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OpenTabReminder.Views
{
   public class ControlsRepository
    {
       public Label GenerateHeaderLabel()
       {
           return new Label
           {
               HorizontalTextAlignment = TextAlignment.Center,
               Text = "Open tab"
           };
       }
       public Button GenerateOpenTabButton()
       {
           return new Button
           {
               Text = "Open Tab",
               TextColor = Color.Aqua,
               BackgroundColor = Color.Maroon



           };
       } 
    }
}
