using System;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Net.NetworkInformation;

using Windows.UI.Xaml;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class MainViewModel : BindableBase
    {
       private RecentesViewModel _recentesModel;
       private DestaquesViewModel _destaquesModel;
       private MapasViewModel _mapasModel;
       private FavoritosViewModel _favoritosModel;
        private PrivacyViewModel _privacyModel;

        private ViewModelBase _selectedItem = null;

        public MainViewModel()
        {
            _selectedItem = RecentesModel;
            _privacyModel = new PrivacyViewModel();

        }
 
        public RecentesViewModel RecentesModel
        {
            get { return _recentesModel ?? (_recentesModel = new RecentesViewModel()); }
        }
 
        public DestaquesViewModel DestaquesModel
        {
            get { return _destaquesModel ?? (_destaquesModel = new DestaquesViewModel()); }
        }
 
        public MapasViewModel MapasModel
        {
            get { return _mapasModel ?? (_mapasModel = new MapasViewModel()); }
        }
 
        public FavoritosViewModel FavoritosModel
        {
            get { return _favoritosModel ?? (_favoritosModel = new FavoritosViewModel()); }
        }

        public void SetViewType(ViewTypes viewType)
        {
            RecentesModel.ViewType = viewType;
            DestaquesModel.ViewType = viewType;
            MapasModel.ViewType = viewType;
            FavoritosModel.ViewType = viewType;
        }

        public ViewModelBase SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                SetProperty(ref _selectedItem, value);
                UpdateAppBar();
            }
        }

        public Visibility AppBarVisibility
        {
            get
            {
                return SelectedItem == null ? AboutVisibility : SelectedItem.AppBarVisibility;
            }
        }

        public Visibility AboutVisibility
        {

         get { return Visibility.Visible; }
        }

        public void UpdateAppBar()
        {
            OnPropertyChanged("AppBarVisibility");
            OnPropertyChanged("AboutVisibility");
        }

        /// <summary>
        /// Load ViewModel items asynchronous
        /// </summary>
        public async Task LoadDataAsync(bool forceRefresh = false)
        {
            var loadTasks = new Task[]
            { 
                RecentesModel.LoadItemsAsync(forceRefresh),
                DestaquesModel.LoadItemsAsync(forceRefresh),
                MapasModel.LoadItemsAsync(forceRefresh),
                FavoritosModel.LoadItemsAsync(forceRefresh),
            };
            await Task.WhenAll(loadTasks);
        }

        //
        //  ViewModel command implementation
        //
        public ICommand RefreshCommand
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    await LoadDataAsync(true);
                });
            }
        }

        public ICommand AboutCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    NavigationServices.NavigateToPage("AboutThisAppPage");
                });
            }
        }

        public ICommand PrivacyCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    NavigationServices.NavigateTo(_privacyModel.Url);
                });
            }
        }
    }
}
