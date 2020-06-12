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
    public partial class chartForm : Form
    {
        public chartForm()
        {
            InitializeComponent();
           // this.StartPosition = FormStartPosition.Manual;
           // this.Location = new Point(700, 150);
        }

        public int trening_raspored=0;
        private void chartForm_Load(object sender, EventArgs e)
        {
            // SVE ZA RASPORED pictureBox
            string[] sva_polja =
            {
                "a1b1","a1b2","a1b3","a1b4","a1b5","a1b6",
                "a2b1", "a2b2", "a2b3", "a2b4", "a2b5", "a2b6",
                "a3b1","a3b2","a3b3","a3b4","a3b5","a3b6",
                "a4b1","a4b2","a4b3","a4b4","a4b5","a4b6",
                "a5b1","a5b2","a5b3","a5b4","a5b5","a5b6",
                "a6b1","a6b2","a6b3","a6b4","a6b5","a6b6",
                "a7b1","a7b2","a7b3","a7b4","a7b5","a7b6",
                "a8b1","a8b2","a8b3","a8b4","a8b5","a8b6",
                "a9b1","a9b2","a9b3","a9b4","a9b5","a9b6",
                "a10b1","a10b2","a10b3","a10b4","a10b5","a10b6",
                "a11b1","a11b2","a11b3","a11b4","a11b5","a11b6",
                "a12b1","a12b2","a12b3","a12b4","a12b5","a12b6",
                "a13b1","a13b2","a13b3","a13b4","a13b5","a13b6"
            };

            int j = 0;
            int k = 0;
            int counter = 0;
            int index = 0;
            /*DataClasses3DataContext db3 = new DataClasses3DataContext();
            var varijabla1 = from s in db3.tblRasporeds select s.botunIme;
            string[] ime_botuna = varijabla1.ToArray();
            var varijabla2 = from s in db3.tblRasporeds select s.botunText;
            string[] text_botuna = varijabla2.ToArray(); */

            DataClasses1DataContext db1 = new DataClasses1DataContext();
            var varijabla1 = from s in db1.tblRasporeds select s.botunIme;
            string[] ime_botuna = varijabla1.ToArray();
            var varijabla2 = from s in db1.tblRasporeds select s.botunText;
            string[] text_botuna = varijabla2.ToArray();

            // za raspored
            for (j = 0; j < sva_polja.Length; j++)
            {
                for (k = 0; k < text_botuna.Length; k++)
                {
                    if (sva_polja[j] == ime_botuna[k])
                    {
                        counter++;
                        index = k;
                    }
                }

                if (counter > 0 && (text_botuna[index] == "Privatni trening" || text_botuna[index] == "Kickbox" || text_botuna[index] == "Kružni trening"))
                {
                    trening_raspored++;
                }
                counter = 0;
                index = 0;
            }

            //za vadenje podataka iz baze clanove-> LINQ
            DataClasses2DataContext db2 = new DataClasses2DataContext();

            var pomocna3 = from s in db2.tblMembers select s.spol;
            string[] spol = pomocna3.ToArray();
            var temp3 = from s in db2.tblMembers select s.vrsta_treninga;
            string[] text = temp3.ToArray();
            var varijabla3 = from s in db2.tblMembers select s.id;
            int[] broj = varijabla3.ToArray();

            int[] temp_niz = { 0, 0, 0 };
            int[] spol_niz = { 0, 0 };

            // za graf

            for (int i = 0; i < text.Length; i++)  // vadimo vrste treniga za chart2
            {
                if (text[i] == "Teretana")
                {
                    temp_niz[0]++;
                }
                else if (text[i] == "Kickbox")
                {
                    temp_niz[1]++;
                }
                else if (text[i] == "Kružni trening")
                {
                    temp_niz[2]++;
                }
                else
                {
                    continue;
                }
            }

            for (int i = 0; i < text.Length; i++)  // vadimo vrste ljudi za chart1
            {
                if (spol[i] == "Muški")
                {
                    spol_niz[0]++;
                }
                else if (spol[i] == "Ženski")
                {
                    spol_niz[1]++;
                }
                else
                {
                    continue;
                }
            }


            chart1.Series["s1"].IsValueShownAsLabel = true;
            chart1.Series["s1"].Points.AddXY("1", spol_niz[0]); //ovo ce bit muski
            chart1.Series["s1"].Points.AddXY("2", spol_niz[1]); // ovo zenski
            chart1.Series["s1"].Points[0].LegendText = "Muškarci";
            chart1.Series["s1"].Points[1].LegendText = "Žene";

            chart2.Series["s2"].IsValueShownAsLabel = true;
            chart2.Series["s2"].Points.AddXY("1", temp_niz[0]); //teretana
            chart2.Series["s2"].Points.AddXY("2", temp_niz[1]); // kickbox
            chart2.Series["s2"].Points.AddXY("3", temp_niz[2]); //kruzni trening
            chart2.Series["s2"].Points[0].LegendText = "Teretana";
            chart2.Series["s2"].Points[1].LegendText = "Kickbox";
            chart2.Series["s2"].Points[2].LegendText = "Kružni trening";
        }
    }
}
