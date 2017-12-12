using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestSignaturePad
{
    public partial class SignaturePage : ContentPage
    {
        public SignaturePage()
        {
            InitializeComponent();
        }

        private async void Button_OkClicked(object sender, EventArgs e)
        {
            if (PadView.IsBlank)
            {
                return;
            }
            await Navigation.PopAsync();

            //GC.Collect(); // *** Uncomment to prevent memory leak ***
        }

        private async void Button_CancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}