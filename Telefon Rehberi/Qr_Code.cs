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
using System.Text;
using QRCoder;

namespace Telefon_Rehberi
{
    public partial class Qr_Code : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider = Microsoft.JET.OLEDB.4.0; Data Source = PhoneBook.mdb");
        public Qr_Code()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string qr = "select * from persons";
            OleDbCommand cmd = new OleDbCommand(qr, connect);
            connect.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connect.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                StringBuilder bardcode = new StringBuilder();
                bardcode.AppendLine("begin:vcard");
                //bardcode.AppendLine("name",txtqrname.Text);

                bardcode.AppendLine("end:vcard");
                string name = dt.Rows[i]["name"].ToString();
                string surname = dt.Rows[i]["surname"].ToString();
                string birthday = dt.Rows[i]["birthday"].ToString();
                string birthplace = dt.Rows[i]["birthplace"].ToString();
                string job = dt.Rows[i]["job"].ToString();
                string phone1 = dt.Rows[i]["phone1"].ToString();
                string phone2 = dt.Rows[i]["phone2"].ToString();
                string housephone = dt.Rows[i]["housephone"].ToString();
                string jobphone = dt.Rows[i]["jobphone"].ToString();
                string homeadress = dt.Rows[i]["homeadress"].ToString();
                string email = dt.Rows[i]["email"].ToString();
                string website = dt.Rows[i]["website"].ToString();
                StringBuilder bcode1 = new StringBuilder("name:" + name + Environment.NewLine + "surname:" + surname + Environment.NewLine + "birthday:" + birthday + Environment.NewLine + "birthplace:" + birthplace + Environment.NewLine + "job:" + job + Environment.NewLine + "phone1:" + phone1 + Environment.NewLine + "phone2:" + phone2 + Environment.NewLine + "housephone:" + housephone + Environment.NewLine + "jobphone:" + jobphone + Environment.NewLine + "homeadress:" + homeadress + Environment.NewLine + "email:" + email + Environment.NewLine + "website:" + website);
                
                  


            }



        }

        private void Qr_Code_Load(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            {
                txtqrname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtqrsurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtqrbirthday.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtqrbirthplace.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtqrjob.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtqrphone2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtqrphone1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtqrhousephone.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtqrjobphone.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txtqrhomeadress.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txtqrjobadress.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                txtqremail.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                txtqrwebsite.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();

            }
        }
    }
}
   


