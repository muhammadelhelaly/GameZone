namespace GameZone.Services;

public interface IGamesService
{
    IEnumerable<Game> GetAll();
    Task Create(CreateGameFormViewModel model);
}