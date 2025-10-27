namespace InventoryIntakeApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // In Form1.Designer.cs

        private void InitializeComponent()
        {
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.skuLabel = new System.Windows.Forms.Label();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(30, 35);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(120, 15);
            this.productNameLabel.Text = "Product Name:";

            this.productNameTextBox.Location = new System.Drawing.Point(160, 32);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(250, 23);

            this.skuLabel.AutoSize = true;
            this.skuLabel.Location = new System.Drawing.Point(30, 75);
            this.skuLabel.Name = "skuLabel";
            this.skuLabel.Size = new System.Drawing.Size(32, 15);
            this.skuLabel.Text = "SKU:";

            this.skuTextBox.Location = new System.Drawing.Point(160, 72);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(250, 23);

            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(30, 115);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(56, 15);
            this.quantityLabel.Text = "Quantity:";

            this.quantityTextBox.Location = new System.Drawing.Point(160, 112);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(120, 23);

            this.saveButton.Location = new System.Drawing.Point(160, 160);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 30);
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);

            this.ClientSize = new System.Drawing.Size(450, 220);
            this.Text = "Inventory Intake";
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.skuTextBox);
            this.Controls.Add(this.skuLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productNameLabel);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        
         private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label skuLabel;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}