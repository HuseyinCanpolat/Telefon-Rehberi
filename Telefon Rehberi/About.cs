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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        private void Menu_New_Person_Click(object sender, EventArgs e)
        {
           
            New_Person ykisi = new New_Person();
            ykisi.ShowDialog();
            
        }

        private void Menu_Person_List_Click(object sender, EventArgs e)
        {
             
             
            Person_List kisi = new Person_List();
            kisi.ShowDialog();
             
            
        }

        private void Menu_Edit_Person_Click(object sender, EventArgs e)
        {
             
             
            Edit_Person edit = new Edit_Person();
            edit.ShowDialog();
             
            
        }

        private void Menu_Vcard_Click(object sender, EventArgs e)
        {
             
             
            Qr_Code qr = new Qr_Code();
            qr.ShowDialog();
             
            
        }

        private void menu_Settings_Click(object sender, EventArgs e)
        {
             
             
            Settings st = new Settings();
            st.ShowDialog();
             
            
        }

        private void Menu_About_Me_Click(object sender, EventArgs e)
        {

            About abo = new About();
            abo.ShowDialog();
             
             
        }
    }
}

