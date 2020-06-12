using kampusGym.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kampusGym
{
    public partial class kampusGym : Form
    {
        public kampusGym()
        {
            InitializeComponent();
        }
        

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            dodajForm f = new dodajForm();
            f.Show();
            this.Hide();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            obnoviForm f = new obnoviForm();
            f.Show();
            this.Hide();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            urediForm f = new urediForm();
            f.Show();
            this.Hide();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            dodajForm f = new dodajForm();
            f.Show();
            this.Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            obnoviForm f = new obnoviForm();
            f.Show();
            this.Hide();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            urediForm f = new urediForm();
            f.Show();
            this.Hide();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            rasporedForm f = new rasporedForm();
            f.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            invertarForm f = new invertarForm();
            f.Show();
            this.Hide();
        }

        private void kampusGym_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm log = new loginForm();
            log.Show();
            this.Hide();

        }
        /// <summary>
        /// GOREEEEE SVE VALJAAAAAAAA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        #region Hovering pictureBoxes
        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(90, 90);
            Font f = new Font("Maiandra GD", 22, FontStyle.Bold);
            label7.Font = f;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(90, 90);
            Font f = new Font("Maiandra GD", 22, FontStyle.Bold);
            label6.Font = f;

        }
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(90, 90);
            Font f = new Font("Maiandra GD", 22, FontStyle.Bold);
            label2.Font = f;
        }
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(90, 90);
            Font f = new Font("Maiandra GD", 22, FontStyle.Bold);
            label5.Font = f;
        }
        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(90, 90);
            Font f = new Font("Maiandra GD", 22, FontStyle.Bold);
            label3.Font = f;
        }
        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(75, 75);
            Font f = new Font("Maiandra GD", 15, FontStyle.Bold);
            label7.Font = f;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(75, 75);
            Font f = new Font("Maiandra GD", 15, FontStyle.Bold);
            label6.Font = f;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(75, 75);
            Font f = new Font("Maiandra GD", 15, FontStyle.Bold);
            label2.Font = f;
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(75, 75);
            Font f = new Font("Maiandra GD", 15, FontStyle.Bold);
            label5.Font = f;
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(75, 75);
            Font f = new Font("Maiandra GD", 15, FontStyle.Bold);
            label3.Font = f;
        }
        #endregion

        #region Hovering labels
        private void label6_MouseEnter(object sender, EventArgs e)
        {
            Font f = new Font("Maiandra GD", 22, FontStyle.Bold);
            label6.Font = f;
            pictureBox2.Size = new Size(90, 90);
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            Font f = new Font("Maiandra GD", 22, FontStyle.Bold);
            label2.Font = f;
            pictureBox3.Size = new Size(90, 90);
        }
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            Font f = new Font("Maiandra GD", 22, FontStyle.Bold);
            label3.Font = f;
            pictureBox5.Size = new Size(90, 90);
        }
        private void label5_MouseEnter(object sender, EventArgs e)
        {
            Font f = new Font("Maiandra GD", 22, FontStyle.Bold);
            label5.Font = f;
            pictureBox4.Size = new Size(90,90);
        }
        private void label7_MouseEnter(object sender, EventArgs e)
        {
            Font f = new Font("Maiandra GD", 22, FontStyle.Bold);
            label7.Font = f;
            pictureBox8.Size = new Size(90,90);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            Font f = new Font("Maiandra GD", 15, FontStyle.Bold);
            label6.Font = f;
            pictureBox2.Size = new Size(75, 75);
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            Font f = new Font("Maiandra GD", 15, FontStyle.Bold);
            label2.Font = f;
            pictureBox3.Size = new Size(75, 75);
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Font f = new Font("Maiandra GD", 15, FontStyle.Bold);
            label3.Font = f;
            pictureBox5.Size = new Size(75, 75);
        }
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            Font f = new Font("Maiandra GD", 15, FontStyle.Bold);
            label5.Font = f;
            pictureBox4.Size = new Size(75, 75);
        }
        private void label7_MouseLeave(object sender, EventArgs e)
        {
            Font f = new Font("Maiandra GD", 15, FontStyle.Bold);
            label7.Font = f;
            pictureBox8.Size = new Size(75, 75);
        }

        #endregion


        private void pictureBox6_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(85, 85);
        }

        private void pictureBox6_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(75, 75);
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(85, 85);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(75, 75);
        }

        chartForm f = new chartForm();
        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(85, 85);
            f.Show();
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(75, 75);
            f.Hide();
        }

    }
}
