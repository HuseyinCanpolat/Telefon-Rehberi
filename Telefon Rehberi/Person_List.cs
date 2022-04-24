﻿using System;
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
    public partial class Person_List : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider = Microsoft.JET.OLEDB.4.0; Data Source = TelefonRehberi.mdb");

        public Person_List()
        {
            InitializeComponent();
        }

        private void Menu_New_Person_Click(object sender, EventArgs e)
        {

            this.Opacity = 100;
            New_Person ykisi = new New_Person();
            ykisi.Visible = true;
            this.Location = new Point(ykisi.Location.X - 8, ykisi.Location.Y - 80);
        }

        private void Menu_Person_List_Click(object sender, EventArgs e)
        {

            Person_List kisi = new Person_List();
            kisi.Show();
            this.Location = new Point(kisi.Location.X - 8, kisi.Location.Y - 80);
        }

        private void Menu_Edit_Person_Click(object sender, EventArgs e)
        {

            this.Close();
            Edit_Person edit = new Edit_Person();
            edit.Show();

            this.Location = new Point(edit.Location.X - 8, edit.Location.Y - 80);
        }

        private void Menu_Vcard_Click(object sender, EventArgs e)
        {

            this.Opacity = 100;
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

        private void Kişi_Listesi_Load(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                string query = "select * from persons";
                cmd.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);
            }
        }
    }
}