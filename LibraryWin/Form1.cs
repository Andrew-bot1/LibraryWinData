using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radAud_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            lblLength.Visible = true;
            txtLength.Visible = true;
            lblNar.Visible = true;
            txtNar.Visible = true;
        }

        private void radBook_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            lblPages.Visible = true;
            txtPages.Visible = true;
        }

        private void HideAll()
        {
            lblLength.Visible = false;
            txtLength.Visible = false;
            lblNar.Visible = false;
            txtNar.Visible = false;
            lblPages.Visible = false;
            txtPages.Visible = false;
            lblDis.Visible = false;
            txtDis.Visible = false;
            lblIll.Visible = false;
            txtIll.Visible = false;
            lblIllPgs.Visible = false;
            txtIllPgs.Visible = false;
        }

        private void radDis_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            lblDis.Visible = true;
            txtDis.Visible = true;
        }

        private void radIll_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            lblIll.Visible = true;
            txtIll.Visible = true;
            lblIllPgs.Visible = true;
            txtIllPgs.Visible = true;
            lblPages.Visible = true;
            txtPages.Visible = true;
        }
    }
}
