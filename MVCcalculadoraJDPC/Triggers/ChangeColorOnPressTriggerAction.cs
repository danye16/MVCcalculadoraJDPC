using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MVCcalculadoraJDPC.Triggers
{
    public class ChangeColorOnPressTriggerAction : TriggerAction<Button>
    {
        protected override void Invoke(Button sender)
        {
            sender.BackgroundColor = sender.IsPressed ? Color.Red : Color.Gray;
        }
    }
}