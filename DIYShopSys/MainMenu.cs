namespace DIYShopSys
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddAndUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAndUpdate AddAndUpdate = new AddAndUpdate(this);
            AddAndUpdate.Text = "Add Supplier";
            AddAndUpdate.Show();
        }
        private void updateSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateSupplier updateSupplier = new updateSupplier(this, "Update Supplier Details");
            updateSupplier.Show();
        }
    }
}