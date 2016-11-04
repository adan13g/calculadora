using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace calculadora
{
    public partial class Page1 : ContentPage
    {
      String operacion;
        double valor1, valor2,resultado;
        bool punto = false;

        public Page1()
        {
            InitializeComponent();
        }
        public void numero0(object sender, EventArgs e)
        {
            if (resultado.ToString() == label1.Text)
            {
                label1.Text = "";
                label12.Text = "";
            }
            label1.Text = label1.Text + "0";
        }
        public void numero1(object sender, EventArgs e)
        {
            if (resultado.ToString() == label1.Text)
            {
                label1.Text = "";
                label12.Text = "";
            }
            label1.Text = label1.Text + "1";
        }
         public void numero2(object sender, EventArgs e)
        {
            if (resultado.ToString() == label1.Text)
            {
                label1.Text = "";
                label12.Text = "";
            }
            label1.Text = label1.Text + "2";

        }
        public void numero3(object sender, EventArgs e)
        {
            if (resultado.ToString() == label1.Text)
            {
                label1.Text = "";
                label12.Text = "";
            }
            label1.Text = label1.Text + "3";

        }
        public void numero4(object sender, EventArgs e)
        {
            if (resultado.ToString() == label1.Text)
            {
                label1.Text = "";
                label12.Text = "";
            }
            label1.Text = label1.Text + "4";

        }
        public void numero5(object sender, EventArgs e)
        {
            if (resultado.ToString() == label1.Text)
            {
                label1.Text = "";
                label12.Text = "";
            }
            label1.Text = label1.Text + "5";

        }
        public void numero6(object sender, EventArgs e)
        {
            if (resultado.ToString() == label1.Text)
            {
                label1.Text = "";
                label12.Text = "";
            }
            label1.Text = label1.Text + "6";

        }
        public void numero7(object sender, EventArgs e)
        {
            if (resultado.ToString() == label1.Text)
            {
                label1.Text = "";
                label12.Text = "";
            }
            label1.Text = label1.Text + "7";

        }
        public void numero8(object sender, EventArgs e)
        {
            if (resultado.ToString() == label1.Text)
            {
                label1.Text = "";
                label12.Text = "";
            }
            label1.Text = label1.Text + "8";

        }
        public void numero9(object sender, EventArgs e)
        {
            if (resultado.ToString() ==label1.Text)
            {
                label1.Text = "";
                label12.Text = "";
            }
            label1.Text = label1.Text + "9";

            

        }
       
        public void suma(object sender, EventArgs e)
        {
            label12.Text += label1.Text + "+";
            operacion = "+";
            valor1 = double.Parse(label1.Text);
            label1.Text = "";
            punto = false;
      

        }
        public void resta(object sender, EventArgs e)
        {
            label12.Text += label1.Text + "-";
            operacion = "-";
            valor1 = double.Parse(label1.Text);
            label1.Text = "";
            punto = false;

        }
        public void multiplicacion(object sender, EventArgs e)
        {
            label12.Text += label1.Text + "x";

            operacion = "x";
            valor1 = double.Parse(label1.Text);
            label1.Text = "";
            punto = false;

        }
        public void division(object sender, EventArgs e)
        {
            label12.Text += label1.Text + "/";

            operacion = "/";
            valor1 = double.Parse(label1.Text);
            label1.Text = "";
            punto = false;

        }

        public void igual(object sender, EventArgs e)
        {
            label12.Text += label1.Text + "x";

            valor2 = double.Parse(label1.Text);
            switch (operacion) {
                case "+":
                  
                   
                        label12.Text = "";
                        resultado = valor1 + valor2;
                        label1.Text = resultado.ToString();
                       
                    
                    break;
                case "-":
                    label12.Text = "";
                    resultado = valor1 - valor2;
                    label1.Text = resultado.ToString();

                    break;
                case "x":
                    label12.Text = "";
                    resultado = valor1 * valor2;
                    label1.Text = resultado.ToString();

                    break;
                case "/":
                    label12.Text = "";
                    resultado = valor1 / valor2;
                    label1.Text = resultado.ToString();

                    break;
            
            }
            {

            }

        }

        public void punto1(object sender, EventArgs e)
        {

            if (punto == false)
            {
                
                    label1.Text = label1.Text + ".";
                    punto = true;



            }


        }
        public void limpiar(object sender, EventArgs e)
        {
            label1.Text = "";
            label12.Text = "";
            punto = false;
        }
        public void raiz(object sender, EventArgs e)
        {
            valor1 = double.Parse(label1.Text);
            resultado = valor1;
            label1.Text = Math.Sqrt(valor1).ToString();

        }

    }
}
