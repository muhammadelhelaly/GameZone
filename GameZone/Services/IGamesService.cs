namespace GameZone.Services;

public interface IGamesService
{
    Task Create(CreateGameFormViewModel model);
}