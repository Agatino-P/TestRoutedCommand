using GalaSoft.MvvmLight;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace TestRoutedCommand
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<CommandingUCViewModel> _vms= new ObservableCollection<CommandingUCViewModel>();
        public ObservableCollection<CommandingUCViewModel> VMs { get => _vms; set { Set(() => VMs, ref _vms, value); }}

        public MainWindowViewModel()
        {
            VMs.Add(new CommandingUCViewModel("title1"));
            VMs.Add(new CommandingUCViewModel("title2"));
        }
    }

}
