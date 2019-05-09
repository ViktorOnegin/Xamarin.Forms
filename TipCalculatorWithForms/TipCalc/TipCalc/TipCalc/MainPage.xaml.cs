using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TipCalc
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        //Label tip;
        //Label bill;
        //Label tipAmount;
        //Label totalAmount;
        //Button calculate;
        //Slider slider;

        public double SliderValue { get; set; }

        public MainPage()
        {
            InitializeComponent();

            slider.ValueChanged += Slider_ValueChanged;
        }

        public void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            SliderValue = ((Slider)sender).Value;
        }

    }
}
