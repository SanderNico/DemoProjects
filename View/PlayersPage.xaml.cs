using demoProj.ViewModel;

namespace demoProj;

public partial class PlayersPage : ContentPage
{
	int count = 0;

	public PlayersPage()
	{
		InitializeComponent();
		if (BindingContext is PlayersPageViewModel viewModel)
		{
			viewModel.Initialize();
		}
	}
}

