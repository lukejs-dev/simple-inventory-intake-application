using Oracle.ManagedDataAccess.Client;
using InventoryIntakeApp.Models;

namespace InventoryIntakeApp.DataAccess;

public class InventoryRepository
{
    private readonly string _connectionString = "YOUR_ORACLE_CONNECTION_STRING";

    public void Add(InventoryLog log)
    {
        using (OracleConnection con = new OracleConnection(_connectionString))
        {
            string sql = "INSERT INTO Inventory_log (product_name, sku, quantity_received, supplier_name, warehouse_location, timestamp) VALUES (:ProductName, :Sku, :Quantity, :Supplier, :Location, :Timestamp)";
            using (OracleCommand cmd = new OracleCommand(sql, con))
            {
                cmd.Parameters.Add(new OracleParameter("ProductName", log.ProductName));
                cmd.Parameters.Add(new OracleParameter("Sku", log.Sku));
                cmd.Parameters.Add(new OracleParameter("Quantity", log.QuantityReceived));
                // todo: add other parameters

                con.Open();
                cmd.ExecuteNonQuery(); // might need to add async here and implement batching if post is sequential
            }
        }
    }
}