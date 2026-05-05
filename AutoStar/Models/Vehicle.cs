namespace AutoStar.Models;

public class Vehicle
{
    public int VehicleID { get; set; }
    public int UserID { get; set; }
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public int CurrentMileage { get; set; }
    public string? Nickname { get; set; }

    public User? User { get; set; }
    public List<MaintenanceRecord> MaintenanceRecords { get; set; } = new();
    public List<FuelRecord> FuelRecords { get; set; } = new();

    public string DisplayName => Nickname ?? $"{Year} {Make} {Model}";
}
