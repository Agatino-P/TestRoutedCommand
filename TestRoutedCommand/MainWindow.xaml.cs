using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TestRoutedCommand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _vm = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _vm;
        }

        // CanExecuteRoutedEventHandler that only returns true if
        // the source is a control.
        private void CanExecuteCustomCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            Control target = e.Source as Control;
            CommandingUCViewModel UCvm = e.Parameter as CommandingUCViewModel;
            
            if (target != null && UCvm != null)
            {
                e.CanExecute = _vm.UpdateLastPushedCmd.CanExecute(UCvm);
                    ;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void ExecuteCustomCommand(object sender, ExecutedRoutedEventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            CommandingUCViewModel UCvm = e.Parameter as CommandingUCViewModel;

            MessageBox.Show(UCvm?.Title, "Custom Command Executed!");
                _vm.UpdateLastPushedCmd.Execute(UCvm);
        }

    }
}
