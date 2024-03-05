namespace DIYShopSys
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        //this.title comes from https://stackoverflow.com/questions/5104175/how-do-you-change-the-text-in-the-titlebar-in-windows-forms
        //Add Supplier
        private void ManageItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Text = "Add Supplier";
            ManageSuppliers ManageSuppliers = new ManageSuppliers(this, Text);
            ManageSuppliers.Show();
        }
        //Update Supplier Details
        private void ManageDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageData ManageData = new ManageData(this, "Update Supplier Details");
            ManageData.Show();
        }
        //Manage Supplier Status
        private void removeSupplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Text = "Manage Supplier Status";
            ChangeStatus ManageData = new ChangeStatus(this, Text);
            ManageData.Show();
        }
        // Query Supplier Details
        private void querySupplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Text = "Query Supplier Details";
            ManageData ManageData = new ManageData(this, Text);
            ManageData.Show();

        }
        //Add Type
        private void addTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Text = "Add Type";
            ManageTypes ManageTypes = new ManageTypes(this, Text);
            ManageTypes.Show();
        }
        //Update Type
        private void updateTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Text = "Update Type Detail";
            ManageData manage = new ManageData(this, Text);
            manage.Show();
        }
        //Manage Tool Status
        private void manageTypeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Text = "Manage Type Status";
            ChangeStatus manage = new ChangeStatus(this, Text);
            manage.Show();
        }
        //Add Item
        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Text = "Add Item";
            ManageItems ManageItems = new ManageItems(this, Text);
            ManageItems.Show();
        }
        //Update Item Details
        private void updateItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Text = "Update Item Details";
            ManageData ManageData = new ManageData(this, Text);
            ManageData.Show();
        }
        //Manage Item Status
        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Text = "Manage Item Status";
            ChangeStatus manage = new ChangeStatus(this, Text);
            manage.Show();
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
            YearlyRevenueAnalysis analysis = new YearlyRevenueAnalysis(this);
            analysis.Show();
        }
        //Yearly Item Analysis
        private void yearlyItemAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YearlyItemAnalysis analysis = new YearlyItemAnalysis(this);
            analysis.Show();
        }
    }
}
