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
    public partial class UyeKayit: Form
    {
        public UyeKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryContext db = new LibraryContext();
            User yeni_kisi = new User();
            yeni_kisi.FullName = textBox1.Text;
            db.Users.Add(yeni_kisi);
            db.SaveChanges();
            textBox1.Text = "";
            MessageBox.Show("Kayıt başarılı");
        }
    }
}
