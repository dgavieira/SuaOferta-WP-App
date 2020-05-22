using System;
using System.Windows;
using System.Windows.Input;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class FavoritosViewModel : ViewModelBase<FavoritosSchema>
    {
        private RelayCommandEx<FavoritosSchema> itemClickCommand;
        public RelayCommandEx<FavoritosSchema> ItemClickCommand
        {
            get
            {
                if (itemClickCommand == null)
                {
                    itemClickCommand = new RelayCommandEx<FavoritosSchema>(
                        (item) =>
                        {

                            NavigationServices.NavigateToPage("FavoritosDetail", item);
                        });
                }

                return itemClickCommand;
            }
        }

        override protected DataSourceBase<FavoritosSchema> CreateDataSource()
        {
            return new FavoritosDataSource(); // CollectionDataSource
            }


        override public Visibility RefreshVisibility
        {
            get { return ViewType == ViewTypes.List ? Visibility.Visible : Visibility.Collapsed; }
        }

        public RelayCommandEx<Slider> IncreaseSlider
        {
            get
            {
                return new RelayCommandEx<Slider>(s => s.Value++);
            }
        }

        public RelayCommandEx<Slider> DecreaseSlider
        {
            get
            {
                return new RelayCommandEx<Slider>(s => s.Value--);
            }
        }

        override public void NavigateToSectionList()
        {
            NavigationServices.NavigateToPage("FavoritosList");
        }

        override protected void NavigateToSelectedItem()
        {
            NavigationServices.NavigateToPage("FavoritosDetail");
        }
    }
}
