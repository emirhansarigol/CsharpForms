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
    public partial class KitapEkle: Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryContext db = new LibraryContext();
            string yazar = textBox2.Text;
            var yazar_id = db.Authors.FirstOrDefault(x=> x.FullName==textBox2.Text);
            if(yazar_id!=null)
            {
                Book ktp = new Book();
                ktp.Title = textBox1.Text;
                ktp.AuthorId = Convert.ToInt32(yazar_id.AuthorId);
                ktp.IsAvailable = true;
                db.Books.Add(ktp);
                db.SaveChanges();
            }
            else
            {
                Book ktp = new Book();
                Author yzr = new Author();
                yzr.FullName = textBox2.Text;
                db.Authors.Add(yzr);
                db.SaveChanges();
                ktp.Title = textBox1.Text;
                ktp.AuthorId = yzr.AuthorId;
                ktp.IsAvailable = true;
                db.Books.Add(ktp);
                db.SaveChanges();
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
