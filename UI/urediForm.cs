using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kampusGym.UI
{
    public partial class urediForm : Form
    {
        public urediForm()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            kampusGym f = new kampusGym();
            f.Show();
            this.Hide();
        }
        private void DgvUredi_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            urediForm2 f = new urediForm2(dgvUredi.Rows[rowIndex].Cells[1].Value.ToString(), dgvUredi.Rows[rowIndex].Cells[2].Value.ToString(), dgvUredi.Rows[rowIndex].Cells[3].Value.ToString(), dgvUredi.Rows[rowIndex].Cells[4].Value.ToString(), dgvUredi.Rows[rowIndex].Cells[5].Value.ToString(), dgvUredi.Rows[rowIndex].Cells[6].Value.ToString(), dgvUredi.Rows[rowIndex].Cells[7].Value.ToString(), dgvUredi.Rows[rowIndex].Cells[8].Value.ToString(), dgvUredi.Rows[rowIndex].Cells[9].Value.ToString(), dgvUredi.Rows[rowIndex].Cells[10].Value.ToString());
            f.Show();
            this.Hide();
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            //urediForm2 f = new urediForm2();
            //f.Show();
            //this.Hide();
        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            //Searching
            string keywords = textBox2.Text;


            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblMembers WHERE gym_id LIKE '%" + keywords + "%' OR ime LIKE '%" + keywords + "%' OR prezime LIKE '%" + keywords + "%'", conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);


      
            dgvUredi.DataSource = dt;
            dgvUredi.Columns[0].Visible = false;
            dgvUredi.Columns[1].HeaderCell.Value = "GYM ID";
            dgvUredi.Columns[2].HeaderCell.Value = "Ime";
            dgvUredi.Columns[3].HeaderCell.Value = "Prezime";
            dgvUredi.Columns[4].HeaderCell.Value = "Spol";
            dgvUredi.Columns[5].HeaderCell.Value = "Datum rođenja";
            dgvUredi.Columns[6].Visible = false;
            dgvUredi.Columns[7].Visible = false;
            dgvUredi.Columns[8].Visible = false;
            dgvUredi.Columns[9].Visible = false;
            dgvUredi.Columns[10].Visible = false;



            dgvUredi.EnableHeadersVisualStyles = false;
            dgvUredi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20,184,255);
            dgvUredi.AllowUserToAddRows = false;

            dgvUredi.AllowUserToDeleteRows = false;
            dgvUredi.DataSource = dt;
        }

        private void vratiNazadBotun2_MouseEnter(object sender, EventArgs e)
        {
            vratiNazadBotun2.Size = new Size(85, 85);
        }

        private void vratiNazadBotun2_MouseLeave(object sender, EventArgs e)
        {
            vratiNazadBotun2.Size = new Size(75, 75);
        }
    }
}
