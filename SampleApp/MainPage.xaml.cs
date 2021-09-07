using System;
using System.Globalization;
using Xamarin.Forms;

namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void txtShopId_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            var txtVal = (Entry)sender;
            if (!string.IsNullOrWhiteSpace(txtVal.Text))
            {
                var val = txtVal.Text;
                double inputValue;
                if(!(val.IndexOf(".")>0))
                {
                    if (double.TryParse(val, out inputValue))
                    {
                        double result = Math.Round(inputValue / 100, 2);
                        txtVal.TextChanged -= txtShopId_TextChanged;
                        txtVal.Text = result.ToString();
                        txtVal.TextChanged += txtShopId_TextChanged;
                    }
                }
                else
                {
                    var decindx = val.Split('.')[1];
                    if (decindx.Length > 2)
                    {
                        if(double.TryParse(val,System.Globalization.NumberStyles.AllowDecimalPoint,CultureInfo.InvariantCulture, out inputValue))
                        {
                            var res = inputValue * 10;
                            txtVal.Text = res.ToString();
                        }

                    }
                    txtVal.TextChanged -= txtShopId_TextChanged;
                    
                    //txtVal.Text = $"{num}.{val.Split('.')[1]}";
                    txtVal.TextChanged += txtShopId_TextChanged;
                }
                
            }
        }
    }
}
