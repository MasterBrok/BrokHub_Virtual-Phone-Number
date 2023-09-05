using System;
using System.Windows.Input;

namespace BrokHub_VirtualPhoneNumber.MVVM.ViewModels
{
    public partial class HomeViewModel
    {
        private ICommand _readNumber;

        public ICommand GetNumbers
        {
            get
            {
                base.FillCommand(ref _readNumber, ReadNumber_Loaded, CanReadNumber_Loaded);
                return _readNumber;
            }
        }

        private ICommand _fillCountry;

        public ICommand FillCountry
        {
            get
            {
                base.FillCommand(ref _fillCountry, FillCountry_Loaded, CanFillCountry_Loaded);
                return _fillCountry;
            }
        }

   
    }
}
