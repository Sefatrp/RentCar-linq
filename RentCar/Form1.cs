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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataContentDataContext context = new DataContentDataContext();
        private void btnGırıs_Click(object sender, EventArgs e)
        {
            // kullancı var mı yok mu sorgusu 
            // tum kullanıcı tablosunu cektik ve foreach sokarak kotrol ettik
            // var sa frmkullanıcıya yonlendirsin yok sa msj versin
            var KullaniciSorgu = from k in context.Kullanicis select k;
            foreach (var item in KullaniciSorgu)
            {
                if (item.KullaniciAdi==txtAd.Text && item.KullaniciSifre==txtSifre.Text)
                {
                    frmKullanaci frm = new frmKullanaci();
                    frm.ShowDialog();
                    break;
                }
                else
                {
                    MessageBox.Show("Boyle bir Kullanıcı yok");
                }
            }
        }
    }
}
