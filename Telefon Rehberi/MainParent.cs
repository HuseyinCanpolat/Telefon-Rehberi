using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi
{
    public partial class MainParent : Form
    {
        public MainParent()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
          
        }

        private void Menu_New_Person_Click(object sender, EventArgs e)
        {
            New_Person new_Person = new New_Person();
            new_Person.MdiParent = this;
            new_Person.Show();
        }
    }
}
