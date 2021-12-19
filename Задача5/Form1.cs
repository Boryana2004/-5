using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задача5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bel_izpit, mat_izpit, bel_dip, mat_dip, ezik_dip;
            double rezultat;

            bel_izpit = double.Parse(bel_i.Text);
            mat_izpit = double.Parse(mat_i.Text);
            bel_dip = double.Parse(bel_d.Text);
            mat_dip = double.Parse(mat_d.Text);
            ezik_dip = double.Parse(ezik.Text);
            rezultat = bel_izpit + 2*mat_izpit + bel_dip + mat_dip + ezik_dip;
            bal.Text = rezultat.ToString();

            if (rezultat<21)
            {
                profil.Text = "Не сте класиран!";
            }
            else if (rezultat<=25)
            {
                profil.Text = "Технологичен";
            }
            else if (rezultat<=29)
            {
                profil.Text = "Софтуерни и хардуерни науки";
            }
            else
            {
                profil.Text = "Математически";
            }

            if (bel_izpit==2 || mat_izpit==2)
            {
                profil.Text = "Нямате право на класиране!";
            }

        }
    }
}
