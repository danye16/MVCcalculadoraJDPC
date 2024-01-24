using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MVCcalculadoraJDPC.Triggers
{
    public class Tcalculadora : TriggerAction<Button>
    {
        /*public bool activacion { get; set; }
        protected override void Invoke(Button sender)
        {
            if (sender.ClassId == "Numero")
                TargetLabel.Text += sender.Text;
        } */
        protected override void Invoke(Button sender)
        {
            sender.BackgroundColor = sender.IsPressed ? Color.Red : Color.Tomato;
        }
    } 
}
