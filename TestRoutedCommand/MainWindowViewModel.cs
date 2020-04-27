using GalaSoft.MvvmLight;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Command;

namespace TestRoutedCommand
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<CommandingUCViewModel> _vms= new ObservableCollection<CommandingUCViewModel>();
        public ObservableCollection<CommandingUCViewModel> VMs { get => _vms; set { Set(() => VMs, ref _vms, value); }}

        private string _lastPushed=""; 
        public string LastPushed { get => _lastPushed; set { Set(() => LastPushed, ref _lastPushed, value); }}


        private RelayCommand<CommandingUCViewModel> _updateLastPushedCmd;
        public RelayCommand<CommandingUCViewModel> UpdateLastPushedCmd => _updateLastPushedCmd ?? (_updateLastPushedCmd = new RelayCommand<CommandingUCViewModel>(
            (cUC) => { LastPushed = cUC.Title; },
            (cUC) => { return cUC.Title.Contains("title"); } 
            ));
		

        public MainWindowViewModel()
        {
            VMs.Add(new CommandingUCViewModel("title1"));
            VMs.Add(new CommandingUCViewModel("title2"));
        }
    }

}
