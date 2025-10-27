namespace InventoryIntakeApp.Models;

public class InventoryLog
{
    public int LogId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string Sku { get; set; } = string.Empty;
    public int QuantityReceived { get; set; }
    public string SupplierName { get; set; } = string.Empty;
    public string WarehouseLocation { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
}