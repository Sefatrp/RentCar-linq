using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar
{
    public partial class frmKullanaci : Form
    {
        public frmKullanaci()
        {
            InitializeComponent();
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Dispose();
            }
            frmKullananiciIslemleri frm = new frmKullananiciIslemleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnArac_Click(object sender, EventArgs e)
        {
             foreach (Form item in this.MdiChildren)
            {
                item.Dispose();
            }
            Araclar frm = new Araclar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Dispose();
            }
            frmKiralama frm = new frmKiralama();
            frm.MdiParent = this;
            frm.Show();
        }

        
    }
}
