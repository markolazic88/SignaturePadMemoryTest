using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TestSignaturePad
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand GotoSignature { get; }
        private int _visits;

        public MainPageViewModel(INavigation navigation) : base(navigation)
        {
            Visits = 0;
            GotoSignature = new Command(async () =>
            {
                await Goto(new SignaturePage());
                Visits++;
            });
        }
        public int Visits
        {
            get => _visits;
            set
            {
                if (_visits == value) return;
                _visits = value;
                NotifyPropertyChanged();
            }
        }

        public override async Task GoBack()
        {
            await base.GoBack();
            GC.Collect();
        }
    }
}
