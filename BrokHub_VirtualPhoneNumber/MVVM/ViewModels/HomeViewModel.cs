using BrokHub_VirtualPhoneNumber.BaseControls.BaseListBox;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using VirtualPhoneNumber.ApiRoom;
using VirtualPhoneNumber.Brok;
using VirtualPhoneNumber.Eunms;
using VirtualPhoneNumber.Models;

namespace BrokHub_VirtualPhoneNumber.MVVM.ViewModels
{
    public partial class HomeViewModel : Base.Notify
    {
        private BrokNumber? _subService;

        public BrokNumber? SubService
        {
            get { return _subService; }
            set
            {
                _subService = value;
                base.NoifyEvent(nameof(SubService));
            }
        }

        private List<Country> _country;

        public List<Country> Country
        {
            get { return _country; }
            set
            {
                _country = value;
                base.NoifyEvent(nameof(Country));
            }
        }

        private List<Number> _numbers;

        public List<Number> Numbers
        {
            get { return _numbers; }
            set
            {
                _numbers = value;
                base.NoifyEvent(nameof(Number));
            }
        }

        private List<Item> _items;

        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                base.NoifyEvent(nameof(Items));
            }
        }


        private Item _selectedItem;

        public Item SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                NoifyEvent(nameof(SelectedItem));


            }
        }

        private bool _isRead = false;

        public bool IsRead
        {
            get { return _isRead; }
            set
            {
                _isRead = value;
                base.NoifyEvent(nameof(IsRead));
            }
        }


        public HomeViewModel()
        {
            SubService = new BrokNumber()
            {
                Request = new Request()
            };
            Country = new();
            Numbers = new();

        }



        private bool CanFillCountry_Loaded(object obj)
        {
            return true;
        }

        private async void FillCountry_Loaded(object obj)
        {
            Country = (await _subService.GetCountry()).Where(e => e.Name == "Russia" || e.Name == "China" || e.Name == "UnitedStates" || e.Name == "France"
            || e.Name == "Ethiopia" || e.Name == "Indonesia" || e.Name == "Paraguay" || e.Name == "Ireland" || e.Name == "Belgium" || e.Name == "Myanmar").ToList();

        }




        private bool CanReadNumber_Loaded(object obj)
        {
            return true;
        }

        private async void ReadNumber_Loaded(object obj)
        {
            IsRead = false;
            Numbers.Clear();
            ccListBoxItem? cc = obj as ccListBoxItem;
            _subService.Request = new Request()
            {
                method = Method.getinfos,
                number = new Number()
                {
                    Service = cc.Uid,
                }
            };

            Numbers = (await _subService.GetNumbers()).Take(100).ToList();
            IsRead = Numbers is not null;
            Items = Numbers.Join(Country, n => n.Country, c => c.ID, (n, c) => new Item
            {
                Path = cc.Path,
                Country = new Country()
                {
                    Image = c.Image,
                    Name = c.Name
                },
                Number = new Number()
                {
                    Amount = n.Amount,
                    Operator = n.Operator,
                    Service = n.Service,
                    Description = "Telegram : @BrokDotNet\n" + "Operator : " + n.Operator,
                    Active = n.Active,
                    Time = n.Time,
                }
            }).ToList();
            base.NoifyEvent(nameof(Items));
        }
    }
}

