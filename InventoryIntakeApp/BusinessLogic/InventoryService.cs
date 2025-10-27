using InventoryIntakeApp.Models;
using InventoryIntakeApp.DataAccess;

namespace InventoryIntakeApp.BusinessLogic;

public class InventoryService
{
    private readonly InventoryRepository _repository = new InventoryRepository();

    public bool RecordNewIntake(InventoryLog log)
    {
        // the checks
        if (string.IsNullOrWhiteSpace(log.ProductName) || string.IsNullOrWhiteSpace(log.Sku))
        {
            return false;
        }

        if (log.QuantityReceived <= 0)
        {
            return false;
        }

        _repository.Add(log);
        return true;
    }
}