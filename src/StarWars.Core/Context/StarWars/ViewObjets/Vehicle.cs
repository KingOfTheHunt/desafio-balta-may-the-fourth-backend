using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarWars.Core.Context.Shared.ViewObjects;

namespace StarWars.Core.Context.StarWars.ViewObjets;

public class Vehicle : ViewObjects
{
    public int Id { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Manufacturer { get; set; } = string.Empty;
    public string CostInCredits { get; set; } = string.Empty;
    public string Length { get; set; } = string.Empty;
    public string MaxSpeed { get; set; } = string.Empty;
    public string Crew { get; set; } = string.Empty;
    public string Passengers { get; set; } = string.Empty;
    public string CargoCapacity { get; set; } = string.Empty;
    public string Consumables { get; set; } = string.Empty;
    public string Class { get; set; } = string.Empty;
    public IEnumerable<Film>? Movies { get; set; } = null;
    
}