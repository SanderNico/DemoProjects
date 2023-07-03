using FootballPlayerSimpleDemo.Model;

namespace FootballPlayerSimpleDemo.ViewModel;

public class PlayerViewModel : IPlayerViewModel
{
    private Player _player;
    public PlayerViewModel(Player player)
    {
        _player = player;
    }

    public string Name => _player.FirstName + " " + _player.LastName;
    public string Team => _player.Team;
    public string Nationality => _player.Nationality;
}