using FootballPlayerSimpleDemo.Model;

namespace FootballPlayerSimpleDemo.ViewModel;

public interface IPlayerViewModel
{
    public string Name { get; }
    public string Team { get; }
    public string Nationality { get; }
}