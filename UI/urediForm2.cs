using kampusGym.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kampusGym.UI
{
    public partial class urediForm2 : Form
    {
        public urediForm2(string gymid, string name, string surname, string sex, string dateOfBirth, string email, string paymentDate, string expDate, string tot, string img)
        {
            InitializeComponent();
            textBox1.Text = gymid;
            textBox2.Text = name;
            textBox3.Text = surname;
            comboBox1.Text = sex;
            dateTimePicker1.Value = DateTime.Parse(dateOfBirth);
            textBox6.Text = email;
            dateTimePicker2.Value = DateTime.Parse(paymentDate);
            dateTimePicker3.Value = DateTime.Parse(expDate);
            comboBox2.Text = tot;
            //pictureBox1.Image = Image.FromFile(img);
            //MessageBox.Show(img);
        }
        dodajKlasa c = new dodajKlasa();
        BP u = new BP();
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            kampusGym f = new kampusGym();
            f.Show();
            this.Hide();
        }

        private void UrediBotun_Click(object sender, EventArgs e)
        {
            bool check = false;
            check = provjera(dateTimePicker2, dateTimePicker3);

            DataClasses2DataContext db2 = new DataClasses2DataContext();
            var varijabla3 = from s in db2.tblMembers select s.gym_id;
            int[] broj = varijabla3.ToArray();

            bool temp = false;
            bool temp3 = true;
            int rez = 0;
            temp = int.TryParse(textBox1.Text, out rez);

            for (int i = 0; i < broj.Length; i++) // Provjera da li postoji isti broj tj id_korisnika u bazi 
            {
                if (rez == broj[i])
                {
                    temp3 = false;
                }
            }

            if (!check)
            {
                MessageBox.Show("Neispravan datum obnove clanstva");
            }

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Neko od obaveznih polja je ostalo prazno. Pokusajte ponovno.");
            }
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Prvo unesite podatke.", "Obavijest");
            }
            else if (temp == false)
            {
                MessageBox.Show("Niste unijeli ispravan identifikacijski broj člana.", "Obavijest");
            }
            else if (temp3 == false)
            {
                MessageBox.Show("Unijeli ste identifikacijski broj člana koji se već koristi.", "Obavijest");
            }
            else
            {
                if (temp3 && temp)
                {
                    var result = MessageBox.Show("Jeste li sigurni da želite urediti informacije?", "Obavijest", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        c.gym_id = int.Parse(textBox1.Text);
                        c.ime = textBox2.Text;
                        c.prezime = textBox3.Text;
                        c.spol = comboBox1.Text;
                        c.datum_rodenja = dateTimePicker1.Value.ToShortDateString();
                        c.email = textBox6.Text;
                        c.datum_placanja = dateTimePicker2.Value.ToShortDateString();
                        c.datum_vrijedi_do = dateTimePicker3.Value.ToShortDateString();
                        c.vrsta_treninga = comboBox2.Text;
                        c.slika = pictureBox1.ToString();

                        bool success = u.Insert(c);

                        if (success)
                        {
                            MessageBox.Show("Uređeno članstvo.","Obavijest");
                        }
                        else
                            MessageBox.Show("Pogreška pri uređivanju članstva.","Obavijest");

                        urediForm f1 = new urediForm();
                        f1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    urediForm f1 = new urediForm();
                    f1.Show();
                    this.Hide();
                }
            }

        }

    /*  public void  loadFormAgain()
        {
            urediForm2 f = new urediForm2(string gymid, string name, string surname, string sex, string dateOfBirth, string email, string paymentDate, string expDate, string tot, string img);
            f.Show();
            this.Hide();
        } */

        public bool provjera(DateTimePicker a, DateTimePicker b)
        {
            if (a.Value.Year == b.Value.Year)
            {
                if (a.Value.Month <= b.Value.Month)
                {
                    if (a.Value.Month == b.Value.Month)
                        return a.Value.Day <= b.Value.Day;
                    else
                        return true;
                }
                else return false;
            }
            else if (a.Value.Year < b.Value.Year)
                return true;
            else
                return false;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            c.gym_id = int.Parse(textBox1.Text);
            
            bool success = u.Delete(c);
            if (success)
                MessageBox.Show("Član uspjesno izbrisan.");
            else MessageBox.Show("Pogreška pri brisanju člana.");

            kampusGym f = new kampusGym();
            f.Show();
            this.Hide();
        }

        private void vratiNaPocetak1_MouseEnter(object sender, EventArgs e)
        {
            vratiNaPocetak1.Size = new Size(85, 85);
        }

        private void vratiNaPocetak1_MouseLeave(object sender, EventArgs e)
        {
            vratiNaPocetak1.Size = new Size(75, 75);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(85, 85);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(75, 75);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(85, 85);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(75, 75);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(85, 85);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(75, 75);
        }

        private void urediBotun_MouseEnter(object sender, EventArgs e)
        {
            urediBotun.Size = new Size(85, 85);
        }

        private void urediBotun_MouseLeave(object sender, EventArgs e)
        {
            urediBotun.Size = new Size(75, 75);
        }
    }
}
