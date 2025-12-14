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
    public partial class YazaraGoreKitapAra: Form
    {
        public YazaraGoreKitapAra()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            LibraryContext db = new LibraryContext();
            string yazar_adi = textBox1.Text;
            var ktp = (from kitap in db.Books
                       join yazar in db.Authors on kitap.AuthorId equals yazar.AuthorId
                       where yazar.FullName.Contains(yazar_adi)
                       select new
                       {
                           KitapId=kitap.BookID,
                           KitapAdi = kitap.Title,
                           YazarAdi = yazar.FullName,
                           Durum = kitap.IsAvailable ? "Mevcut" : "Emanette",
                           Kullanici = kitap.ByUser.FullName
                       }
                       );
            dataGridView1.DataSource = ktp.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryContext db = new LibraryContext();
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var aranan_kitap = db.Books.FirstOrDefault(x => x.BookID == id);
            KitapVer frm = new KitapVer();
            frm.ktp = aranan_kitap;
            frm.klnc = aranan_kitap.ByUser;
            if(frm.klnc==null)
            {
                frm.Show();
            }
            else
            {
                MessageBox.Show("Kitap Emanette");
            }
        }
        private void YazaraGoreKitapAra_Load(object sender, EventArgs e)
        {
            LibraryContext db = new LibraryContext();
            var kitaplar = (from ktp in db.Books
                            join yzr in db.Authors on ktp.AuthorId equals yzr.AuthorId
                            select new
                            {
                                KitapId = ktp.BookID,
                                KitapAdi = ktp.Title,
                                YazarAdi = yzr.FullName,
                                Durum = ktp.IsAvailable ? "Mevcut" : "Emanette",
                                KullaniciAdi = ktp.ByUser.FullName
                            }
                          );
            dataGridView1.DataSource = kitaplar.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LibraryContext db = new LibraryContext();
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var aranan_kitap = db.Books.FirstOrDefault(x => x.BookID == id);
            KitapAl frm = new KitapAl();
            frm.ktp = aranan_kitap;
            frm.klnc = aranan_kitap.ByUser;
            if(frm.klnc!=null)
            {
                frm.Show();
            }
            else
            {
                MessageBox.Show("Kitap Zaten Müsait");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LibraryContext db = new LibraryContext();
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var silinecek_kitap = db.Books.FirstOrDefault(x => x.BookID == id);
            DialogResult dr = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (silinecek_kitap!=null && dr==DialogResult.Yes)
            {
                db.Books.Remove(silinecek_kitap);
                db.SaveChanges();
                MessageBox.Show("Seçilen Kitap Başarıyla Silindi");
            }
            else
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Kitabı Seçiniz");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LibraryContext db = new LibraryContext();
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var aranan_kitap = db.Books.FirstOrDefault(x => x.BookID == id);
            var aranan_yazar = db.Authors.FirstOrDefault(x => x.AuthorId == aranan_kitap.AuthorId);
            GuncelleKitap frm = new GuncelleKitap();
            frm.b = aranan_kitap;
            frm.a = aranan_yazar;
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LibraryContext db = new LibraryContext();
            var kitaplar = (from ktp in db.Books
                            join yzr in db.Authors on ktp.AuthorId equals yzr.AuthorId
                            select new
                            {
                                KitapId = ktp.BookID,
                                KitapAdi = ktp.Title,
                                YazarAdi = yzr.FullName,
                                Durum = ktp.IsAvailable ? "Mevcut" : "Emanette",
                                KullaniciAdi = ktp.ByUser.FullName
                            }
                          );
            dataGridView1.DataSource = kitaplar.ToList();
        }
    }
}
