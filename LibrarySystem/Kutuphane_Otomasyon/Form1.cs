using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void üyeKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeKayit frm = new UyeKayit();
            frm.Show();
        }

        private void kitapKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEkle frm = new KitapEkle();
            frm.Show();
        }

        private void yazarKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YazarKayit frm = new YazarKayit();
            frm.Show();
        }

        private void yazaraGöreKitapAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YazaraGoreKitapAra frm = new YazaraGoreKitapAra();
            frm.Show();
        }

        private void adaGöreKitapAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaGoreKitapAra frm = new AdaGoreKitapAra();
            frm.Show();
        }

        private void kitapVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapVer frm = new KitapVer();
            frm.Show();
        }

        private void kitapİadesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapAl frm = new KitapAl();
            frm.Show();
        }

        private void kullanıcıSilGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SilKullanici frm = new SilKullanici();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.Pink;
        }

        private void kitapSilGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaGoreKitapAra frm = new AdaGoreKitapAra();
            frm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string ziyaret_link = "https:/www.cumhuriyet.edu.tr/";
            linkLabel1.LinkVisited = true;
            Process.Start(new ProcessStartInfo
            {
                FileName = ziyaret_link,
            });
        }
    }
}
