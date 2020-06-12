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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        BP_Login b = new BP_Login();
        loginKlasa k = new loginKlasa();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PrijavaBotun_Click(object sender, EventArgs e)
        {
            k.username = textBox1.Text.Trim();
            k.password = textBox2.Text.Trim();

            bool success = b.loginCheck(k);
            if(success==true)
            {
                //login ok
                MessageBox.Show("Prijava ispravna.");

                if(k.username=="admin" || k.username=="user")
                {
                    kampusGym au = new kampusGym();
                    au.Show();
                    this.Hide();
                }
            }
            else
            {
                //login failed
                MessageBox.Show("Prijava neuspješna. Pokušajte ponovo.");
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = PrijavaBotun;  //enter radi za botun
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
