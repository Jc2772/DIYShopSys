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
    public partial class analysis : Form
    {
        MainMenu mainMenu;
        public analysis()
        {
            InitializeComponent();
        }
        public analysis(MainMenu main,String text)
        {
            this.Text = text;
            this.mainMenu = main;
            InitializeComponent();
        }
    }
}
