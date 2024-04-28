using BlazorWebApp8_CRUD.Entity;

namespace BlazorWebApp8_CRUD.Services
{
    public interface IMammalService
    {
        Task<List<Mammal>> GetAllMammals();
        public Task<Mammal> AddMammal(Mammal mammal);

    }
}
