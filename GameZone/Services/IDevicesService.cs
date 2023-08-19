namespace GameZone.Services;

public interface IDevicesService
{
    IEnumerable<SelectListItem> GetSelectList();
}
