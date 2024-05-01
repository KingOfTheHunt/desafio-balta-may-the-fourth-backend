using Microsoft.EntityFrameworkCore;
using StarWars.Core.Context.StarWars.Entities;
using StarWars.Core.Context.StarWars.UseCases.GetPlanets;
using StarWars.Core.Context.StarWars.UseCases.GetPlanets.Contracts;
using StarWars.Infra.Data;

namespace StarWars.Infra.Context.StarWars.UseCases.GetPlanets;

public class Repository : IRepository
{
    private readonly AppDbContext _context;

    public Repository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<ResponseData>> GetPlanetsAsync(CancellationToken cancellationToken)
    {
        return await _context.Planets
            .AsNoTracking()
            .Include(x => x.Films)
            .Include(x => x.Characters)
            .Select<Planet, ResponseData>(x => new ResponseData 
            {
                Name = x.Name,
                RotationPeriod = x.RotationPeriod,
                OrbitalPeriod = x.OrbitalPeriod,
                Diameter = x.Diameter,
                Climate = x.Climate,
                Gravity = x.Gravity,
                Terrain = x.Terrain,
                SurfaceWater = x.SurfaceWater,
                Population = x.Population,
                Characters = x.Characters.Select(x => new { id = x.Id, name = x.Name }),
                Movies = x.Films.Select(x => new { id = x.Id, title = x.Title })
            }).ToListAsync();
    }
}