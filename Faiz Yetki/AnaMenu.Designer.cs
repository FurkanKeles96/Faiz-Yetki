namespace $safeprojectname$
{
    partial class AnaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriTanımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıTanımlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiTanımlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faizYetkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMusteri = new System.Windows.Forms.GroupBox();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.dgwMusteri = new System.Windows.Forms.DataGridView();
            this.musIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMusteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriData = new $safeprojectname$.musteriData();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusNo = new System.Windows.Forms.TextBox();
            this.txtMusAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMusteriKaydet = new System.Windows.Forms.Button();
            this.txtMusSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpKullanici = new System.Windows.Forms.GroupBox();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.dgwKullanici = new System.Windows.Forms.DataGridView();
            this.kulIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kulSicilNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kulSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kulYoneticiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblKullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciData = new $safeprojectname$.kullaniciData();
            this.btnKullaniciTanimla = new System.Windows.Forms.Button();
            this.chkYonetici = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.txtSicilNo = new System.Windows.Forms.TextBox();
            this.grpYetkiTanimla = new System.Windows.Forms.GroupBox();
            this.yetkiSeviyesiSil = new System.Windows.Forms.Button();
            this.dgwYetkiSeviye = new System.Windows.Forms.DataGridView();
            this.yetkiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seviyeTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seviyeMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seviyeMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblYetkiSeviyesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetYetkiSeviyesi = new $safeprojectname$.dataSetYetkiSeviyesi();
            this.btnYetkiSeviyesiKaydet = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSeviyeMax = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSeviyeMin = new System.Windows.Forms.TextBox();
            this.dgwOnay = new System.Windows.Forms.DataGridView();
            this.fyzMusNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyzmusAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyzmusSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyzVadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyzMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyzFaizOraniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyzSeviyeTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyzVadeSonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyzOnayDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fyzOnaySicilNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFaizYetkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stajFaizDenemeDataSet = new $safeprojectname$.stajFaizDenemeDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMusteriKontrol = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMusteriSoyadKontrol = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtMusteriAdKontrol = new System.Windows.Forms.TextBox();
            this.txtMusteriNoKontrol = new System.Windows.Forms.TextBox();
            this.gbFaizHesap = new System.Windows.Forms.GroupBox();
            this.lblYetkiSeviyeOnay = new System.Windows.Forms.Label();
            this.txtYetkiSeviye = new System.Windows.Forms.TextBox();
            this.txtVadeSonuDeger = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnVadeSonuDeger = new System.Windows.Forms.Button();
            this.txtYetkiSeviyeMax = new System.Windows.Forms.TextBox();
            this.txtYetkiSeviyeMin = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtFaizOrani = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtTalepVade = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grpfaizYetki = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tblMusteriTableAdapter = new $safeprojectname$.musteriDataTableAdapters.tblMusteriTableAdapter();
            this.tblYetkiSeviyesiTableAdapter = new $safeprojectname$.dataSetYetkiSeviyesiTableAdapters.tblYetkiSeviyesiTableAdapter();
            this.tblKullaniciTableAdapter = new $safeprojectname$.kullaniciDataTableAdapters.tblKullaniciTableAdapter();
            this.tblFaizYetkiTableAdapter = new $safeprojectname$.stajFaizDenemeDataSetTableAdapters.tblFaizYetkiTableAdapter();
            this.btnOnayKaydet = new System.Windows.Forms.Button();
            this.cbxOnayDurumu = new System.Windows.Forms.ComboBox();
            this.grpOnay = new System.Windows.Forms.GroupBox();
            this.lblYonetici = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpMusteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriData)).BeginInit();
            this.grpKullanici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciData)).BeginInit();
            this.grpYetkiTanimla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwYetkiSeviye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYetkiSeviyesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetYetkiSeviyesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOnay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFaizYetkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajFaizDenemeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbFaizHesap.SuspendLayout();
            this.grpfaizYetki.SuspendLayout();
            this.grpOnay.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımToolStripMenuItem,
            this.faizYetkiToolStripMenuItem,
            this.onayToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.kullanıcıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımToolStripMenuItem
            // 
            this.tanımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriTanımToolStripMenuItem,
            this.kullanıcıTanımlaToolStripMenuItem,
            this.yetkiTanımlaToolStripMenuItem});
            this.tanımToolStripMenuItem.Name = "tanımToolStripMenuItem";
            this.tanımToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tanımToolStripMenuItem.Text = "Tanım";
            // 
            // müşteriTanımToolStripMenuItem
            // 
            this.müşteriTanımToolStripMenuItem.Name = "müşteriTanımToolStripMenuItem";
            this.müşteriTanımToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.müşteriTanımToolStripMenuItem.Text = "Müşteri Tanımla";
            this.müşteriTanımToolStripMenuItem.Click += new System.EventHandler(this.müşteriTanımToolStripMenuItem_Click);
            // 
            // kullanıcıTanımlaToolStripMenuItem
            // 
            this.kullanıcıTanımlaToolStripMenuItem.Name = "kullanıcıTanımlaToolStripMenuItem";
            this.kullanıcıTanımlaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.kullanıcıTanımlaToolStripMenuItem.Text = "Kullanıcı Tanımla";
            this.kullanıcıTanımlaToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıTanımlaToolStripMenuItem_Click);
            // 
            // yetkiTanımlaToolStripMenuItem
            // 
            this.yetkiTanımlaToolStripMenuItem.Name = "yetkiTanımlaToolStripMenuItem";
            this.yetkiTanımlaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.yetkiTanımlaToolStripMenuItem.Text = "Yetki Tanımla";
            this.yetkiTanımlaToolStripMenuItem.Click += new System.EventHandler(this.yetkiTanımlaToolStripMenuItem_Click);
            // 
            // faizYetkiToolStripMenuItem
            // 
            this.faizYetkiToolStripMenuItem.Name = "faizYetkiToolStripMenuItem";
            this.faizYetkiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.faizYetkiToolStripMenuItem.Text = "Faiz Yetki";
            this.faizYetkiToolStripMenuItem.Click += new System.EventHandler(this.faizYetkiToolStripMenuItem_Click);
            // 
            // onayToolStripMenuItem
            // 
            this.onayToolStripMenuItem.Name = "onayToolStripMenuItem";
            this.onayToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.onayToolStripMenuItem.Text = "Onay";
            this.onayToolStripMenuItem.Click += new System.EventHandler(this.onayToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            this.kullanıcıToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // grpMusteri
            // 
            this.grpMusteri.Controls.Add(this.btnMusteriSil);
            this.grpMusteri.Controls.Add(this.dgwMusteri);
            this.grpMusteri.Controls.Add(this.label1);
            this.grpMusteri.Controls.Add(this.txtMusNo);
            this.grpMusteri.Controls.Add(this.txtMusAd);
            this.grpMusteri.Controls.Add(this.label2);
            this.grpMusteri.Controls.Add(this.btnMusteriKaydet);
            this.grpMusteri.Controls.Add(this.txtMusSoyad);
            this.grpMusteri.Controls.Add(this.label10);
            this.grpMusteri.Location = new System.Drawing.Point(12, 49);
            this.grpMusteri.Name = "grpMusteri";
            this.grpMusteri.Size = new System.Drawing.Size(771, 187);
            this.grpMusteri.TabIndex = 40;
            this.grpMusteri.TabStop = false;
            this.grpMusteri.Text = "Müşteri Tanımla";
            this.grpMusteri.Visible = false;
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Location = new System.Drawing.Point(183, 35);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(75, 23);
            this.btnMusteriSil.TabIndex = 30;
            this.btnMusteriSil.Text = "Müşteri Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // dgwMusteri
            // 
            this.dgwMusteri.AutoGenerateColumns = false;
            this.dgwMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musIDDataGridViewTextBoxColumn,
            this.musNoDataGridViewTextBoxColumn,
            this.musAdiDataGridViewTextBoxColumn,
            this.musSoyadiDataGridViewTextBoxColumn});
            this.dgwMusteri.DataSource = this.tblMusteriBindingSource;
            this.dgwMusteri.Location = new System.Drawing.Point(284, 27);
            this.dgwMusteri.Name = "dgwMusteri";
            this.dgwMusteri.Size = new System.Drawing.Size(460, 130);
            this.dgwMusteri.TabIndex = 29;
            this.dgwMusteri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteri_CellDoubleClick);
            // 
            // musIDDataGridViewTextBoxColumn
            // 
            this.musIDDataGridViewTextBoxColumn.DataPropertyName = "musID";
            this.musIDDataGridViewTextBoxColumn.HeaderText = "musID";
            this.musIDDataGridViewTextBoxColumn.Name = "musIDDataGridViewTextBoxColumn";
            this.musIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musNoDataGridViewTextBoxColumn
            // 
            this.musNoDataGridViewTextBoxColumn.DataPropertyName = "musNo";
            this.musNoDataGridViewTextBoxColumn.HeaderText = "musNo";
            this.musNoDataGridViewTextBoxColumn.Name = "musNoDataGridViewTextBoxColumn";
            // 
            // musAdiDataGridViewTextBoxColumn
            // 
            this.musAdiDataGridViewTextBoxColumn.DataPropertyName = "musAdi";
            this.musAdiDataGridViewTextBoxColumn.HeaderText = "musAdi";
            this.musAdiDataGridViewTextBoxColumn.Name = "musAdiDataGridViewTextBoxColumn";
            // 
            // musSoyadiDataGridViewTextBoxColumn
            // 
            this.musSoyadiDataGridViewTextBoxColumn.DataPropertyName = "musSoyadi";
            this.musSoyadiDataGridViewTextBoxColumn.HeaderText = "musSoyadi";
            this.musSoyadiDataGridViewTextBoxColumn.Name = "musSoyadiDataGridViewTextBoxColumn";
            // 
            // tblMusteriBindingSource
            // 
            this.tblMusteriBindingSource.DataMember = "tblMusteri";
            this.tblMusteriBindingSource.DataSource = this.musteriData;
            // 
            // musteriData
            // 
            this.musteriData.DataSetName = "musteriData";
            this.musteriData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Müşteri No:";
            // 
            // txtMusNo
            // 
            this.txtMusNo.Location = new System.Drawing.Point(77, 37);
            this.txtMusNo.Name = "txtMusNo";
            this.txtMusNo.Size = new System.Drawing.Size(100, 20);
            this.txtMusNo.TabIndex = 9;
            // 
            // txtMusAd
            // 
            this.txtMusAd.Location = new System.Drawing.Point(77, 63);
            this.txtMusAd.Name = "txtMusAd";
            this.txtMusAd.Size = new System.Drawing.Size(100, 20);
            this.txtMusAd.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ad:";
            // 
            // btnMusteriKaydet
            // 
            this.btnMusteriKaydet.Location = new System.Drawing.Point(77, 133);
            this.btnMusteriKaydet.Name = "btnMusteriKaydet";
            this.btnMusteriKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnMusteriKaydet.TabIndex = 13;
            this.btnMusteriKaydet.Text = "Kaydet";
            this.btnMusteriKaydet.UseVisualStyleBackColor = true;
            this.btnMusteriKaydet.Click += new System.EventHandler(this.btnMusteriKaydet_Click);
            // 
            // txtMusSoyad
            // 
            this.txtMusSoyad.Location = new System.Drawing.Point(77, 89);
            this.txtMusSoyad.Name = "txtMusSoyad";
            this.txtMusSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtMusSoyad.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Soyad:";
            // 
            // grpKullanici
            // 
            this.grpKullanici.Controls.Add(this.btnKullaniciSil);
            this.grpKullanici.Controls.Add(this.dgwKullanici);
            this.grpKullanici.Controls.Add(this.btnKullaniciTanimla);
            this.grpKullanici.Controls.Add(this.chkYonetici);
            this.grpKullanici.Controls.Add(this.label12);
            this.grpKullanici.Controls.Add(this.label5);
            this.grpKullanici.Controls.Add(this.label6);
            this.grpKullanici.Controls.Add(this.txtKullaniciSifre);
            this.grpKullanici.Controls.Add(this.txtSicilNo);
            this.grpKullanici.Location = new System.Drawing.Point(12, 49);
            this.grpKullanici.Name = "grpKullanici";
            this.grpKullanici.Size = new System.Drawing.Size(741, 222);
            this.grpKullanici.TabIndex = 44;
            this.grpKullanici.TabStop = false;
            this.grpKullanici.Text = "Kullanıcı Tanımla";
            this.grpKullanici.Visible = false;
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Location = new System.Drawing.Point(204, 22);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(75, 23);
            this.btnKullaniciSil.TabIndex = 47;
            this.btnKullaniciSil.Text = "Kullanici Sil";
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // dgwKullanici
            // 
            this.dgwKullanici.AllowUserToAddRows = false;
            this.dgwKullanici.AllowUserToDeleteRows = false;
            this.dgwKullanici.AutoGenerateColumns = false;
            this.dgwKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKullanici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kulIDDataGridViewTextBoxColumn,
            this.kulSicilNoDataGridViewTextBoxColumn,
            this.kulSifreDataGridViewTextBoxColumn,
            this.kulYoneticiDataGridViewCheckBoxColumn});
            this.dgwKullanici.DataSource = this.tblKullaniciBindingSource;
            this.dgwKullanici.Location = new System.Drawing.Point(311, 16);
            this.dgwKullanici.Name = "dgwKullanici";
            this.dgwKullanici.ReadOnly = true;
            this.dgwKullanici.Size = new System.Drawing.Size(424, 150);
            this.dgwKullanici.TabIndex = 46;
            this.dgwKullanici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKullanici_CellDoubleClick);
            // 
            // kulIDDataGridViewTextBoxColumn
            // 
            this.kulIDDataGridViewTextBoxColumn.DataPropertyName = "kulID";
            this.kulIDDataGridViewTextBoxColumn.HeaderText = "kulID";
            this.kulIDDataGridViewTextBoxColumn.Name = "kulIDDataGridViewTextBoxColumn";
            this.kulIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kulSicilNoDataGridViewTextBoxColumn
            // 
            this.kulSicilNoDataGridViewTextBoxColumn.DataPropertyName = "kulSicilNo";
            this.kulSicilNoDataGridViewTextBoxColumn.HeaderText = "kulSicilNo";
            this.kulSicilNoDataGridViewTextBoxColumn.Name = "kulSicilNoDataGridViewTextBoxColumn";
            this.kulSicilNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kulSifreDataGridViewTextBoxColumn
            // 
            this.kulSifreDataGridViewTextBoxColumn.DataPropertyName = "kulSifre";
            this.kulSifreDataGridViewTextBoxColumn.HeaderText = "kulSifre";
            this.kulSifreDataGridViewTextBoxColumn.Name = "kulSifreDataGridViewTextBoxColumn";
            this.kulSifreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kulYoneticiDataGridViewCheckBoxColumn
            // 
            this.kulYoneticiDataGridViewCheckBoxColumn.DataPropertyName = "kulYonetici";
            this.kulYoneticiDataGridViewCheckBoxColumn.HeaderText = "kulYonetici";
            this.kulYoneticiDataGridViewCheckBoxColumn.Name = "kulYoneticiDataGridViewCheckBoxColumn";
            this.kulYoneticiDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // tblKullaniciBindingSource
            // 
            this.tblKullaniciBindingSource.DataMember = "tblKullanici";
            this.tblKullaniciBindingSource.DataSource = this.kullaniciData;
            // 
            // kullaniciData
            // 
            this.kullaniciData.DataSetName = "kullaniciData";
            this.kullaniciData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnKullaniciTanimla
            // 
            this.btnKullaniciTanimla.Location = new System.Drawing.Point(77, 133);
            this.btnKullaniciTanimla.Name = "btnKullaniciTanimla";
            this.btnKullaniciTanimla.Size = new System.Drawing.Size(75, 23);
            this.btnKullaniciTanimla.TabIndex = 45;
            this.btnKullaniciTanimla.Text = "Kaydet";
            this.btnKullaniciTanimla.UseVisualStyleBackColor = true;
            this.btnKullaniciTanimla.Click += new System.EventHandler(this.btnKullaniciTanimla_Click);
            // 
            // chkYonetici
            // 
            this.chkYonetici.AutoSize = true;
            this.chkYonetici.Location = new System.Drawing.Point(98, 83);
            this.chkYonetici.Name = "chkYonetici";
            this.chkYonetici.Size = new System.Drawing.Size(15, 14);
            this.chkYonetici.TabIndex = 44;
            this.chkYonetici.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Yönetici mi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Sicil No:";
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(98, 53);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciSifre.TabIndex = 40;
            // 
            // txtSicilNo
            // 
            this.txtSicilNo.Location = new System.Drawing.Point(98, 24);
            this.txtSicilNo.Name = "txtSicilNo";
            this.txtSicilNo.Size = new System.Drawing.Size(100, 20);
            this.txtSicilNo.TabIndex = 39;
            // 
            // grpYetkiTanimla
            // 
            this.grpYetkiTanimla.Controls.Add(this.yetkiSeviyesiSil);
            this.grpYetkiTanimla.Controls.Add(this.dgwYetkiSeviye);
            this.grpYetkiTanimla.Controls.Add(this.btnYetkiSeviyesiKaydet);
            this.grpYetkiTanimla.Controls.Add(this.label11);
            this.grpYetkiTanimla.Controls.Add(this.txtSeviyeMax);
            this.grpYetkiTanimla.Controls.Add(this.comboBox1);
            this.grpYetkiTanimla.Controls.Add(this.label3);
            this.grpYetkiTanimla.Controls.Add(this.label4);
            this.grpYetkiTanimla.Controls.Add(this.txtSeviyeMin);
            this.grpYetkiTanimla.Location = new System.Drawing.Point(12, 49);
            this.grpYetkiTanimla.Name = "grpYetkiTanimla";
            this.grpYetkiTanimla.Size = new System.Drawing.Size(743, 179);
            this.grpYetkiTanimla.TabIndex = 45;
            this.grpYetkiTanimla.TabStop = false;
            this.grpYetkiTanimla.Text = "Yetki Seviyesi";
            this.grpYetkiTanimla.Visible = false;
            // 
            // yetkiSeviyesiSil
            // 
            this.yetkiSeviyesiSil.Location = new System.Drawing.Point(212, 23);
            this.yetkiSeviyesiSil.Name = "yetkiSeviyesiSil";
            this.yetkiSeviyesiSil.Size = new System.Drawing.Size(75, 23);
            this.yetkiSeviyesiSil.TabIndex = 46;
            this.yetkiSeviyesiSil.Text = "Sil";
            this.yetkiSeviyesiSil.UseVisualStyleBackColor = true;
            this.yetkiSeviyesiSil.Click += new System.EventHandler(this.yetkiSeviyesiSil_Click);
            // 
            // dgwYetkiSeviye
            // 
            this.dgwYetkiSeviye.AllowUserToAddRows = false;
            this.dgwYetkiSeviye.AllowUserToDeleteRows = false;
            this.dgwYetkiSeviye.AutoGenerateColumns = false;
            this.dgwYetkiSeviye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwYetkiSeviye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yetkiIDDataGridViewTextBoxColumn,
            this.seviyeTipDataGridViewTextBoxColumn,
            this.seviyeMinDataGridViewTextBoxColumn,
            this.seviyeMaxDataGridViewTextBoxColumn});
            this.dgwYetkiSeviye.DataSource = this.tblYetkiSeviyesiBindingSource;
            this.dgwYetkiSeviye.Location = new System.Drawing.Point(293, 19);
            this.dgwYetkiSeviye.Name = "dgwYetkiSeviye";
            this.dgwYetkiSeviye.ReadOnly = true;
            this.dgwYetkiSeviye.Size = new System.Drawing.Size(448, 130);
            this.dgwYetkiSeviye.TabIndex = 45;
            this.dgwYetkiSeviye.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwYetkiSeviye_CellDoubleClick);
            // 
            // yetkiIDDataGridViewTextBoxColumn
            // 
            this.yetkiIDDataGridViewTextBoxColumn.DataPropertyName = "yetkiID";
            this.yetkiIDDataGridViewTextBoxColumn.HeaderText = "yetkiID";
            this.yetkiIDDataGridViewTextBoxColumn.Name = "yetkiIDDataGridViewTextBoxColumn";
            this.yetkiIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seviyeTipDataGridViewTextBoxColumn
            // 
            this.seviyeTipDataGridViewTextBoxColumn.DataPropertyName = "seviyeTip";
            this.seviyeTipDataGridViewTextBoxColumn.HeaderText = "seviyeTip";
            this.seviyeTipDataGridViewTextBoxColumn.Name = "seviyeTipDataGridViewTextBoxColumn";
            this.seviyeTipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seviyeMinDataGridViewTextBoxColumn
            // 
            this.seviyeMinDataGridViewTextBoxColumn.DataPropertyName = "seviyeMin";
            this.seviyeMinDataGridViewTextBoxColumn.HeaderText = "seviyeMin";
            this.seviyeMinDataGridViewTextBoxColumn.Name = "seviyeMinDataGridViewTextBoxColumn";
            this.seviyeMinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seviyeMaxDataGridViewTextBoxColumn
            // 
            this.seviyeMaxDataGridViewTextBoxColumn.DataPropertyName = "seviyeMax";
            this.seviyeMaxDataGridViewTextBoxColumn.HeaderText = "seviyeMax";
            this.seviyeMaxDataGridViewTextBoxColumn.Name = "seviyeMaxDataGridViewTextBoxColumn";
            this.seviyeMaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblYetkiSeviyesiBindingSource
            // 
            this.tblYetkiSeviyesiBindingSource.DataMember = "tblYetkiSeviyesi";
            this.tblYetkiSeviyesiBindingSource.DataSource = this.dataSetYetkiSeviyesi;
            // 
            // dataSetYetkiSeviyesi
            // 
            this.dataSetYetkiSeviyesi.DataSetName = "dataSetYetkiSeviyesi";
            this.dataSetYetkiSeviyesi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnYetkiSeviyesiKaydet
            // 
            this.btnYetkiSeviyesiKaydet.Location = new System.Drawing.Point(77, 133);
            this.btnYetkiSeviyesiKaydet.Name = "btnYetkiSeviyesiKaydet";
            this.btnYetkiSeviyesiKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnYetkiSeviyesiKaydet.TabIndex = 44;
            this.btnYetkiSeviyesiKaydet.Text = "Kaydet";
            this.btnYetkiSeviyesiKaydet.UseVisualStyleBackColor = true;
            this.btnYetkiSeviyesiKaydet.Click += new System.EventHandler(this.btnYetkiSeviyesiKaydet_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Seviye Max:";
            // 
            // txtSeviyeMax
            // 
            this.txtSeviyeMax.Location = new System.Drawing.Point(98, 76);
            this.txtSeviyeMax.Name = "txtSeviyeMax";
            this.txtSeviyeMax.Size = new System.Drawing.Size(100, 20);
            this.txtSeviyeMax.TabIndex = 42;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Şube (0)",
            "Bölge (1)",
            "Birim (2)"});
            this.comboBox1.Location = new System.Drawing.Point(98, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Seviye Min:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Seviye Tip:";
            // 
            // txtSeviyeMin
            // 
            this.txtSeviyeMin.Location = new System.Drawing.Point(98, 50);
            this.txtSeviyeMin.Name = "txtSeviyeMin";
            this.txtSeviyeMin.Size = new System.Drawing.Size(100, 20);
            this.txtSeviyeMin.TabIndex = 38;
            // 
            // dgwOnay
            // 
            this.dgwOnay.AllowUserToAddRows = false;
            this.dgwOnay.AllowUserToDeleteRows = false;
            this.dgwOnay.AutoGenerateColumns = false;
            this.dgwOnay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOnay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fyzMusNoDataGridViewTextBoxColumn,
            this.fyzmusAdDataGridViewTextBoxColumn,
            this.fyzmusSoyadDataGridViewTextBoxColumn,
            this.fyzVadeDataGridViewTextBoxColumn,
            this.fyzMiktarDataGridViewTextBoxColumn,
            this.fyzFaizOraniDataGridViewTextBoxColumn,
            this.fyzSeviyeTipDataGridViewTextBoxColumn,
            this.fyzVadeSonuDataGridViewTextBoxColumn,
            this.fyzOnayDurumDataGridViewTextBoxColumn,
            this.fyzOnaySicilNoDataGridViewTextBoxColumn});
            this.dgwOnay.DataSource = this.tblFaizYetkiBindingSource;
            this.dgwOnay.Location = new System.Drawing.Point(0, 166);
            this.dgwOnay.Name = "dgwOnay";
            this.dgwOnay.ReadOnly = true;
            this.dgwOnay.Size = new System.Drawing.Size(900, 150);
            this.dgwOnay.TabIndex = 48;
            this.dgwOnay.Visible = false;
            this.dgwOnay.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOnay_CellDoubleClick);
            // 
            // fyzMusNoDataGridViewTextBoxColumn
            // 
            this.fyzMusNoDataGridViewTextBoxColumn.DataPropertyName = "fyzMusNo";
            this.fyzMusNoDataGridViewTextBoxColumn.HeaderText = "fyzMusNo";
            this.fyzMusNoDataGridViewTextBoxColumn.Name = "fyzMusNoDataGridViewTextBoxColumn";
            this.fyzMusNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fyzMusNoDataGridViewTextBoxColumn.Width = 50;
            // 
            // fyzmusAdDataGridViewTextBoxColumn
            // 
            this.fyzmusAdDataGridViewTextBoxColumn.DataPropertyName = "fyzmusAd";
            this.fyzmusAdDataGridViewTextBoxColumn.HeaderText = "fyzmusAd";
            this.fyzmusAdDataGridViewTextBoxColumn.Name = "fyzmusAdDataGridViewTextBoxColumn";
            this.fyzmusAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fyzmusSoyadDataGridViewTextBoxColumn
            // 
            this.fyzmusSoyadDataGridViewTextBoxColumn.DataPropertyName = "fyzmusSoyad";
            this.fyzmusSoyadDataGridViewTextBoxColumn.HeaderText = "fyzmusSoyad";
            this.fyzmusSoyadDataGridViewTextBoxColumn.Name = "fyzmusSoyadDataGridViewTextBoxColumn";
            this.fyzmusSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fyzVadeDataGridViewTextBoxColumn
            // 
            this.fyzVadeDataGridViewTextBoxColumn.DataPropertyName = "fyzVade";
            this.fyzVadeDataGridViewTextBoxColumn.HeaderText = "fyzVade";
            this.fyzVadeDataGridViewTextBoxColumn.Name = "fyzVadeDataGridViewTextBoxColumn";
            this.fyzVadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fyzVadeDataGridViewTextBoxColumn.Width = 50;
            // 
            // fyzMiktarDataGridViewTextBoxColumn
            // 
            this.fyzMiktarDataGridViewTextBoxColumn.DataPropertyName = "fyzMiktar";
            this.fyzMiktarDataGridViewTextBoxColumn.HeaderText = "fyzMiktar";
            this.fyzMiktarDataGridViewTextBoxColumn.Name = "fyzMiktarDataGridViewTextBoxColumn";
            this.fyzMiktarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fyzFaizOraniDataGridViewTextBoxColumn
            // 
            this.fyzFaizOraniDataGridViewTextBoxColumn.DataPropertyName = "fyzFaizOrani";
            this.fyzFaizOraniDataGridViewTextBoxColumn.HeaderText = "fyzFaizOrani";
            this.fyzFaizOraniDataGridViewTextBoxColumn.Name = "fyzFaizOraniDataGridViewTextBoxColumn";
            this.fyzFaizOraniDataGridViewTextBoxColumn.ReadOnly = true;
            this.fyzFaizOraniDataGridViewTextBoxColumn.Width = 50;
            // 
            // fyzSeviyeTipDataGridViewTextBoxColumn
            // 
            this.fyzSeviyeTipDataGridViewTextBoxColumn.DataPropertyName = "fyzSeviyeTip";
            this.fyzSeviyeTipDataGridViewTextBoxColumn.HeaderText = "fyzSeviyeTip";
            this.fyzSeviyeTipDataGridViewTextBoxColumn.Name = "fyzSeviyeTipDataGridViewTextBoxColumn";
            this.fyzSeviyeTipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fyzVadeSonuDataGridViewTextBoxColumn
            // 
            this.fyzVadeSonuDataGridViewTextBoxColumn.DataPropertyName = "fyzVadeSonu";
            this.fyzVadeSonuDataGridViewTextBoxColumn.HeaderText = "fyzVadeSonu";
            this.fyzVadeSonuDataGridViewTextBoxColumn.Name = "fyzVadeSonuDataGridViewTextBoxColumn";
            this.fyzVadeSonuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fyzOnayDurumDataGridViewTextBoxColumn
            // 
            this.fyzOnayDurumDataGridViewTextBoxColumn.DataPropertyName = "fyzOnayDurum";
            this.fyzOnayDurumDataGridViewTextBoxColumn.HeaderText = "fyzOnayDurum";
            this.fyzOnayDurumDataGridViewTextBoxColumn.Name = "fyzOnayDurumDataGridViewTextBoxColumn";
            this.fyzOnayDurumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fyzOnaySicilNoDataGridViewTextBoxColumn
            // 
            this.fyzOnaySicilNoDataGridViewTextBoxColumn.DataPropertyName = "fyzOnaySicilNo";
            this.fyzOnaySicilNoDataGridViewTextBoxColumn.HeaderText = "fyzOnaySicilNo";
            this.fyzOnaySicilNoDataGridViewTextBoxColumn.Name = "fyzOnaySicilNoDataGridViewTextBoxColumn";
            this.fyzOnaySicilNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblFaizYetkiBindingSource
            // 
            this.tblFaizYetkiBindingSource.DataMember = "tblFaizYetki";
            this.tblFaizYetkiBindingSource.DataSource = this.stajFaizDenemeDataSet;
            // 
            // stajFaizDenemeDataSet
            // 
            this.stajFaizDenemeDataSet.DataSetName = "stajFaizDenemeDataSet";
            this.stajFaizDenemeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMusteriKontrol);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtMusteriSoyadKontrol);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtMusteriAdKontrol);
            this.groupBox1.Controls.Add(this.txtMusteriNoKontrol);
            this.groupBox1.Location = new System.Drawing.Point(6, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 131);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Kontrol";
            // 
            // btnMusteriKontrol
            // 
            this.btnMusteriKontrol.Location = new System.Drawing.Point(189, 33);
            this.btnMusteriKontrol.Name = "btnMusteriKontrol";
            this.btnMusteriKontrol.Size = new System.Drawing.Size(75, 23);
            this.btnMusteriKontrol.TabIndex = 36;
            this.btnMusteriKontrol.Text = "Kontrol Et";
            this.btnMusteriKontrol.UseVisualStyleBackColor = true;
            this.btnMusteriKontrol.Click += new System.EventHandler(this.btnMusteriKontrol_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Ad:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Soyad:";
            // 
            // txtMusteriSoyadKontrol
            // 
            this.txtMusteriSoyadKontrol.Location = new System.Drawing.Point(77, 88);
            this.txtMusteriSoyadKontrol.Name = "txtMusteriSoyadKontrol";
            this.txtMusteriSoyadKontrol.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriSoyadKontrol.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Müşteri No:";
            // 
            // txtMusteriAdKontrol
            // 
            this.txtMusteriAdKontrol.Location = new System.Drawing.Point(77, 62);
            this.txtMusteriAdKontrol.Name = "txtMusteriAdKontrol";
            this.txtMusteriAdKontrol.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriAdKontrol.TabIndex = 30;
            // 
            // txtMusteriNoKontrol
            // 
            this.txtMusteriNoKontrol.Location = new System.Drawing.Point(77, 36);
            this.txtMusteriNoKontrol.Name = "txtMusteriNoKontrol";
            this.txtMusteriNoKontrol.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriNoKontrol.TabIndex = 29;
            // 
            // gbFaizHesap
            // 
            this.gbFaizHesap.Controls.Add(this.lblYetkiSeviyeOnay);
            this.gbFaizHesap.Controls.Add(this.txtYetkiSeviye);
            this.gbFaizHesap.Controls.Add(this.txtVadeSonuDeger);
            this.gbFaizHesap.Controls.Add(this.label20);
            this.gbFaizHesap.Controls.Add(this.btnVadeSonuDeger);
            this.gbFaizHesap.Controls.Add(this.txtYetkiSeviyeMax);
            this.gbFaizHesap.Controls.Add(this.txtYetkiSeviyeMin);
            this.gbFaizHesap.Controls.Add(this.label21);
            this.gbFaizHesap.Controls.Add(this.label22);
            this.gbFaizHesap.Controls.Add(this.txtFaizOrani);
            this.gbFaizHesap.Controls.Add(this.txtMiktar);
            this.gbFaizHesap.Controls.Add(this.txtTalepVade);
            this.gbFaizHesap.Controls.Add(this.label23);
            this.gbFaizHesap.Controls.Add(this.label24);
            this.gbFaizHesap.Controls.Add(this.label25);
            this.gbFaizHesap.Controls.Add(this.label26);
            this.gbFaizHesap.Location = new System.Drawing.Point(6, 165);
            this.gbFaizHesap.Name = "gbFaizHesap";
            this.gbFaizHesap.Size = new System.Drawing.Size(393, 316);
            this.gbFaizHesap.TabIndex = 46;
            this.gbFaizHesap.TabStop = false;
            this.gbFaizHesap.Text = "Faiz İşlemleri";
            // 
            // lblYetkiSeviyeOnay
            // 
            this.lblYetkiSeviyeOnay.AutoSize = true;
            this.lblYetkiSeviyeOnay.Location = new System.Drawing.Point(231, 151);
            this.lblYetkiSeviyeOnay.Name = "lblYetkiSeviyeOnay";
            this.lblYetkiSeviyeOnay.Size = new System.Drawing.Size(0, 13);
            this.lblYetkiSeviyeOnay.TabIndex = 49;
            // 
            // txtYetkiSeviye
            // 
            this.txtYetkiSeviye.Location = new System.Drawing.Point(109, 148);
            this.txtYetkiSeviye.Name = "txtYetkiSeviye";
            this.txtYetkiSeviye.ReadOnly = true;
            this.txtYetkiSeviye.Size = new System.Drawing.Size(100, 20);
            this.txtYetkiSeviye.TabIndex = 46;
            // 
            // txtVadeSonuDeger
            // 
            this.txtVadeSonuDeger.Location = new System.Drawing.Point(109, 248);
            this.txtVadeSonuDeger.Name = "txtVadeSonuDeger";
            this.txtVadeSonuDeger.ReadOnly = true;
            this.txtVadeSonuDeger.Size = new System.Drawing.Size(100, 20);
            this.txtVadeSonuDeger.TabIndex = 45;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 251);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 13);
            this.label20.TabIndex = 44;
            this.label20.Text = "Vade Sonu Değer";
            // 
            // btnVadeSonuDeger
            // 
            this.btnVadeSonuDeger.Location = new System.Drawing.Point(188, 197);
            this.btnVadeSonuDeger.Name = "btnVadeSonuDeger";
            this.btnVadeSonuDeger.Size = new System.Drawing.Size(75, 23);
            this.btnVadeSonuDeger.TabIndex = 43;
            this.btnVadeSonuDeger.Text = "Hesapla";
            this.btnVadeSonuDeger.UseVisualStyleBackColor = true;
            this.btnVadeSonuDeger.Click += new System.EventHandler(this.btnVadeSonuDeger_Click);
            // 
            // txtYetkiSeviyeMax
            // 
            this.txtYetkiSeviyeMax.Location = new System.Drawing.Point(123, 199);
            this.txtYetkiSeviyeMax.Name = "txtYetkiSeviyeMax";
            this.txtYetkiSeviyeMax.ReadOnly = true;
            this.txtYetkiSeviyeMax.Size = new System.Drawing.Size(30, 20);
            this.txtYetkiSeviyeMax.TabIndex = 42;
            // 
            // txtYetkiSeviyeMin
            // 
            this.txtYetkiSeviyeMin.Location = new System.Drawing.Point(36, 199);
            this.txtYetkiSeviyeMin.Name = "txtYetkiSeviyeMin";
            this.txtYetkiSeviyeMin.ReadOnly = true;
            this.txtYetkiSeviyeMin.Size = new System.Drawing.Size(30, 20);
            this.txtYetkiSeviyeMin.TabIndex = 41;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(90, 202);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "Max";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 202);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "Min";
            // 
            // txtFaizOrani
            // 
            this.txtFaizOrani.Location = new System.Drawing.Point(109, 114);
            this.txtFaizOrani.Name = "txtFaizOrani";
            this.txtFaizOrani.Size = new System.Drawing.Size(100, 20);
            this.txtFaizOrani.TabIndex = 37;
            this.txtFaizOrani.TextChanged += new System.EventHandler(this.txtFaizOrani_TextChanged);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(109, 83);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtMiktar.TabIndex = 36;
            // 
            // txtTalepVade
            // 
            this.txtTalepVade.Location = new System.Drawing.Point(109, 42);
            this.txtTalepVade.Name = "txtTalepVade";
            this.txtTalepVade.Size = new System.Drawing.Size(100, 20);
            this.txtTalepVade.TabIndex = 30;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 151);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 13);
            this.label23.TabIndex = 35;
            this.label23.Text = "Yetki Seviye";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 117);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 13);
            this.label24.TabIndex = 34;
            this.label24.Text = "Faiz Oranı";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 86);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 13);
            this.label25.TabIndex = 33;
            this.label25.Text = "Miktar";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 42);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(97, 26);
            this.label26.TabIndex = 32;
            this.label26.Text = "Talep Edilen Vade \r\n(Gün)";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(194, 495);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 38;
            this.button4.Text = "Temizle";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(48, 495);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 37;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // grpfaizYetki
            // 
            this.grpfaizYetki.Controls.Add(this.groupBox1);
            this.grpfaizYetki.Controls.Add(this.button4);
            this.grpfaizYetki.Controls.Add(this.gbFaizHesap);
            this.grpfaizYetki.Controls.Add(this.btnKaydet);
            this.grpfaizYetki.Location = new System.Drawing.Point(12, 47);
            this.grpfaizYetki.Name = "grpfaizYetki";
            this.grpfaizYetki.Size = new System.Drawing.Size(405, 534);
            this.grpfaizYetki.TabIndex = 47;
            this.grpfaizYetki.TabStop = false;
            this.grpfaizYetki.Text = "Faiz Yetki İşlemleri";
            this.grpfaizYetki.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(552, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // tblMusteriTableAdapter
            // 
            this.tblMusteriTableAdapter.ClearBeforeFill = true;
            // 
            // tblYetkiSeviyesiTableAdapter
            // 
            this.tblYetkiSeviyesiTableAdapter.ClearBeforeFill = true;
            // 
            // tblKullaniciTableAdapter
            // 
            this.tblKullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // tblFaizYetkiTableAdapter
            // 
            this.tblFaizYetkiTableAdapter.ClearBeforeFill = true;
            // 
            // btnOnayKaydet
            // 
            this.btnOnayKaydet.Location = new System.Drawing.Point(170, 28);
            this.btnOnayKaydet.Name = "btnOnayKaydet";
            this.btnOnayKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnOnayKaydet.TabIndex = 49;
            this.btnOnayKaydet.Text = "Kaydet";
            this.btnOnayKaydet.UseVisualStyleBackColor = true;
            this.btnOnayKaydet.Click += new System.EventHandler(this.btnOnayKaydet_Click);
            // 
            // cbxOnayDurumu
            // 
            this.cbxOnayDurumu.FormattingEnabled = true;
            this.cbxOnayDurumu.Items.AddRange(new object[] {
            "Onayla",
            "Reddet"});
            this.cbxOnayDurumu.Location = new System.Drawing.Point(6, 30);
            this.cbxOnayDurumu.Name = "cbxOnayDurumu";
            this.cbxOnayDurumu.Size = new System.Drawing.Size(121, 21);
            this.cbxOnayDurumu.TabIndex = 50;
            // 
            // grpOnay
            // 
            this.grpOnay.Controls.Add(this.cbxOnayDurumu);
            this.grpOnay.Controls.Add(this.btnOnayKaydet);
            this.grpOnay.Location = new System.Drawing.Point(531, 326);
            this.grpOnay.Name = "grpOnay";
            this.grpOnay.Size = new System.Drawing.Size(252, 100);
            this.grpOnay.TabIndex = 51;
            this.grpOnay.TabStop = false;
            this.grpOnay.Text = "grpOnay";
            // 
            // lblYonetici
            // 
            this.lblYonetici.AutoSize = true;
            this.lblYonetici.Location = new System.Drawing.Point(551, 514);
            this.lblYonetici.Name = "lblYonetici";
            this.lblYonetici.Size = new System.Drawing.Size(35, 13);
            this.lblYonetici.TabIndex = 52;
            this.lblYonetici.Text = "label8";
            this.lblYonetici.Visible = false;
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 627);
            this.Controls.Add(this.lblYonetici);
            this.Controls.Add(this.grpOnay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgwOnay);
            this.Controls.Add(this.grpKullanici);
            this.Controls.Add(this.grpMusteri);
            this.Controls.Add(this.grpYetkiTanimla);
            this.Controls.Add(this.grpfaizYetki);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaMenu";
            this.Text = "AnaMenu";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpMusteri.ResumeLayout(false);
            this.grpMusteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriData)).EndInit();
            this.grpKullanici.ResumeLayout(false);
            this.grpKullanici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciData)).EndInit();
            this.grpYetkiTanimla.ResumeLayout(false);
            this.grpYetkiTanimla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwYetkiSeviye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYetkiSeviyesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetYetkiSeviyesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOnay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFaizYetkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stajFaizDenemeDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFaizHesap.ResumeLayout(false);
            this.gbFaizHesap.PerformLayout();
            this.grpfaizYetki.ResumeLayout(false);
            this.grpOnay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriTanımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faizYetkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusNo;
        private System.Windows.Forms.TextBox txtMusAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMusteriKaydet;
        private System.Windows.Forms.TextBox txtMusSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnYetkiSeviyesiKaydet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSeviyeMax;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSeviyeMin;
        private System.Windows.Forms.Button btnKullaniciTanimla;
        private System.Windows.Forms.CheckBox chkYonetici;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.TextBox txtSicilNo;
        private System.Windows.Forms.Button btnMusteriKontrol;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMusteriSoyadKontrol;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMusteriAdKontrol;
        private System.Windows.Forms.TextBox txtMusteriNoKontrol;
        private System.Windows.Forms.TextBox txtVadeSonuDeger;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnVadeSonuDeger;
        private System.Windows.Forms.TextBox txtYetkiSeviyeMax;
        private System.Windows.Forms.TextBox txtYetkiSeviyeMin;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtFaizOrani;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtTalepVade;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.GroupBox grpMusteri;
        public System.Windows.Forms.GroupBox grpKullanici;
        public System.Windows.Forms.GroupBox grpYetkiTanimla;
        public System.Windows.Forms.GroupBox grpfaizYetki;
        public System.Windows.Forms.DataGridView dgwOnay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbFaizHesap;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.ToolStripMenuItem kullanıcıTanımlaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem yetkiTanımlaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem onayToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgwMusteri;
        private musteriData musteriData;
        private System.Windows.Forms.BindingSource tblMusteriBindingSource;
        private musteriDataTableAdapters.tblMusteriTableAdapter tblMusteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.DataGridView dgwYetkiSeviye;
        private dataSetYetkiSeviyesi dataSetYetkiSeviyesi;
        private System.Windows.Forms.BindingSource tblYetkiSeviyesiBindingSource;
        private dataSetYetkiSeviyesiTableAdapters.tblYetkiSeviyesiTableAdapter tblYetkiSeviyesiTableAdapter;
        public System.Windows.Forms.Button yetkiSeviyesiSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seviyeTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seviyeMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seviyeMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgwKullanici;
        private kullaniciData kullaniciData;
        private System.Windows.Forms.BindingSource tblKullaniciBindingSource;
        private kullaniciDataTableAdapters.tblKullaniciTableAdapter tblKullaniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kulIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kulSicilNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kulSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kulYoneticiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.TextBox txtYetkiSeviye;
        public System.Windows.Forms.Label lblYetkiSeviyeOnay;
        private stajFaizDenemeDataSet stajFaizDenemeDataSet;
        private System.Windows.Forms.BindingSource tblFaizYetkiBindingSource;
        private stajFaizDenemeDataSetTableAdapters.tblFaizYetkiTableAdapter tblFaizYetkiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyzMusNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyzmusAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyzmusSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyzVadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyzMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyzFaizOraniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyzSeviyeTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyzVadeSonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyzOnayDurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fyzOnaySicilNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOnayKaydet;
        private System.Windows.Forms.ComboBox cbxOnayDurumu;
        private System.Windows.Forms.GroupBox grpOnay;
        public System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
        public System.Windows.Forms.Label lblYonetici;
    }
}