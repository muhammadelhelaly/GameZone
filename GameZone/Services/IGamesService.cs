namespace GameZone.Services;

public interface IGamesService
{
    IEnumerable<Game> GetAll();
    Game? GetById(int id);
    Task Create(CreateGameFormViewModel model);
}