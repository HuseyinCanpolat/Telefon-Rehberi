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
    public partial class New_Person : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider = Microsoft.JET.OLEDB.4.0; Data Source = TelefonRehberi.mdb");

        public New_Person()
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

        private void btn_NewPerson_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                cmd.CommandText = "insert into persons (id,name,surname,birthday,birthplace,job,phone1,phone2,housephone,jobphone,homeadress,jobadress,email,website) values('" + txtName.Text + "','" + txtSurname.Text + "','" + txtBirthDay.Text + "','" + txtBirthPlace.Text + "','" + txtJob.Text + "','" + txtMobile1.Text + "','" + txtMobile2.Text + "','" + txtHousePhone.Text + "','" + txtJobPhone.Text + "','" + txtJobAddress.Text + "','" + txtAdress.Text + "','" + txtMail.Text + "','" + txtWebSite.Text + "' )";
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

