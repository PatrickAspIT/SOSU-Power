using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

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
