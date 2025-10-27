using InventoryIntakeApp.Models;
using InventoryIntakeApp.BusinessLogic;

namespace InventoryIntakeApp;

public partial class Form1 : Form
{
    private readonly InventoryService _inventoryService = new();

    public Form1()
    {
        InitializeComponent();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(quantityTextBox.Text, out int quantity))
        {
            MessageBox.Show("Error: Quantity must be valid number.");
            return;
        }

        var log = new InventoryLog
        {
            ProductName = productNameTextBox.Text,
            Sku = skuTextBox.Text,
            QuantityReceived = quantity
        };

        bool success = _inventoryService.RecordNewIntake(log);

        if (success)
        {
            MessageBox.Show("Inventory recorded successfully!");
            productNameTextBox.Clear();
            skuTextBox.Clear();
            quantityTextBox.Clear();
        }
        else
        {
            MessageBox.Show("Error: Please check your input values. Product name, sku, and a positive quantity are required.");
        }
    }
}