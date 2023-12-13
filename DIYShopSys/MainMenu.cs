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
        //Manage Supplier Status
        private void removeSupplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Text = "Manage Supplier Status";
            ChangeStatus manage = new ChangeStatus(this, Text);
            manage.Show();
        }
        //Add Type
        private void addTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Text = "Add Type";
            AddAndUpdateTypes AddAndUpdateTypes = new AddAndUpdateTypes(this, Text);
            AddAndUpdateTypes.Show();
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
            AddAndUpdateItems AddAndUpdateItems = new AddAndUpdateItems(this, Text);
            AddAndUpdateItems.Show();
        }
        //Update Item Details
        private void updateItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageData ManageData = new ManageData(this, "Update Item Details");
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
