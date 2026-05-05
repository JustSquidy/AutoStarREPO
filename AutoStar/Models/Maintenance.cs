namespace AutoStar.Models;

public class MaintenanceType
{
    public int CategoryID { get; set; }
    public string TypeName { get; set; } = string.Empty;
    public int RecommendedMiles { get; set; }

    public List<MaintenanceRecord> MaintenanceRecords { get; set; } = new();
}

public class MaintenanceRecord
{
    public int RecordID { get; set; }
    public int VehicleID { get; set; }
    public int CategoryID { get; set; }
    public DateTime ServiceDate { get; set; }
    public int MileageAtService { get; set; }
    public decimal Cost { get; set; }
    public string? Notes { get; set; }
    public string DifficultyLevel { get; set; } = "Easy"; // Easy, Medium, Hard
    public int? NextServiceMileage { get; set; }

    public Vehicle? Vehicle { get; set; }
    public MaintenanceType? MaintenanceType { get; set; }
}
