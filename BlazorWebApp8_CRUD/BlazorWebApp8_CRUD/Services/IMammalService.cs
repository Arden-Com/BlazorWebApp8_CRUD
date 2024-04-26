namespace BlazorWebApp8_CRUD.Services
{
    using BlazorWebApp8_CRUD.Entity;
    public interface IMammalService
    {
        Task<List<Mammal>> GetAllMammals();
    }
}
