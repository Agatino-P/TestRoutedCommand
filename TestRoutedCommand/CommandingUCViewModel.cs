using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace TestRoutedCommand
{

    public class CommandingUCViewModel : ViewModelBase
    {
        private string _title="title"; 
        public string Title { get => _title; set { Set(() => Title, ref _title, value); }}

        public CommandingUCViewModel()
        {
            Title = DateTime.Now.ToString();
        }

        public CommandingUCViewModel(string title)
        {
            Title = title;
        }


        public static RoutedCommand CustomRoutedCommand = new RoutedCommand();
    }

}
