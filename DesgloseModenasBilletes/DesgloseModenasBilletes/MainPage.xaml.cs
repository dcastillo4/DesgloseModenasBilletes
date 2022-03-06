using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DesgloseModenasBilletes
{
    public partial class MainPage : ContentPage
    {
        int C100, C50, C20, C10, C5, C1 = 0; //Declaracion para billetes
        int M50, M25, M10, M5, M1;
        decimal CAN;
        float numDecimal;

        public MainPage()
        {
            InitializeComponent();
        }


    private void desglosar_Clicked(object sender, EventArgs e)
        {
            CAN = decimal.Parse(cantidad.Text);
            string CANString = CAN.ToString();



            if ((CAN >= 100))
            {
                C100 = (int)(CAN / 100);
                CAN = CAN - (C100 * 100);
            }
            if ((CAN >= 50))
            {
                C50 = ((int)(CAN / 50));
                CAN = CAN - (C50 * 50);
            }

            if ((CAN >= 20))
            {
                C20 = ((int)(CAN / 20));
                CAN = CAN - (C20 * 20);
            }

            if ((CAN >= 10))
            {
                C10 = ((int)(CAN / 10));
                CAN = CAN - (C10 * 10);

            }
            if ((CAN >= 5))
            {
                C5 = ((int)(CAN / 5));
                CAN = CAN - (C5 * 5);

            }
            if ((CAN >= 1))
            {
                C1 = ((int)(CAN / 1));
                CAN = CAN - (C1 * 1);

            }
            numDecimal = float.Parse("0," + CANString.Split('.')[1]); //Obteniendo los numeros decimales

            //logica para desglosar las monedas
            if ((numDecimal >= 50))
            {
                M50 = ((int)(numDecimal / 50));
                numDecimal = numDecimal - (M50 * 50);
            }

            if ((numDecimal >= 25))
            {
                M25 = ((int)(numDecimal / 25));
                numDecimal = numDecimal - (M25 * 25);
            }

            if ((numDecimal >= 10))
            {
                M10 = ((int)(numDecimal / 10));
                numDecimal = numDecimal - (M10 * 10);

            }
            if ((numDecimal >= 5))
            {
                M5 = ((int)(numDecimal / 5));
                numDecimal = numDecimal - (M5 * 5);

            }
            if ((numDecimal >= 1))
            {
                M1 = ((int)(numDecimal / 1));
                numDecimal = numDecimal - (M1 * 1);

            }

            collectionview.ItemsSource = new string[]
            {
                "############ Billetes #############",
                "Billetes Q.100: "+C100 ,
                "Billetes Q.50: "+C50 ,
                "Billetes Q.20: "+C20 ,
                "Billetes Q.10: "+C10 ,
                "Billetes Q.5: "+C5 ,
                "Billetes Q.1: "+C1 ,
                "############ Monedas #############",
                "Monedas de .50: "+M50,
                "Monedas de .25: "+M25,
                "Monedas de .10: "+M10,
                "Monedas de .5: "+M5,
                "Monedas de .1: "+M1,

            };

            DisplayAlert("Mensaje!", "Desglose exitoso!", "OK");



        }
    }
}
