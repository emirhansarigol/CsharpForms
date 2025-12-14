using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public partial class SilKullanici: Form
    {
        public SilKullanici()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            LibraryContext db = new LibraryContext();
            string arama = textBox1.Text;
            var ara_kullanici = (from kullaniciler in db.Users
                                 where kullaniciler.FullName.Contains(arama)
                                 select new
                                 {
                                     KullaniciID = kullaniciler.UserID,
                                     İsim = kullaniciler.FullName,
                                 }
                               );
            dataGridView1.DataSource = ara_kullanici.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryContext db = new LibraryContext();
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var sil_kullanici = db.Users.FirstOrDefault(x => x.UserID == id);
            DialogResult dr = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sil_kullanici!=null && dr==DialogResult.Yes)
            {
                db.Users.Remove(sil_kullanici);
                db.SaveChanges();
                string arama = textBox1.Text;
                var ara_kullanici = (from kullaniciler in db.Users
                                     where kullaniciler.FullName.Contains(arama)
                                     select new
                                     {
                                         KullaniciID = kullaniciler.UserID,
                                         İsim = kullaniciler.FullName,
                                     }
                                   );
                dataGridView1.DataSource = ara_kullanici.ToList();
                MessageBox.Show("Silme işlemi  başarılı");
            }
            else
            {
                MessageBox.Show("Lütfen Silmek İstedğiniz Kullanıcıyı Seçiniz");
            }
        }

        private void SilKullanici_Load(object sender, EventArgs e)
        {
            LibraryContext db = new LibraryContext();
            string arama = textBox1.Text;
            var ara_kullanici = (from kullaniciler in db.Users
                                 where kullaniciler.FullName.Contains(arama)
                                 select new
                                 {
                                     KullaniciID = kullaniciler.UserID,
                                     İsim = kullaniciler.FullName,
                                 }
                               );
            dataGridView1.DataSource = ara_kullanici.ToList();
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            LibraryContext db = new LibraryContext();
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var aranan_kullanici = db.Users.FirstOrDefault(x => x.UserID == id);
            GuncelleKullanici frm = new GuncelleKullanici();
            frm.klnc = aranan_kullanici;
            if (frm.klnc != null)
            {
                frm.Show();
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Lütfen Düzenlemek İstediğiniz Kişiyi Seçiniz");
            }
        }
    }
}
