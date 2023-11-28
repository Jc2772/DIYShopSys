namespace DIYShopSys
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        //Add Supplier
        private void AddAndUpdateItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Text = "Add Supplier";
            AddAndUpdateSuppliers AddAndUpdateSuppliers = new AddAndUpdateSuppliers(this, Text);
            AddAndUpdateSuppliers.Show();
        }
        //Update Supplier Details
        private void ManageDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageData ManageData = new ManageData(this, "Update Supplier Details");
            ManageData.Show();
        }
        //Remove Supplier Details
        private void removeSupplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageData ManageData = new ManageData(this, "Remove Supplier");
            ManageData.Show();
        }
        //Add Item
        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Text = "Add Item";
            AddAndUpdateItems AddAndUpdateItems = new AddAndUpdateItems(this, Text);
            AddAndUpdateItems.Show();
        }
        //Update Item Details
        private void updateItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageData ManageData = new ManageData(this, "Update Item Details");
            ManageData.Show();
        }
        //Remove Item Details
        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageData ManageData = new ManageData(this, "Remove Items");
            ManageData.Show();
        }
        //Query Item
        private void queryItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageData ManageData = new ManageData(this, "Query Items");
            ManageData.Show();
        }
        //Restock Item
        private void restockItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestockItems RestockItems = new RestockItems(this);
            RestockItems.Show();
        }
        //Yearly Revenue Analysis
        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //Yearly Item Analysis
        private void yearlyItemAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}