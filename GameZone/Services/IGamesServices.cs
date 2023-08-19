namespace GameZone.Services;

public interface IGamesServices
{
    Task Create(CreateGameFormViewModel model);
}