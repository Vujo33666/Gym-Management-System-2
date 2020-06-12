using kampusGym.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kampusGym.UI
{
    public partial class obnoviForm2 : Form
    {

        public obnoviForm2(string gymid,string name,string surname,string sex,string dateOfBirth, string email,string paymentDate,string expDate,string tot, string img)
        {
            InitializeComponent();
            textBox1.Text = gymid;
            textBox2.Text = name;
            textBox3.Text = surname;
            textBox4.Text = sex;
            dateTimePicker1.Value = DateTime.Parse(dateOfBirth);
            textBox6.Text = email;
            dateTimePicker2.Value = DateTime.Parse(paymentDate);
            dateTimePicker3.Value = DateTime.Parse(expDate);
            textBox5.Text = tot;
           // pictureBox1.Image = Image.FromFile(img);
            /*string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);
            string imagePath = path + "\\images\\" + img;
            pictureBox1.Image = new Bitmap(imagePath); */
            //pictureBox1.Image= StringToImage(img);
          
        }


        /* public Bitmap stringToImage(string inputString)
         {
             byte[] imageBytes = Encoding.Unicode.GetBytes(inputString);
             using (MemoryStream ms = new MemoryStream(imageBytes))
             {
                 return new Bitmap(ms);
             }
         }*/

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            kampusGym f = new kampusGym();
            f.Show();
            this.Hide();
        }
        dodajKlasa c = new dodajKlasa();
        BP u = new BP();
        private void ObnoviBotun_Click(object sender, EventArgs e)
        {
            bool check = false;
            check = provjera(dateTimePicker2, dateTimePicker3);
            if (check)
            {
                c.gym_id = int.Parse(textBox1.Text);
                c.ime = textBox2.Text;
                c.prezime = textBox3.Text;
                c.spol = textBox4.Text;
                c.datum_rodenja = dateTimePicker1.Value.ToShortDateString();
                c.email = textBox6.Text;
                c.datum_placanja = dateTimePicker2.Value.ToShortDateString();
                c.datum_vrijedi_do = dateTimePicker3.Value.ToShortDateString();
                c.vrsta_treninga = textBox5.Text;
                c.slika = pictureBox1.ToString();



                bool success = u.Update(c);
                if (success)
                    MessageBox.Show("Obnovljeno clanstvo.");
                else MessageBox.Show("Pogreska pri obnavljanju clanstva.");



                kampusGym f = new kampusGym();
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Neispravan datum obnove clanstva");
        }

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

        private void obnoviForm2_Load(object sender, EventArgs e)
        {
            //pictureBox1 se treba ucitati
           /* try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter=""
            }*/
            
        }

        private void obnoviBotun_MouseEnter(object sender, EventArgs e)
        {
            obnoviBotun.Size = new Size(85, 85);
        }

        private void obnoviBotun_MouseLeave(object sender, EventArgs e)
        {
            obnoviBotun.Size = new Size(75, 75);
        }

        private void vratiNaPocetak2_MouseEnter(object sender, EventArgs e)
        {
            vratiNaPocetak2.Size = new Size(85, 85);
        }

        private void vratiNaPocetak2_MouseLeave(object sender, EventArgs e)
        {
            vratiNaPocetak2.Size = new Size(75, 75);
        }
    }
}

