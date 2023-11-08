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
            String formname = "add item";
            AddAndUpdate AddAndUpdate = new AddAndUpdate(this,formname);
            AddAndUpdate.Show();
        }
        private void updateSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateSupplier updateSupplier = new updateSupplier(this);
            updateSupplier.Show();
        }
    }
}