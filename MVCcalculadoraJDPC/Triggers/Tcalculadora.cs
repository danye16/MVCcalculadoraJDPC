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
        private Button botonSeleccionado = null;

        protected override void Invoke(Button sender)
        {
            if (botonSeleccionado != null)
            {
                botonSeleccionado.BackgroundColor = Color.White;
            }

            if (sender != null)
            {
                if (sender.IsPressed)
                {
                    sender.BackgroundColor = Color.Tomato;
                    botonSeleccionado = sender;
                }
                else
                {
                    sender.BackgroundColor = Color.Green;
                }
            }
        }
    }
}
