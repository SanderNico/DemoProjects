using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using demoProj.Service;

namespace demoProj.ViewModel;

public interface IPlayersPageViewModel : INotifyPropertyChanged
{
    void Initialize();
}

public class PlayersPageViewModel : IPlayersPageViewModel
{
    private IPlayersService m_playersService;
    private ObservableCollection<IPlayerViewModel> m_players;

    public PlayersPageViewModel()
    {
        m_playersService = new PlayersService();
    }

    public void Initialize()
    {

        var viewModels = m_playersService.GetPlayers("Arsenal").Select(player => new PlayerViewModel(player));
        Players = new ObservableCollection<IPlayerViewModel>(viewModels);
    }

    public ObservableCollection<IPlayerViewModel> Players
    {
        get => m_players;
        set => RaiseWhenSet(ref m_players, value);
    } 

    public event PropertyChangedEventHandler PropertyChanged;
    
    public bool RaiseWhenSet<TS>(ref TS backingStore, TS value, [CallerMemberName] string propertyName = "")
    {
        if (EqualityComparer<TS>.Default.Equals(backingStore, value))
        {
            return false;
        }

        backingStore = value;
        RaisePropertyChanged(propertyName);
        return true;
    }
    
    public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}