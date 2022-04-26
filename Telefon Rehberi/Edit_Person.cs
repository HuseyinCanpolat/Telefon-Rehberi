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
    public partial class Edit_Person : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider = Microsoft.JET.OLEDB.4.0; Data Source = PhoneBook.mdb");

        public Edit_Person()
        {
            InitializeComponent();
        }
        

        private void btneditdel_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                string query = "delete from Phone where name='" + txteditname.Text + "'";
                cmd.CommandText = query;
                MessageBox.Show(query);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Veri Silindi");
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            connect.Open();
            OleDbCommand cmd = new OleDbCommand();
            string query = @"update persons set name ='" + txteditname.Text + "' , surname ='" + txteditsur.Text + "' , birthday ='" + txteditbirthday.Text + "' , birthplace ='" + txteditbirthplace.Text + "', job ='" + txteditjob.Text + "',phone1 ='" + txteditphone1.Text + "',phone2 ='" + txteditphone2.Text + "' , housephone='" + txtedithomephone.Text + "',jobphone ='" + txteditjobphone.Text + "',homeadress ='" + txtedithomeadress.Text + "',jobadress ='" + txteditjobadress.Text + "',email ='" + txteditemail.Text + "',website ='" + txteditwebsite.Text + "' where id ='" + comboBox1.SelectedItem + "' ";
            cmd.CommandText = query;
            OleDbCommand com = new OleDbCommand(query,connect);
            com.ExecuteNonQuery();
            connect.Close();


        }

        private void btnupdate_Click(object sender, EventArgs e)
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
                editdatagrid.DataSource = dt;
                MessageBox.Show("Veri Güncellendi");
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void Edit_Person_Load(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;
                string query = "select * from persons";
                command.CommandText = query;
                OleDbDataReader oleDbDataReader = command.ExecuteReader();

                while (oleDbDataReader.Read())
                {
                    comboBox1.Items.Add(oleDbDataReader["id"].ToString());
                }
                connect.Close();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}

