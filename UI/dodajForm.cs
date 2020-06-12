using kampusGym.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kampusGym.UI
{
    public partial class dodajForm : Form
    {
        public dodajForm()
        {
            InitializeComponent();
        }

        //Create objects of a class
        dodajKlasa c = new dodajKlasa();
        BP u = new BP();

        string imageName = "no-image.jpg";

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            kampusGym f = new kampusGym();
            f.Show();
            this.Hide();
        }

        private void DodajBotun_Click(object sender, EventArgs e)
        {
            bool check = false;

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

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Neko od obaveznih polja je ostalo prazno. Pokušajte ponovno.");
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
                        check = provjera(dateTimePicker2, dateTimePicker3); // funkcija
                        if (!check)
                        {
                            MessageBox.Show("Neispravan datum trajanja članstva, članarina može trajati najmanje mjesec dana!", "Obavijest");
                        }
                        else
                        {
                            c.vrsta_treninga = comboBox2.Text;
                            c.slika = pictureBox4.ToString();

                            bool success = u.Insert(c);

                            if (success)
                            {
                                MessageBox.Show("Dodan novi član.", "Obavijest");
                                kampusGym f = new kampusGym();
                                f.Show();
                                this.Hide();
                            }
                            else
                                MessageBox.Show("Pogreška pri uređivanju članstva.", "Obavijest");
                        }
                    }
                }
                else
                {
                    dodajForm f1 = new dodajForm();
                    f1.Show();
                    this.Hide();
                }


                //}
                /* if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                 {
                     MessageBox.Show("Neko od obaveznih polja je ostalo prazno. Pokusajte ponovno.");
                 }

                 else
                 {

                     /*
                     bool flag = false;
                     int rez = 0;
                     flag = int.TryParse(textBox1.Text, out rez);
                     if (flag == false)
                     {
                         MessageBox.Show("Nije unesen broj.");

                     }
                     else
                     {

                     //Step 1: Get values from UI
                     c.gym_id = int.Parse(textBox1.Text);
                         c.ime = textBox2.Text;
                         c.prezime = textBox3.Text;
                         c.spol = comboBox1.Text;
                         c.datum_rodenja = dateTimePicker1.Value.ToShortDateString();
                         c.email = textBox6.Text;
                         c.datum_placanja = dateTimePicker2.Value.ToShortDateString();
                         c.datum_vrijedi_do = dateTimePicker3.Value.ToShortDateString();
                         c.vrsta_treninga = comboBox2.Text;
                         c.slika = pictureBox4.ToString();

                         //Step 2: Adding values from UI to the DB
                         bool success = u.Insert(c);

                         if (success)
                         {
                             MessageBox.Show("Uspjesno dodan novi clan");
                             kampusGym f = new kampusGym();
                             f.Show();
                             this.Hide();
                         }
                         else
                             MessageBox.Show("Nesto je poslo po krivu");
                     } 

                }*/
            }
        }

            public bool provjera(DateTimePicker a, DateTimePicker b)
            {
                if (a.Value.Year == b.Value.Year)
                {
                    if (a.Value.Month <= b.Value.Month)
                    {
                        if (a.Value.Month == b.Value.Month)
                        {
                            return false;
                        }
                        else
                        {
                            if (a.Value.Day > b.Value.Day)
                                return false;
                            else
                                return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (a.Value.Year < b.Value.Year)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            private void PictureBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files Only (*.jpg; *.jpeg; *.png; *.gif| *.jpg; *.jpeg; *.png; *.gif)";

            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    pictureBox4.Image = new Bitmap(open.FileName);

                    string ext = Path.GetExtension(open.FileName);
                    string name = Path.GetFileNameWithoutExtension(open.FileName);


                    //Generate Random but globally unique identifier
                    Guid g = new Guid();
                    g = Guid.NewGuid();
                    imageName = name + g + ext;
                    string sourcePath = open.FileName;

                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    string destinationPath = paths + "\\images" + imageName;

                    File.Copy(sourcePath, destinationPath);

                    MessageBox.Show("Slika uspjesno uploadana."); 
                }
            }
        }

        private void vratiNazadBotun1_MouseEnter(object sender, EventArgs e)
        {
            vratiNazadBotun1.Size = new Size(85, 85);
        }

        private void vratiNazadBotun1_MouseLeave(object sender, EventArgs e)
        {
            vratiNazadBotun1.Size = new Size(75, 75);
        }

        private void dodajBotun_MouseEnter(object sender, EventArgs e)
        {
            dodajBotun.Size = new Size(85, 85);
        }

        private void dodajBotun_MouseLeave(object sender, EventArgs e)
        {
            dodajBotun.Size = new Size(75, 75);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(85, 85);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(75, 75);
        }
    }
}
