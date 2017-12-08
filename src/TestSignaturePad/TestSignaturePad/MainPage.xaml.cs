using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestSignaturePad
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel _vm;

        public MainPage()
        {
            InitializeComponent();
            _vm = new MainPageViewModel(Navigation);
            BindingContext = _vm;
        }
    }
}
