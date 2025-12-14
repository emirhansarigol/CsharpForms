namespace Kutuphane_Otomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kayıtİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silmeGüncellemeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarSilGünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıSilGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazaraGöreKitapAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaGöreKitapAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtİşlemleriToolStripMenuItem,
            this.silmeGüncellemeİşlemleriToolStripMenuItem,
            this.kitapİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(38, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(322, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kayıtİşlemleriToolStripMenuItem
            // 
            this.kayıtİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeKaydıToolStripMenuItem,
            this.kitapKaydıToolStripMenuItem,
            this.yazarKaydıToolStripMenuItem});
            this.kayıtİşlemleriToolStripMenuItem.Name = "kayıtİşlemleriToolStripMenuItem";
            this.kayıtİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.kayıtİşlemleriToolStripMenuItem.Text = "Kayıt İşlemleri";
            // 
            // üyeKaydıToolStripMenuItem
            // 
            this.üyeKaydıToolStripMenuItem.Name = "üyeKaydıToolStripMenuItem";
            this.üyeKaydıToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.üyeKaydıToolStripMenuItem.Text = "Üye Kaydı";
            this.üyeKaydıToolStripMenuItem.Click += new System.EventHandler(this.üyeKaydıToolStripMenuItem_Click);
            // 
            // kitapKaydıToolStripMenuItem
            // 
            this.kitapKaydıToolStripMenuItem.Name = "kitapKaydıToolStripMenuItem";
            this.kitapKaydıToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.kitapKaydıToolStripMenuItem.Text = "Kitap Kaydı";
            this.kitapKaydıToolStripMenuItem.Click += new System.EventHandler(this.kitapKaydıToolStripMenuItem_Click);
            // 
            // yazarKaydıToolStripMenuItem
            // 
            this.yazarKaydıToolStripMenuItem.Name = "yazarKaydıToolStripMenuItem";
            this.yazarKaydıToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.yazarKaydıToolStripMenuItem.Text = "Yazar Kaydı";
            this.yazarKaydıToolStripMenuItem.Click += new System.EventHandler(this.yazarKaydıToolStripMenuItem_Click);
            // 
            // silmeGüncellemeİşlemleriToolStripMenuItem
            // 
            this.silmeGüncellemeİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazarSilGünToolStripMenuItem,
            this.kullanıcıSilGüncelleToolStripMenuItem});
            this.silmeGüncellemeİşlemleriToolStripMenuItem.Name = "silmeGüncellemeİşlemleriToolStripMenuItem";
            this.silmeGüncellemeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.silmeGüncellemeİşlemleriToolStripMenuItem.Text = "Güncelleme İşlemleri";
            // 
            // yazarSilGünToolStripMenuItem
            // 
            this.yazarSilGünToolStripMenuItem.Name = "yazarSilGünToolStripMenuItem";
            this.yazarSilGünToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.yazarSilGünToolStripMenuItem.Text = "Yazar Güncelle";
            // 
            // kullanıcıSilGüncelleToolStripMenuItem
            // 
            this.kullanıcıSilGüncelleToolStripMenuItem.Name = "kullanıcıSilGüncelleToolStripMenuItem";
            this.kullanıcıSilGüncelleToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.kullanıcıSilGüncelleToolStripMenuItem.Text = "Kullanıcı Sil/Güncelle";
            this.kullanıcıSilGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıSilGüncelleToolStripMenuItem_Click);
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            this.kitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapAraToolStripMenuItem});
            this.kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            this.kitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            // 
            // kitapAraToolStripMenuItem
            // 
            this.kitapAraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazaraGöreKitapAraToolStripMenuItem,
            this.adaGöreKitapAraToolStripMenuItem});
            this.kitapAraToolStripMenuItem.Name = "kitapAraToolStripMenuItem";
            this.kitapAraToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.kitapAraToolStripMenuItem.Text = "Kitap Ara";
            // 
            // yazaraGöreKitapAraToolStripMenuItem
            // 
            this.yazaraGöreKitapAraToolStripMenuItem.Name = "yazaraGöreKitapAraToolStripMenuItem";
            this.yazaraGöreKitapAraToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.yazaraGöreKitapAraToolStripMenuItem.Text = "Yazara Göre Kitap Ara";
            this.yazaraGöreKitapAraToolStripMenuItem.Click += new System.EventHandler(this.yazaraGöreKitapAraToolStripMenuItem_Click);
            // 
            // adaGöreKitapAraToolStripMenuItem
            // 
            this.adaGöreKitapAraToolStripMenuItem.Name = "adaGöreKitapAraToolStripMenuItem";
            this.adaGöreKitapAraToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.adaGöreKitapAraToolStripMenuItem.Text = "Ada Göre Kitap Ara";
            this.adaGöreKitapAraToolStripMenuItem.Click += new System.EventHandler(this.adaGöreKitapAraToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(120, 243);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.cumhuriyet.edu.tr/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(226, 151);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(198, 89);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(208, 89);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(226, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kutuphane_Otomasyon.Properties.Resources.form;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(436, 265);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silmeGüncellemeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazaraGöreKitapAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaGöreKitapAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarSilGünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıSilGüncelleToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

