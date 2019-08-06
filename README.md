TestInteractionsTab

This sample is for showing problem in [Interaction] (https://reactiveui.net/docs/handbook/interactions/). The problem happened because Interaction that already registered by handler is disposed when moving tab. This will become a problem in real world applications because callback from API is undetermined, so if we are using `DisposeWith` it will disposed when user changing tab and app will crash. If it is not disposed, then the `Interaction` will continously registered even though user is already not in this page
