using System.ComponentModel;
using System.Reactive;
using System.Reactive.Disposables;
using ReactiveUI;
using ReactiveUI.XamForms;

namespace TestInteractionsTab
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ReactiveContentPage<MainViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
            this.WhenActivated(disposable =>
            {
                ViewModel
                .StartFinished
                .RegisterHandler(arg =>
                {
                    DisplayAlert("Alert", "Start Finished", "OK");
                    arg.SetOutput(Unit.Default);
                }).DisposeWith(disposable);
                this.BindCommand(ViewModel, vm => vm.Start, v => v._startButton);
            });
        }
    }
}
