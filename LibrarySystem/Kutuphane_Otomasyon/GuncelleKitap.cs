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
    public partial class GuncelleKitap: Form
    {
        public Book b = new Book();
        public Author a = new Author();
        public GuncelleKitap()
        {
            InitializeComponent();
        }

        private void GuncelleKitap_Load(object sender, EventArgs e)
        {
            if(b!=null)
            {
                textBox1.Text = b.Title;
                textBox2.Text = b.ByAuthor.FullName;
            }
            else
            {
                MessageBox.Show("Lütfen Kitap Seçiniz");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryContext db = new LibraryContext();
            var guncelle_kitap = db.Books.FirstOrDefault(x => x.BookID==b.BookID);
            var aranan_yazar = db.Authors.Where(x=> x.FullName==textBox2.Text).FirstOrDefault();      
            if(aranan_yazar!=null)
            {
                guncelle_kitap.Title = textBox1.Text;
                guncelle_kitap.ByAuthor = aranan_yazar;
                db.SaveChanges();
                MessageBox.Show("Güncelleme işlemi başarılı");
            }
            else
            {
                MessageBox.Show("Yazar Bulunamadı Litfen Yazarı Ekleyip Tekrar Deneyiniz");
            }
        }
    }
}
