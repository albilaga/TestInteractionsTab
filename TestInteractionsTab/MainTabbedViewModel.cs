namespace TestInteractionsTab
{
    public class MainTabbedViewModel
    {
        public MainTabbedViewModel()
        {
            MainViewModel = new MainViewModel();
            SecondaryViewModel = new SecondaryViewModel();
        }

        public MainViewModel MainViewModel { get; }
        public SecondaryViewModel SecondaryViewModel { get; }
    }
}
