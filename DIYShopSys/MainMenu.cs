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
        private void ManageDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageData ManageData = new ManageData(this, "Update Supplier Details");
            ManageData.Show();
        }
    }
}