namespace AutoStar.Models;

public class FuelRecord
{
    public int FuelID { get; set; }
    public int VehicleID { get; set; }
    public DateTime Date { get; set; }
    public decimal Gallons { get; set; }
    public decimal Cost { get; set; }
    public int Mileage { get; set; }

    public Vehicle? Vehicle { get; set; }

    public decimal PricePerGallon => Gallons > 0 ? Cost / Gallons : 0;
}
