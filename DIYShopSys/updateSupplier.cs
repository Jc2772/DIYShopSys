using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIYShopSys
// https://www.aspsnippets.com/Articles/Get-Cell-Value-of-Selected-DataGridView-Row-in-Windows-Application-using-C-and-VBNet.aspx
{
    public partial class updateSupplier : Form
    {
        MainMenu main;
        public updateSupplier()
        {
            InitializeComponent();
        }
        public updateSupplier(MainMenu main)
        {
            InitializeComponent();
            this.main = main;
            main.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            /*https://stackoverflow.com/questions/56009158/how-to-check-if-a-cell-in-selected-row-in-datagridview-is-empty-null-using-c
            came up with grid Selceted rows while looking at site
             */
            if (Grid.SelectedRows.Count == 1)
            {
                DataGridView row = Grid.SelectedRows[0];
                AddAndUpdate AddAndUpdate = new AddAndUpdate(dataSet, this);
                /*used this to learn how to change form name in c#
                 * first answer on page
                 * https://stackoverflow.com/questions/5104175/how-do-you-change-the-text-in-the-titlebar-in-windows-forms
                 */
                AddAndUpdate.Text = "Update Supplier Details";
                AddAndUpdate.Show();
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }

        private void updateSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (main.Visible == false)
            {
                main.Close();
            }
        }
    }
}
