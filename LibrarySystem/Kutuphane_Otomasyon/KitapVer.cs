using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public partial class KitapVer: Form
    {
        public Book ktp;
        public User klnc;
        public KitapVer()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            LibraryContext db = new LibraryContext();
            int bookid = Convert.ToInt32(textBox1.Text);
            string kullanici_adi = textBox2.Text;
            var kitap = db.Books.FirstOrDefault(x => x.BookID == bookid);
            var kullanici = db.Users.FirstOrDefault(x => x.FullName == kullanici_adi);
            if (kitap != null)
            {
                if (kitap.IsAvailable)
                {
                    if (kullanici != null)
                    {
                        kitap.IsAvailable = false;
                        kitap.UserID = kullanici.UserID;
                        MessageBox.Show("Kitap Başarılı Şekilde Verildi");
                        db.SaveChanges();
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Bulunamadı");
                    }
                }
                else
                {
                    MessageBox.Show("Kitap Müsait Değil");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Kitap Bulunamadı");
            }
        }

        private void KitapVer_Load(object sender, EventArgs e)
        {
            if(ktp!=null)
            {
                textBox1.Text = ktp.BookID.ToString();
            }
        }
    }
}
