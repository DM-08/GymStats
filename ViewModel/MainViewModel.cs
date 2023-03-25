
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace GymStats.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;
    }
}
