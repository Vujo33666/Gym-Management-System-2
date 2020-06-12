using kampusGym.Klase;
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
    public partial class invertarForm : Form
    {
        public invertarForm()
        {
            InitializeComponent();
        }

        BP_Invertar i = new BP_Invertar();
        invertarKlasa k = new invertarKlasa();


        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void DodajBotun_Click(object sender, EventArgs e)
        {
            k.sprava = textBox1.Text;
            k.kolicina = decimal.ToInt32(numericUpDown1.Value);

            //za vadenje podataka iz baze -> LINQ
            DataClasses3DataContext db3 = new DataClasses3DataContext();

            var varijabla = from s in db3.tblInvertars select s.sprava;
            string[] name = varijabla.ToArray();

            var varijabla2 = from s in db3.tblInvertars select s.kolicina;
            int[] broj = varijabla2.ToArray();

            string korisnikov_unos = textBox1.Text;
            int korisnikova_kolicina = Convert.ToInt32(numericUpDown1.Value);

            bool temp = false;

            if (korisnikova_kolicina > 0)
            {
                for (int j = 0; j < name.Count(); j++)
                {
                    if (korisnikov_unos == name[j])
                    {
                        var result = MessageBox.Show("Jeste li sigurni da želite obrisati opremu?", "Obavijest", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            k.kolicina = broj[j] + korisnikova_kolicina;
                            bool success1 = i.Update(k);
                            if (success1)
                            {
                                MessageBox.Show("Uređena oprema.", "Obavijest");
                                temp = false;
                                loadFormAgain();
                                break;
                            }
                        }
                        else
                        {
                            loadFormAgain();
                        }
                    }
                    else
                    {
                        temp = true;
                    }
                }

                if (temp)
                {
                    var result = MessageBox.Show("Jeste li sigurni da želite dodati novu opremu?", "Obavijest", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        bool success = i.Insert(k);

                        if (success)
                        {

                            MessageBox.Show("Uspješno dodana nova oprema.", "Obavijest");
                            loadFormAgain();
                        }
                        else
                            MessageBox.Show("Nešto je poslo po krivu", "Upozorenje");
                    }
                    else
                        loadFormAgain();
                }
            }
            else
            {
                MessageBox.Show("Količina ne može biti jednaka 0","Obavijest");
                loadFormAgain();
            }
        }

        private void BrisiBotun_Click(object sender, EventArgs e)
        {
            k.sprava = textBox1.Text;
            k.kolicina = Convert.ToInt32(numericUpDown1.Value);

            //za vadenje podataka iz baze -> LINQ
            DataClasses3DataContext db3 = new DataClasses3DataContext();

            var varijabla = from s in db3.tblInvertars select s.sprava;
            string[] name = varijabla.ToArray();

            var varijabla2 = from s in db3.tblInvertars select s.kolicina;
            int[] broj = varijabla2.ToArray();

            string korisnikov_unos = textBox1.Text;
            int korisnikova_kolicina = Convert.ToInt32(numericUpDown1.Value);

            bool temp = true;
 
            for (int j = 0; j < name.Count(); j++)
            {
                if (korisnikov_unos == name[j])
                {
                    if (korisnikova_kolicina > broj[j])
                    {
                        MessageBox.Show("Unijeli ste količinski iznos veći nego što je u bazi!", "Upozorenje");
                        temp = false;
                        break;
                    }
                    else if (korisnikova_kolicina == broj[j])
                    {
                        var result = MessageBox.Show("Jeste li sigurni da želite obrisati opremu?", "Obavijest", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            bool success = i.Delete(k);
                            if (success)
                            {
                                MessageBox.Show("Uređena oprema.", "Obavijest");
                                temp = false;
                                loadFormAgain();

                            }
                            else MessageBox.Show("Pogreška pri uređivanju opreme.", "Upozorenje");
                        }
                        else
                        {
                            temp = false;
                            break;
                        }

                    }
                    else
                    {
                        var result = MessageBox.Show("Jeste li sigurni da želite obrisati opremu?", "Obavijest", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            k.kolicina = broj[j] - korisnikova_kolicina;
                            bool success2 = i.Update(k);
                            if (success2)
                            {
                                MessageBox.Show("Uređena oprema.", "Obavijest");
                                temp = false;
                                loadFormAgain();
                                break;
                            }
                        }
                        else
                        {
                            temp = false;
                            break;
                        }
                    }
                }
            }

            if (temp)
            {
                var result = MessageBox.Show("Jeste li sigurni da želite obrisati opremu?", "Obavijest", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool success = i.Delete(k);
                    if (success)
                    {
                        MessageBox.Show("Oprema uspjesno izbrisana.", "Obavijest");
                        loadFormAgain();
                    }
                    else MessageBox.Show("Pogreska pri brisanju opreme.", "Upozorenje");
                }
            }
        }

        private void PromijeniBotun_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Neko od obaveznih polja je ostalo prazno. Pokušajte ponovno.", "Obavijest");
            }
            else
            {
                bool flag = Convert.ToBoolean(numericUpDown1.Value);

                if (flag == false)
                {
                    MessageBox.Show("Nije unešen broj.", "Obavijest");

                }
                else
                {
                    k.sprava = textBox1.Text;
                    k.kolicina = decimal.ToInt32(numericUpDown1.Value);

                    var result = MessageBox.Show("Jeste li sigurni da želite promijeniti opremu?", "Obavijest", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        bool success = i.Update(k);
                        if (success)
                        {
                            MessageBox.Show("Uređena oprema.", "Obavijest");
                            //invertarForm nova = new invertarForm();
                            loadFormAgain();

                        }
                        else MessageBox.Show("Pogreška pri uređivanju opreme.", "Upozorenje");
                    }
                    else
                        loadFormAgain();
                }
            }
        }

        private void invertarForm_Load(object sender, EventArgs e)
        {
            loadFormAgain();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kampusGym kg = new kampusGym();
            kg.Show();
            this.Hide();
        }

        private void dgvInvertar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox1.Text = dgvInvertar.Rows[rowIndex].Cells[1].Value.ToString();
            string pomocna = dgvInvertar.Rows[rowIndex].Cells[2].Value.ToString();
            numericUpDown1.Value = decimal.Parse(pomocna);

        }

        public void loadFormAgain() //metoda samo za ponovno ucitavanje
        {
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblInvertar", conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgvInvertar.DataSource = dt;

            dgvInvertar.Columns[0].Visible = false;
            dgvInvertar.Columns[1].HeaderCell.Value = "Oprema";
            dgvInvertar.Columns[2].HeaderCell.Value = "Kolicina";



            dgvInvertar.EnableHeadersVisualStyles = false;
            dgvInvertar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 184, 255);
            dgvInvertar.AllowUserToAddRows = false;

            dgvInvertar.AllowUserToDeleteRows = false;
            dgvInvertar.DataSource = dt;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(85, 85);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(75, 75);
        }
    }
}
