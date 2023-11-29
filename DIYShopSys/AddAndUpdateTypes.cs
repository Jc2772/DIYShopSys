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
    public partial class AddAndUpdateTypes : Form
    {
        MainMenu menu;
        ManageData update;
        DataGridViewRow Row;
        public AddAndUpdateTypes()
        {
            InitializeComponent();
        }
        public AddAndUpdateTypes(MainMenu main, String text)
        {
            InitializeComponent();
            this.Text = Text;
            this.menu = main;
        }
        public AddAndUpdateTypes(DataGridViewRow Row, ManageData update, String text)
        {
            InitializeComponent();
            this.Text = text;
            this.update = update;
            this.Row = Row;
        }
    }
}
