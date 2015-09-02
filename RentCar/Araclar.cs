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
    public partial class Araclar : Form
    {
        public Araclar()
        {
            InitializeComponent();
        }
        DataContentDataContext content = new DataContentDataContext();
        void MarkaListele() 
        {
            var markalar = from a in content.Markas select a;

            cbModel.DisplayMember = "MarkaAdi";
            cbModel.ValueMember = "MarkaID";
            cbModel.DataSource = markalar;

        }
        void AracListele() 
        {
            var arac = from a in content.Aracs select a;
            dataGridView1.DataSource = arac;
            
        }

        private void Araclar_Load(object sender, EventArgs e)
        {
            MarkaListele();
            AracListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (txtAracAdi.Text==""  || txtModel.Text=="" || txtPlaka.Text=="" || txtUcret.Text=="")
            {
                MessageBox.Show("Lutfen Boşlukları Doldurunuz", "Uyarı");
            }
            else
            {
                DialogResult sonuc = MessageBox.Show("Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (sonuc==DialogResult.Yes)
                {
                    try
                    {
                        Arac a = new Arac();
                        a.AracAdi = txtAracAdi.Text;
                        a.Marka = Convert.ToInt32(cbModel.SelectedValue.ToString());
                        a.Model = Convert.ToInt32(txtModel.Text);
                        a.Plaka = txtPlaka.Text;
                        a.Yakıt = cbYakit.SelectedItem.ToString();
                        a.Ucret = Convert.ToInt32(txtUcret.Text);
                        a.Durum = "Uygun";
                        content.Aracs.InsertOnSubmit(a);
                        content.SubmitChanges();
                        MessageBox.Show("Eklendi ", "Uyarı");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata !", "Uyarı");                   
                    }          
                }
                else
                {
                    MessageBox.Show("İşleminiz İptal Edildi");
                }
            }
            txtAracAdi.Clear();
            txtModel.Clear();
            txtPlaka.Clear();
            txtUcret.Clear();
            cbModel.Text = "";
            cbYakit.Text = "";
            txtAracAdi.Focus();
            AracListele();
           
        }

        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbModel.SelectedIndex==0)
            {
                pbArac.Image = Properties.Resources.mcd;
            }
            else if (cbModel.SelectedIndex==1)
            {
                pbArac.Image = Properties.Resources.ferrari;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (sonuc==DialogResult.Yes)
            {
                try
                {
                    var SilArac = (from a in content.Aracs where a.AracID == aracID select a).First();
                    content.Aracs.DeleteOnSubmit(SilArac);
                    content.SubmitChanges();
                    MessageBox.Show("Silindi", "Uyarı");

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

         
        }

        int aracID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                aracID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            }
            catch (Exception)
            {
                
               
            }
          
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                aracID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                txtAracAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cbModel.SelectedIndex = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value)-1;
                txtModel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtPlaka.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cbYakit.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtUcret.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception)
            {
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAracAdi.Text == "" || txtModel.Text == "" || txtPlaka.Text == "" || txtUcret.Text == "")
            {
                MessageBox.Show("Lutfen Boşlukları Doldurunuz", "Uyarı");
            }
            else
            {
                DialogResult sonuc = MessageBox.Show("Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                if (sonuc==DialogResult.Yes)
                {
                    try
                    {
                        var GuncelleArac = (from a in content.Aracs where a.AracID == aracID select a).First();
                        GuncelleArac.AracAdi = txtAracAdi.Text;
                        GuncelleArac.Marka = Convert.ToInt32(cbModel.SelectedValue.ToString());
                        GuncelleArac.Plaka = txtPlaka.Text;
                        GuncelleArac.Ucret =  Convert.ToInt32(txtUcret.Text);
                        GuncelleArac.Yakıt = cbYakit.SelectedItem.ToString();
                        GuncelleArac.Model = Convert.ToInt32(txtModel.Text);
                        content.SubmitChanges();
                        MessageBox.Show("Guncellendi !", "Uyarı");
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

            txtAracAdi.Clear();
            txtModel.Clear();
            txtPlaka.Clear();
            txtUcret.Clear();
            cbModel.Text = "";
            cbYakit.Text = "";
            txtAracAdi.Focus();
            AracListele();
        }

       
    }
}
