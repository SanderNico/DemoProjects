using demoProj.Model;

namespace demoProj.Service;

public interface IPlayersService
{
    IEnumerable<Player> GetPlayers(string team);
}

public class PlayersService : IPlayersService
{

    private IEnumerable<Player> Players = new[]
    {
        new Player
        {
            FirstName = "Martin",
            LastName = "Ødegaard",
            Team = "Arsenal",
            Nationality = "Norwegian"
        },
        new Player
        {
            FirstName = "Erling",
            LastName = "Haaland",
            Team = "Manchester City",
            Nationality = "Norwegian"
        },
        new Player
        {
            FirstName = "Gabriel",
            LastName = "Martinelli",
            Team = "Arsenal",
            Nationality = "Brazilian"
        },
        new Player
        {
            FirstName = "Kevin",
            LastName = "De Bruyne",
            Team = "Manchester City",
            Nationality = "Belgian"
        },
        new Player
        {
            FirstName = "Granit",
            LastName = "Xaka",
            Team = "Arsenal",
            Nationality = "Swiss"
        },
        new Player
        {
            FirstName = "John",
            LastName = "Stones",
            Team = "Manchester City",
            Nationality = "English"
        },
    };
    public IEnumerable<Player> GetPlayers(string team)
    {
        return Players.Where(p => p.Team.Equals(team)).ToList();
    }
}