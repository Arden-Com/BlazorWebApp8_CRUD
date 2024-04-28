namespace BlazorWebApp8_CRUD.Services
{
    using BlazorWebApp8_CRUD.Data;
    using BlazorWebApp8_CRUD.Entity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Query.Internal;

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

        public Task<Mammal> AddMammal(Mammal mammal)
        {
            _context.Mammals.Add(mammal);
            _context.SaveChanges();

            return Task.FromResult(mammal);
        }
    }
}
