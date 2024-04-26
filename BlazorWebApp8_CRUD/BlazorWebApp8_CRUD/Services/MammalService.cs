namespace BlazorWebApp8_CRUD.Services
{
    using BlazorWebApp8_CRUD.Data;
    using BlazorWebApp8_CRUD.Entity;
    using Microsoft.EntityFrameworkCore;

    public class MammalService : IMammalService
    {
        private readonly ApplicationDbContext _context;

        public MammalService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Mammal>> GetAllMammals()
        {
            var mammals = await _context.Mammals.ToListAsync();
            return mammals;
        }
    }
}
