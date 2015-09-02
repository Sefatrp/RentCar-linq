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
    public partial class frmKiralama : Form
    {
        DataContentDataContext content = new DataContentDataContext();
        public frmKiralama()
        {
            InitializeComponent();
        }

        void KiraYenile() 
        {
            var KiraL = from k in content.Kiralas join a in content.Aracs on k.AracID equals a.AracID select new {k.AracID ,k.ID,k.MusteriAd,k.MusteriSoyad,k.MusteriTc,k.Teslim,k.Toplam,k.Alim,a.AracAdi};
            dataGridView2.DataSource = KiraL;
        }

        //from u in icerik.Products
        //                     join c in icerik.Categories
        //                     on u.CategoryID equals c.CategoryID
        //                     where u.ProductName == p.ProductName
        //                     select c.CategoryName).First();
        


        void AracListele()
        {
            var arac = from a in content.Aracs select a;
            dataGridView1.DataSource = arac;
        }
        private void frmKiralama_Load(object sender, EventArgs e)
        {
            AracListele();
            KiraYenile();
        }
      public  int aracID;
        int fiyat;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                aracID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                fiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
            }
            catch (Exception)
            {
            }
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            if (txtAd.Text=="" || txtSoyad.Text=="" || txtTC.Text=="")
            {
                MessageBox.Show("Lutfen Boşlukları Doldurunuz", "Uyarı");
            }
            else
            {
                DialogResult sonuc = MessageBox.Show("Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (sonuc==DialogResult.Yes)
                {
                    var AracUygun=(from a in content.Aracs where a.AracID==aracID select a).First();
                    string durum=AracUygun.Durum;
  
                    if (durum=="Uygun")
                    {
                        try
                        {
                            Kirala k = new Kirala();
                            k.MusteriAd = txtAd.Text;
                            k.MusteriSoyad = txtSoyad.Text;
                            k.MusteriTc = txtTC.Text;
                            k.AracID = aracID;
                            k.Alim = dateTimePicker1.Value;
                            k.Teslim = dateTimePicker2.Value;
                            TimeSpan time = dateTimePicker2.Value - dateTimePicker1.Value;
                            k.Toplam = Convert.ToInt32(time.TotalDays)*fiyat;
                            content.Kiralas.InsertOnSubmit(k);
                            content.SubmitChanges();
                            MessageBox.Show("Araç Kiralandı", "Uyarı");
                            label6.Text = (Convert.ToInt32(time.TotalDays)*fiyat).ToString();

                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Hata !", "Uyarı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Araç Kiralamaya Uygun Degil");
                    }                  
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi");
                }
            }

            txtAd.Clear();
            txtSoyad.Clear();
            txtTC.Clear();
            txtAd.Focus();
            AracListele();
            KiraYenile();

         
        }
        int ID;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            }
            catch (Exception)
            {
                

            }
        }

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            DialogResult sonuc=MessageBox.Show("Emin misiniz ?","Uyarı",MessageBoxButtons.YesNo);
            if (sonuc==DialogResult.Yes)
            {
                try
                {
                    var silKirala = (from k in content.Kiralas where k.ID == ID select k).First();
                    content.Kiralas.DeleteOnSubmit(silKirala);
                    content.SubmitChanges();
                    MessageBox.Show("Kira Silindi");
                    MessageBox.Show(string.Format("{Borc}", silKirala.Toplam));
                }
                catch (Exception)
                {
                }
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi", "Uyarı");
            }

            KiraYenile();
            AracListele();

        }
    }
}
