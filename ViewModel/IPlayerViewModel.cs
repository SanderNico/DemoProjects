using demoProj.Model;

namespace demoProj.ViewModel;

public interface IPlayerViewModel
{
    public string Name { get; }
    public string Team { get; }
    public string Nationality { get; }
}