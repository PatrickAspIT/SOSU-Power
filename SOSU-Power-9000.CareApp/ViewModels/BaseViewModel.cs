using CommunityToolkit.Mvvm.ComponentModel;

namespace SOSU_Power_9000.CareApp.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        #region Fields
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool isBusy;

        [ObservableProperty]
        private string title;
        #endregion

        #region Constructor

        public BaseViewModel()
        {
        }
        #endregion

        #region Properties
        public bool IsNotBusy => !IsBusy;
        #endregion
    }
}