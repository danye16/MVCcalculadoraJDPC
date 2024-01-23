using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVCcalculadoraJDPC.VistaModelo
{
    public class VMcalculadora : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        double _Numero1;
        double _Numero2;
        double _Numero3;
        double _Numero4;
        double _Numero5;
        double _Numero6;
        double _Numero7;
        double _Numero8;
        double _Numero9;
        double _Numero0;
        string _MostrarPantalla;
        double Resultado;
        double auxiliar1;
        double auxiliar2;
        string operacion;
        double Resultado2;





        #endregion
        #region CONSTRUCTOR
        public VMcalculadora(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public string MostrarPantalla
        {
            get { return _MostrarPantalla; }
            set { SetValue(ref _MostrarPantalla, value); }
        }

        public double Numero1
        {
            get { return _Numero1; }
            set { SetValue(ref _Numero1, value); }
        }
      
        public double Numero2
        {
            get { return _Numero2; }
            set { SetValue(ref _Numero2, value); }
        }
        public double Numero3
        {
            get { return _Numero3; }
            set { SetValue(ref _Numero3, value); }
        }
        public double Numero4
        {
            get { return _Numero4; }
            set { SetValue(ref _Numero4, value); }
        }
        public double Numero5
        {
            get { return _Numero5; }
            set { SetValue(ref _Numero5, value); }
        }
        public double Numero6
        {
            get { return _Numero6; }
            set { SetValue(ref _Numero6, value); }
        }
        public double Numero7
        {
            get { return _Numero7; }
            set { SetValue(ref _Numero7, value); }
        }
        public double Numero8
        {
            get { return _Numero8; }
            set { SetValue(ref _Numero8, value); }
        }
        public double Numero9
        {
            get { return _Numero9; }
            set { SetValue(ref _Numero9, value); }
        }
        public double Numero0
        {
            get { return _Numero0; }
            set { SetValue(ref _Numero0, value); }
        }
       
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void Sumar()
        {
            if (Resultado2!=0) 
            {
                auxiliar1 = double.Parse(MostrarPantalla);
                Resultado2 += auxiliar1;
                Resultado = Resultado2;
                MostrarPantalla = "";


            }
            else
            {
                auxiliar1 = double.Parse(MostrarPantalla);
                operacion = "+";
                MostrarPantalla = "";
            }
               
            
        }
        public void Restar()
        {
            auxiliar1 = double.Parse(MostrarPantalla);
            operacion = "-";
            MostrarPantalla = "";
        }
        public void Multiplicar()
        {
            auxiliar1 = double.Parse(MostrarPantalla);
            operacion = "*";
            MostrarPantalla = "";
        }
        public void Dividir()
        {
            auxiliar1 = double.Parse(MostrarPantalla);
            operacion = "/";
            MostrarPantalla = "";
        }
        public void Operacion()
        {
            // auxiliar2 = double.Parse(MostrarPantalla);

            switch (operacion)
            {
                case "+":
                    auxiliar2 = double.Parse(MostrarPantalla);
                    Resultado2 = auxiliar1 + auxiliar2;
                    Resultado = Resultado2;   
                    break;
                case "-":
                    auxiliar2 = double.Parse(MostrarPantalla);
                    Resultado = auxiliar1 - auxiliar2;
                    break;
                case "*":
                    auxiliar2 = double.Parse(MostrarPantalla);
                    Resultado = auxiliar1 * auxiliar2;
                    break;
                case "/":
                    if (auxiliar1 != 0)
                    {
                        auxiliar2 = double.Parse(MostrarPantalla);
                        Resultado = auxiliar1 / auxiliar2;
                    }
                    else
                    {
                        DisplayAlert("Estas Mal", "No se puede diviidir entre zero", "qwq");
                        //resultado.Text = "Error qwq";
                    }
                    break;
            }

            MostrarPantalla = Resultado.ToString();
            


        }
        public void InsertarNumero1()
        {
            MostrarPantalla += "1";
        }
        public void InsertarNumero2()
        {
            MostrarPantalla += "2";
        }
        public void InsertarNumero3()
        {
            MostrarPantalla += "3";
        }
        public void InsertarNumero4()
        {
            MostrarPantalla += "4";
        }
        public void InsertarNumero5()
        {
            MostrarPantalla += "5";
        }
        public void InsertarNumero6()
        {
            MostrarPantalla += "6";
        }
        public void InsertarNumero7()
        {
            MostrarPantalla += "7";
        }
        public void InsertarNumero8()
        {
            MostrarPantalla += "8";
        }
        public void InsertarNumero9()
        {
            MostrarPantalla += "9";
        }
        public void InsertarNumero0()
        {
            MostrarPantalla += "0";
        }
       
        public void LimpiarPantalla()
        {
            MostrarPantalla = string.Empty;
            auxiliar1 = 0;
            Resultado2 = 0;
            auxiliar2 = 0;
            Resultado= 0;
        }
        public void procesoSimple() 
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoSimpcomandLimpiar => new Command(LimpiarPantalla);

        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcomand => new Command(procesoSimple);
        public ICommand MostrarNumero1 => new Command(InsertarNumero1);
        public ICommand MostrarNumero2 => new Command(InsertarNumero2);

        public ICommand MostrarNumero3 => new Command(InsertarNumero3);
        public ICommand MostrarNumero4 => new Command(InsertarNumero4);
        public ICommand MostrarNumero5 => new Command(InsertarNumero5);
        public ICommand MostrarNumero6 => new Command(InsertarNumero6);
        public ICommand MostrarNumero7 => new Command(InsertarNumero7);
        public ICommand MostrarNumero8 => new Command(InsertarNumero8);
        public ICommand MostrarNumero9 => new Command(InsertarNumero9);
        public ICommand MostrarNumero0 => new Command(InsertarNumero0);
       // public ICommand OperacionCommand => new Command(Operacion);
        public ICommand OperacionSumar => new Command(Sumar);
        public ICommand OperacionRestar => new Command(Restar);
        public ICommand OperacionMultiplicar => new Command(Multiplicar);
        public ICommand OperacionDividir => new Command(Dividir);

        public ICommand OperacionResultado => new Command(Operacion);







        #endregion
    }
}
