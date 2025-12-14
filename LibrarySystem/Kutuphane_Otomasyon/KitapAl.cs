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
    public partial class KitapAl: Form
    {
        public Book ktp;
        public User klnc;
        public KitapAl()
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
            if(kitap!=null)
            {
                if (!kitap.IsAvailable)
                {
                    kitap.UserID = null;
                    kitap.IsAvailable = true;
                    db.SaveChanges();
                    MessageBox.Show("Kitap Başarıyla Geri Alındı");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Kitap Zaten Müsait");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Kitap Bulunamdı");
            }
        }

        private void KitapAl_Load(object sender, EventArgs e)
        {
            if(ktp!=null && klnc != null)
            {
                textBox1.Text = ktp.BookID.ToString();
                textBox2.Text = klnc.FullName;
            }
            else
            {
                MessageBox.Show("Müsait Kitap Seçildi");
            }
        }
    }
}
