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
{
    public partial class sales : Form
    {
        MainMenu mainMenu;
        public sales()
        {
            InitializeComponent();
        }
        public sales(MainMenu main)
        {
            InitializeComponent();
            this.mainMenu = main;
            DataSet dataset = new Sql().PullData(this.Text);
            Items.DataSource = dataset.Tables[0];
        }
    }
}
