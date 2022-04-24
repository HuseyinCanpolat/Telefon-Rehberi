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
    public partial class Qr_Code : Form
    {
        public Qr_Code()
        {
            InitializeComponent();
        }
        private void Menu_New_Person_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            New_Person ykisi = new New_Person();
            ykisi.Visible = true;
            this.Location = new Point(ykisi.Location.X - 8, ykisi.Location.Y - 80);
        }

        private void Menu_Person_List_Click(object sender, EventArgs e)
        {

            this.Opacity = 100;
            Person_List kisi = new Person_List();
            kisi.Show();
            this.Location = new Point(kisi.Location.X - 8, kisi.Location.Y - 80);
        }

        private void Menu_Edit_Person_Click(object sender, EventArgs e)
        {

            this.Opacity = 100;
            Edit_Person edit = new Edit_Person();
            edit.Show();
            this.Location = new Point(edit.Location.X - 8, edit.Location.Y - 80);
        }

        private void Menu_Vcard_Click(object sender, EventArgs e)
        {

            Qr_Code qr = new Qr_Code();
            qr.Show();
            this.Location = new Point(qr.Location.X - 8, qr.Location.Y - 80);
        }

        private void menu_Settings_Click(object sender, EventArgs e)
        {

            this.Opacity = 100;
            Settings st = new Settings();
            st.Show();
            this.Location = new Point(st.Location.X - 8, st.Location.Y - 80);
        }

        private void Menu_About_Me_Click(object sender, EventArgs e)
        {

            this.Opacity = 100;
             
         
        }
    }
}


