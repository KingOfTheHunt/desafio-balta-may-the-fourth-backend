using StarWars.Core.Context.Shared.Entities;

namespace StarWars.Core.Context.StarWars.Entities;

public class Planet : Entity
{
    public string Name { get; set; } = string.Empty;
    public string RotationPeriod { get; set; } = string.Empty;
    public string OrbitalPeriod { get; set; } = string.Empty;
    public string Diameter { get; set; } = string.Empty;
    public string Climate { get; set; } = string.Empty;
    public string Gravity { get; set; } = string.Empty;
    public string Terrain { get; set; } = string.Empty;
    public string SurfaceWater { get; set; } = string.Empty;
    public string Population { get; set; } = string.Empty;
    public List<Character> Characters { get; set; } = new();
    public List<Film> Films { get; set; } = new();
}