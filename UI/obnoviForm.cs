
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
    public partial class obnoviForm : Form
    {
        public obnoviForm()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            kampusGym f = new kampusGym();
            f.Show();
            this.Hide();
        }
        private void DgvObnovi_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
            int rowIndex = e.RowIndex;
            obnoviForm2 f = new obnoviForm2(dgvObnovi.Rows[rowIndex].Cells[1].Value.ToString(), dgvObnovi.Rows[rowIndex].Cells[2].Value.ToString(), dgvObnovi.Rows[rowIndex].Cells[3].Value.ToString(), dgvObnovi.Rows[rowIndex].Cells[4].Value.ToString(), dgvObnovi.Rows[rowIndex].Cells[5].Value.ToString(), dgvObnovi.Rows[rowIndex].Cells[6].Value.ToString(), dgvObnovi.Rows[rowIndex].Cells[7].Value.ToString(), dgvObnovi.Rows[rowIndex].Cells[8].Value.ToString(), dgvObnovi.Rows[rowIndex].Cells[9].Value.ToString(), dgvObnovi.Rows[rowIndex].Cells[10].Value.ToString());
            f.Show();
            this.Hide();
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            //obnoviForm2 f = new obnoviForm2(rowIndex);
            //f.Show();
            //this.Hide();
        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            //Searching
            string keywords = textBox2.Text;
            
        
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblMembers WHERE gym_id LIKE '%" + keywords + "%' OR ime LIKE '%" + keywords + "%' OR prezime LIKE '%" + keywords + "%'",conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgvObnovi.DataSource = dt;

            dgvObnovi.Columns[0].Visible = false;
            dgvObnovi.Columns[1].HeaderCell.Value = "GYM ID";
            dgvObnovi.Columns[2].HeaderCell.Value = "Ime";
            dgvObnovi.Columns[3].HeaderCell.Value = "Prezime";
            dgvObnovi.Columns[4].HeaderCell.Value = "Spol";
            dgvObnovi.Columns[5].HeaderCell.Value = "Datum rođenja";
            dgvObnovi.Columns[6].Visible = false;
            dgvObnovi.Columns[7].Visible = false;
            dgvObnovi.Columns[8].Visible = false;
            dgvObnovi.Columns[9].Visible = false;
            dgvObnovi.Columns[10].Visible = false;

            dgvObnovi.EnableHeadersVisualStyles = false;
            //  dgvObnovi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 184, 255);



            dgvObnovi.AllowUserToAddRows = false;
            dgvObnovi.AllowUserToDeleteRows = false;
            dgvObnovi.AllowUserToResizeColumns = false;
            dgvObnovi.AllowUserToResizeRows = false;



            dgvObnovi.DataSource = dt;



            dgvObnovi.BorderStyle = BorderStyle.None;
            dgvObnovi.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ccf2ff");
            //dgvInvertar.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(117, 143, 132); 
            dgvObnovi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvObnovi.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#b3d9ff");
            //dgvInvertar.DefaultCellStyle.SelectionBackColor = Color.MediumPurple; 251, 229, 109 - ZUTA
            dgvObnovi.DefaultCellStyle.SelectionForeColor = Color.FromArgb(34, 36, 49);
            dgvObnovi.BackgroundColor = Color.Navy; //pozadina dgv-a



            dgvObnovi.EnableHeadersVisualStyles = false;
            dgvObnovi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvObnovi.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvObnovi.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#e6f0ff");
            // za panel i buttone na izborniku
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
