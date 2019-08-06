using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using ReactiveUI;

namespace TestInteractionsTab
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            StartFinished = new Interaction<Unit, Unit>();
            Start = ReactiveCommand.CreateFromTask(async () =>
              {
                  await Task.Delay(TimeSpan.FromSeconds(5));
              });
            Start
                .SelectMany(x => StartFinished.Handle(Unit.Default))
                .Subscribe();
        }

        public ReactiveCommand<Unit, Unit> Start { get; }
        public Interaction<Unit, Unit> StartFinished { get; }
    }
}
