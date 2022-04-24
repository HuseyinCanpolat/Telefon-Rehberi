using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Telefon_Rehberi
{
    public partial class Yeni_Kişi : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider = Microsoft.JET.OLEDB.4.0; Data Source = TelefonRehberi.mdb");

        public Yeni_Kişi()
        {
            InitializeComponent();
        }



        private void Menu_New_Person_Click(object sender, EventArgs e)
        {

            Yeni_Kişi ykisi = new Yeni_Kişi();
            ykisi.Show();

            this.Location = new Point(ykisi.Location.X - 8, ykisi.Location.Y - 80);

        }

        private void Menu_Person_List_Click(object sender, EventArgs e)
        {

            this.Opacity = 0;
            Kişi_Listesi kisi = new Kişi_Listesi();
            kisi.Show();
            this.Location = new Point(kisi.Location.X - 8, kisi.Location.Y - 80);

        }

        private void Menu_Edit_Person_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Edit_Person edit = new Edit_Person();
            edit.Show();

            this.Location = new Point(edit.Location.X - 8, edit.Location.Y - 80);
        }

        private void Menu_Vcard_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Qr_Code qr = new Qr_Code();
            qr.Show();

            this.Location = new Point(qr.Location.X - 8, qr.Location.Y - 80);
        }

        private void menu_Settings_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Settings st = new Settings();
            st.Show();

            this.Location = new Point(st.Location.X - 8, st.Location.Y - 80);
        }

        private void Menu_About_Me_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            About abo = new About();
            abo.Show();

            this.Location = new Point(abo.Location.X - 8, abo.Location.Y - 80);
        }

        private void btn_NewPerson_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                cmd.CommandText = "insert into Kişiler (Ad,Soyad,DogumGunu,DogumYeri,Meslek,Telefon1,Telefon2,EvTelefon,IsTelefon,EvAdres,IsAdres,Email,WebSite) values('" + txtName.Text + "','" + txtSurname.Text + "','" + txtBirthDay.Text + "','" + txtBirthPlace.Text + "','" + txtJob.Text + "','" + txtMobile1.Text + "','" + txtMobile2.Text + "','" + txtHousePhone.Text + "','" + txtJobPhone.Text + "','" + txtJobAddress.Text + "','" + txtAdress.Text + "','" + txtMail.Text + "','" + txtWebSite.Text + "' )";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kişi Kaydedildi");
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);
            }
        }

        private void btn_Add_PictureChange_Click(object sender, EventArgs e)
        {

        }
    }
}

