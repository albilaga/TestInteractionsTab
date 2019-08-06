using System;
using System.Collections.Generic;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms;

namespace TestInteractionsTab
{
    public partial class MainTabbedPage : ReactiveTabbedPage<MainTabbedViewModel>
    {
        public MainTabbedPage()
        {
            InitializeComponent();
            ViewModel = new MainTabbedViewModel();
            this.WhenActivated(disposable =>
            {
                _mainPage.ViewModel = ViewModel.MainViewModel;
                _secondaryPage.ViewModel = ViewModel.SecondaryViewModel;
            });
        }
    }
}
