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
    public partial class frmKullananiciIslemleri : Form
    {
        public frmKullananiciIslemleri()
        {
            InitializeComponent();
        }
        DataContentDataContext content = new DataContentDataContext();
        //Kullanıcı Ekleme
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text=="" || txtSifre.Text=="")
            {
                MessageBox.Show("Lutfen Boşluları Doldurunuz !", "Uyarı");
            }
            else
            {
                DialogResult sonuc = MessageBox.Show("Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (sonuc==DialogResult.Yes)
                {
                    try
                    {
                        Kullanici k = new Kullanici();
                        k.KullaniciAdi = txtAd.Text;
                        k.KullaniciSifre = txtSifre.Text;
                        content.Kullanicis.InsertOnSubmit(k);
                        content.SubmitChanges();

                        MessageBox.Show("Kullanıcı Eklendi","Uyarı");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata!", "Uyarı");
                    }
                   
                }
                else
                {
                    MessageBox.Show("İptal Edildi");
                }
            }

            Listele();
            txtAd.Clear();
            txtSifre.Clear();
            txtAd.Focus();

        }
        //grid view de gosterme
        //Listeleme
        public void Listele() 
        {
            var Kullanıcılar = from k in content.Kullanicis select k;
            dataGridView1.DataSource = Kullanıcılar;
        }

        private void frmKullananiciIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        // Silme
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc=MessageBox.Show("Emin misiniz ?","Uyarı",MessageBoxButtons.YesNo);
            if (sonuc==DialogResult.Yes)
            {
                try
                {
                    var Kullancı = (from k in content.Kullanicis where k.KullaniciID == kullaniciId select k).First();
                    content.Kullanicis.DeleteOnSubmit(Kullancı);
                    content.SubmitChanges();
                    MessageBox.Show("Silindi","Uyarı");
                }
                catch (Exception)
                {

                    MessageBox.Show("Hata !", "Uyarı");
                }
              
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi", "Uyarı");
            }
            Listele();
                          
        }
        public int kullaniciId;

        //grid view den tıklandıgının kullanıcıId alma 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int satir = e.RowIndex;
            try
            {
                kullaniciId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                this.Text = kullaniciId.ToString();
            }
            catch (Exception)
            {
            }
        }

        //Kullanici Guncelle
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text=="" || txtSifre.Text=="")
            {
                MessageBox.Show("Lütfen Boşlukları Doldurunuz", "Uyarı");

            }
            else
            {
                DialogResult sonuc = MessageBox.Show("Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (sonuc==DialogResult.Yes)
                {
                    try
                    {
                        var GuncKullanici = (from k in content.Kullanicis where k.KullaniciID == kullaniciId select k).First();
                        GuncKullanici.KullaniciAdi = txtAd.Text;
                        GuncKullanici.KullaniciSifre = txtSifre.Text;
                        content.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata !", "Uyarı");
                    }
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi");
                }
            }
            Listele();
            txtAd.Clear();
            txtSifre.Clear();
            txtAd.Focus();
        }

        //cıft tıkladıgında txt yazma
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = e.RowIndex;
            try
            {
                kullaniciId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                this.Text = kullaniciId.ToString();
                txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
