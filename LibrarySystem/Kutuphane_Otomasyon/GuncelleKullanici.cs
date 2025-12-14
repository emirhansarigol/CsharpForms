using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public partial class GuncelleKullanici: Form
    {
        public User klnc;
        public GuncelleKullanici()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LibraryContext db = new LibraryContext();
            var guncellenecek = db.Users.FirstOrDefault(x => x.FullName == klnc.FullName && x.UserID==klnc.UserID);
            if(guncellenecek!=null)
            {
                guncellenecek.FullName = textBox3.Text;
                db.SaveChanges();
                MessageBox.Show("Güncelleme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Kullanıcıyı Seçiniz");
            }
            
        }

        private void GuncelleKullanici_Load(object sender, EventArgs e)
        {
            textBox2.Text = klnc.UserID.ToString();
            textBox3.Text = klnc.FullName;
        }
    }
}
