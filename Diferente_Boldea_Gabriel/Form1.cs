using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diferente_Boldea_Gabriel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_dif.Text = Convert.ToString(4);
            lbl_final.Visible = false;
        }

        int dif = 4;

        private void btn_iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dif_1_Click(object sender, EventArgs e)
        {
            dif--;
            if (dif != 0)
            {
                lbl_dif.Text = Convert.ToString(dif);
                dif_1.Visible = false;
            }
            else
            {
                lbl_dif.Text = Convert.ToString(dif);
                dif_1.Visible = false;
                //MessageBox.Show("Ati castigat!");
                lbl_final.Visible = true;
            }
        }

        private void dif_2_Click(object sender, EventArgs e)
        {
            dif--;
            if (dif != 0)
            {
                lbl_dif.Text = Convert.ToString(dif);
                dif_2.Visible = false;
            }
            else
            {
                lbl_dif.Text = Convert.ToString(dif);
                dif_2.Visible = false;
                //MessageBox.Show("Ati castigat!");
                lbl_final.Visible = true;
            }
        }

        private void dif_3_Click(object sender, EventArgs e)
        {
            dif--;
            if (dif != 0)
            {
                lbl_dif.Text = Convert.ToString(dif);
                dif_3.Visible = false;
            }
            else
            {
                lbl_dif.Text = Convert.ToString(dif);
                dif_3.Visible = false;
                //MessageBox.Show("Ati castigat!");
                lbl_final.Visible = true;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            dif = 4;
            dif_1.Visible = true;
            dif_2.Visible = true;
            dif_3.Visible = true;
            dif_4.Visible = true;
            lbl_dif.Text = Convert.ToString(dif);
            lbl_final.Visible = false;
        }

        private void dif_4_Click(object sender, EventArgs e)
        {
            dif--;
            if (dif != 0)
            {
                lbl_dif.Text = Convert.ToString(dif);
                dif_4.Visible = false;
            }
            else
            {
                lbl_dif.Text = Convert.ToString(dif);
                dif_4.Visible = false;
                //MessageBox.Show("Ati castigat!");
                lbl_final.Visible = true;
            }
        }
    }
}
