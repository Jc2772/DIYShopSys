namespace DIYShopSys
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        //Add Supplier
        private void AddAndUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Text = "Add Supplier";
            AddAndUpdate AddAndUpdate = new AddAndUpdate(this, Text);
            AddAndUpdate.Show();
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

        }
        //Add Item
        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Text = "Add Item";
            AddAndUpdate AddAndUpdate = new AddAndUpdate(this, Text);
            AddAndUpdate.Show();
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

        }
        //Query Item
        private void queryItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Restock Item
        private void restockItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

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