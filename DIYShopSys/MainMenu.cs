namespace DIYShopSys
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSupplier addSupplier = new addSupplier(this);
            addSupplier.Show();
        }
        private void updateSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateSupplier updateSupplier = new updateSupplier(this);
            updateSupplier.Show();
        }
    }
}