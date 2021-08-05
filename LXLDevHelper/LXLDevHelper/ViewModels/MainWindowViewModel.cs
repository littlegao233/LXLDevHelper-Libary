﻿using Prism.Mvvm;

namespace LXLDevHelper.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "ModernWpf Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
