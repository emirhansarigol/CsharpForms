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
    public partial class YazarKayit: Form
    {
        public YazarKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryContext db = new LibraryContext();
            var aranan_yazar = db.Authors.FirstOrDefault(x => x.FullName == textBox1.Text);
            if(aranan_yazar==null)
            {
                Author yzr = new Author();
                yzr.FullName = textBox1.Text;
                db.Authors.Add(yzr);
                db.SaveChanges();
                textBox1.Text = "";
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Böyle bir yazar zaten mevcut");
            }
            
        }
    }
}
