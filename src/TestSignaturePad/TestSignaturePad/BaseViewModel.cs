using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestSignaturePad
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        private readonly INavigation _navigation;
        public BaseViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async Task Goto(ContentPage page)
        {
            await _navigation.PushAsync(page);
        }

        public virtual async Task GoBack()
        {
            await _navigation.PopAsync();
        }
    }
}
