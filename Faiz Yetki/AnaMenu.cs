using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class AnaMenu : Form
    {
        
        public static string yonetici; //Yönetici girişi yapılıp yapılmadığını kontrol etmek için
        public static int sicilNo;
        public static int musteriNo;

        public static int doubleClickDgw = 0;

        public AnaMenu()
        {
            InitializeComponent();
            

        }

        

        public void grupVisible() //Tek ekranda birden fazla grup olduğu için biri gösterilirken diğer hepsini görünmez yapmak için
        {
            
            grpKullanici.Visible = false;
            grpMusteri.Visible = false;
            grpYetkiTanimla.Visible = false;
            grpfaizYetki.Visible = false;
            dgwOnay.Visible = false;
            grpOnay.Visible = false;           

            
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e) //Çıkış yaparken giriş sayfasına atması için
        {
            this.Hide();
            Giris giris = new Giris();
            giris.Visible = true;

            
        }

        private void müşteriTanımToolStripMenuItem_Click(object sender, EventArgs e) //Önce bütün grubu görünmez yapıyor
        {                                                                            //Sonra Müşteri grubunu gösteriyor
            grupVisible();

            grpMusteri.Visible = true;


        }

        private void kullanıcıTanımlaToolStripMenuItem_Click(object sender, EventArgs e)  //Önce bütün grubu görünmez yapıyor
        {                                                                                 //Sonra kullanıcı grubunu görünür yapıyor
            grupVisible();

            grpKullanici.Visible = true;
        }

        private void yetkiTanımlaToolStripMenuItem_Click(object sender, EventArgs e)    //Önce bütün grubu görünmez yapıyor
        {                                                                               //Sonra Yetki tanımlama grubunu görünür yapıyor
            grupVisible();

            grpYetkiTanimla.Visible = true;
        }

        private void faizYetkiToolStripMenuItem_Click(object sender, EventArgs e)     //Önce bütün grubu görünmez yapıyor
        {                                                                             //Sonra Faiz yetki grubunu görünür yapıyor
            grupVisible();

            grpfaizYetki.Visible = true;

        }

        private void onayToolStripMenuItem_Click(object sender, EventArgs e)        //Önce bütün grubu görünmez yapıyor
        {                                                                           //Sonra onay grubunu göürünür yapıyor
            grupVisible();

            dgwOnay.Visible = true;
        }

        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
           
            int a = 0; //Kaydın başırılı olup olmadığını tutabilmek için

            SqlConnection con = new SqlConnection("Server = .\\; Database = stajFaizDeneme; Trusted_Connection = True; MultipleActiveResultSets = True"); //Connection String
            
            con.Open(); //Veritabanı bağlantısı açıldı

            try
            {
                
                SqlCommand cmd = con.CreateCommand(); //Komut oluşturuluyor. Store procedure'ü belirtmek için
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FYZ_I_musEkle";

                cmd.Parameters.AddWithValue("@musNo", Convert.ToInt32(txtMusNo.Text));  //Store procedure'de oluşturulan değişkenlere
                cmd.Parameters.AddWithValue("@musAdi", txtMusAd.Text);                  //Textboxlarda oluşturulan değerler atanıyor.
                cmd.Parameters.AddWithValue("@musSoyadi", txtMusSoyad.Text);




                cmd.ExecuteNonQuery();                                                  //Store procedure çalıştırılıp ekleme işleminin yapması sağlanıyor
                this.tblMusteriTableAdapter.Fill(this.musteriData.tblMusteri);          //Datagridview'ı yenilemek için
                con.Close();                                                            //Veritabanı bağlantısı kapatıldı
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + a++);                                      //Hata varsa hata mesajı gösteriliyor ve doğru giriş 
                                                                                        //yapılmadığını anlayabilmek için a arttırılıyor
            }

            if (a == 0) { MessageBox.Show("Kayıt başarıyla oluşturuldu"); }             //a eğer arttırılmamışsa catch'e girmemiş demektir ve kayıt başarılıdır.

        }   //Müşteri kaydı alıyor

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stajFaizDenemeDataSet.tblFaizYetki' table. You can move, or remove it, as needed.
            this.tblFaizYetkiTableAdapter.Fill(this.stajFaizDenemeDataSet.tblFaizYetki);
            // TODO: This line of code loads data into the 'kullaniciData.tblKullanici' table. You can move, or remove it, as needed.
            this.tblKullaniciTableAdapter.Fill(this.kullaniciData.tblKullanici);
            // TODO: This line of code loads data into the 'dataSetYetkiSeviyesi.tblYetkiSeviyesi' table. You can move, or remove it, as needed.
            this.tblYetkiSeviyesiTableAdapter.Fill(this.dataSetYetkiSeviyesi.tblYetkiSeviyesi);
            // TODO: This line of code loads data into the 'musteriData.tblMusteri' table. You can move, or remove it, as needed.
            this.tblMusteriTableAdapter.Fill(this.musteriData.tblMusteri); //Datagridview ı doldurmak için ana menü formu yüklenirken
            gbFaizHesap.Enabled = false;
            grpOnay.Visible = false;

            yonetici = lblYonetici.Text;

            


        }           //Ana menü yüklenirken gridleri güncelliyor

        private void btnYetkiSeviyesiKaydet_Click(object sender, EventArgs e)  //Seviye tiplerine göre faiz oranları ekliyor
        {
            int a = 0;
            int seviyeTip = 0;

            if (comboBox1.SelectedItem.ToString() == "Şube (0)")  //Seçilen seviye tiplerini sayı olarak tutabilmek için
            {
                seviyeTip = 0;
            }
            if (comboBox1.SelectedItem.ToString() == "Bölge (1)")
            {
                seviyeTip = 1;
            }
            if (comboBox1.SelectedItem.ToString() == "Birim (2)")
            {
                seviyeTip = 2;
            }

            SqlConnection con = new SqlConnection("Server = .\\; Database = stajFaizDeneme; Trusted_Connection = True; MultipleActiveResultSets = True");         
            con.Open();

            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FYZ_I_yetkiSeviye";

                cmd.Parameters.AddWithValue("@seviyeTip", seviyeTip);
                cmd.Parameters.AddWithValue("@seviyeMin", Convert.ToInt32(txtSeviyeMin.Text));
                cmd.Parameters.AddWithValue("@seviyeMax", Convert.ToInt32(txtSeviyeMax.Text));
               
                cmd.ExecuteNonQuery();

                this.tblYetkiSeviyesiTableAdapter.Fill(this.dataSetYetkiSeviyesi.tblYetkiSeviyesi);

                con.Close();
            }
            catch (Exception ex)
            {
                /*string hataMesaji = ex.Message;  //Hata mesajını kopyalamak için

                if(MessageBox.Show(hataMesaji, " ... kopyala", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK){
                    Clipboard.SetText(hataMesaji);
                }*/

                MessageBox.Show(ex.Message + a++);          
            }

            if (a == 0) { MessageBox.Show("Kayıt başarıyla oluşturuldu"); }
        }   

        private void btnKullaniciTanimla_Click(object sender, EventArgs e)
        {
            int a = 0;

            SqlConnection con = new SqlConnection("Server = .\\; Database = stajFaizDeneme; Trusted_Connection = True; MultipleActiveResultSets = True");
            con.Open();

            try
            {
                int yoneticiMi;
                if (chkYonetici.Checked == true)  //Kaydedilen kullanıcının yönetici olup olmadığını tutar
                {
                    yoneticiMi = 1;
                }
                else
                    yoneticiMi = 0;

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FYZ_I_kullaniciEkle";

                cmd.Parameters.AddWithValue("@kulSicilNo", Convert.ToInt32(txtSicilNo.Text));
                cmd.Parameters.AddWithValue("@kulSifre", txtKullaniciSifre.Text);
                cmd.Parameters.AddWithValue("@kulYonetici", yoneticiMi);
               
                cmd.ExecuteNonQuery();
                this.tblKullaniciTableAdapter.Fill(this.kullaniciData.tblKullanici);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + a++);

            }

            if (a == 0) { MessageBox.Show("Kayıt başarıyla oluşturuldu"); con.Close(); }
        }  //Kullanıcı tanımlıyor

        private void btnMusteriKontrol_Click(object sender, EventArgs e)    //Müşteri no'ya göre bilgileri getiriyor
        {
            try
            {
                int musteriNo = Convert.ToInt32(txtMusteriNoKontrol.Text);
                int i = 0;
                string musteriAd;
                string musteriSoyad;
                int a = 0;

                SqlConnection con = new SqlConnection("Server = .\\; Database = stajFaizDeneme; Trusted_Connection = True; MultipleActiveResultSets = True");
                SqlCommand cmd = new SqlCommand("FYZ_S_musteriGetir", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@musNo", musteriNo); //Girdiğimiz müşteri no'yu sp'deki müşteri no'ya atıyor
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();  //db'den değer okuyabilmek için

                var myHashMap = new Dictionary<string, string>();  //Okuduğum değerleri hash map'te tutarak daha kolay hareket edebiliyorum

                while (dr.Read())
                {
                    myHashMap.Add("musAdi" + i, dr["musAdi"].ToString());       //musAdi etiketiyle db'den çektiği müşteri adlarını hashmap'te tutuyor
                    myHashMap.Add("musSoyadi" + i, dr["musSoyadi"].ToString()); //musSoyadi etiketiyle db'den çektiği müşteri soyadlarını hashmap'te tutuyor
                    i++;
                }

                gbFaizHesap.Enabled = true;

                for (int y = 0; y < i; y++)
                {
                    musteriAd = myHashMap["musAdi" + y];       //İstediğimiz müşteri bilgilerini string değişkenlere kaydedip textbox'lara yazdırıyoruz
                    musteriSoyad = myHashMap["musSoyadi" + y];

                    txtMusteriAdKontrol.Text = musteriAd;
                    txtMusteriSoyadKontrol.Text = musteriSoyad;
                    a++;
                }

                a++;
                if (a == 1)
                    MessageBox.Show("Müşteri yok");
            }
            catch (Exception ex)
            {
                int hata = -2146233033;
                if (ex.HResult == hata)
                {
                    MessageBox.Show("Müşteri numarası giriniz.");
                }
                else
                    MessageBox.Show(ex.Message);
            }
            

        }   

        private void dgwMusteri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)  //hücreye çift tıkladığımızda değeleri textbox a yazıyor
        {
            //doubleClickDgw++;
            //var dataIndexNo = dgwMusteri.Rows[e.RowIndex].Index.ToString();  //
            string cellMusNo = dgwMusteri.Rows[e.RowIndex].Cells[1].Value.ToString();     //Herbir müşteri için no, ad, soyad değerlerini alıp değişkenlere atıyor
            string cellMusAd = dgwMusteri.Rows[e.RowIndex].Cells[2].Value.ToString();
            string cellMusSoyad = dgwMusteri.Rows[e.RowIndex].Cells[3].Value.ToString();

            txtMusNo.Text = cellMusNo;      //atılan değişkenlerden de textbox a yazılıyor
            txtMusAd.Text = cellMusAd;
            txtMusSoyad.Text = cellMusSoyad;
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            
            try
            {
                int musteriNo = Convert.ToInt32(txtMusNo.Text); //sileceğimiz müşteri no sunu tutuyor

                int a = 0;

                SqlConnection con = new SqlConnection("Server = .\\; Database = stajFaizDeneme; Trusted_Connection = True; MultipleActiveResultSets = True");
                SqlCommand cmd = new SqlCommand("FYZ_D_musSil", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    cmd.Parameters.AddWithValue("@musNo", musteriNo);  //hangi müşteri no yu arıyorsak sp'ye o değeri yolluyoruz. Sp ile de Delete komutu çalışıyor
                    cmd.ExecuteNonQuery();
                    txtMusAd.Clear();                                   //textbaoxların içi siliniyor
                    txtMusNo.Clear();
                    txtMusSoyad.Clear();
                    this.tblMusteriTableAdapter.Fill(this.musteriData.tblMusteri); //Datagridview güncelleniyor

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + a++);
                }

                if (a == 0)
                    MessageBox.Show("Müşteri Silindi.");

            }
            catch(Exception ex)
            {
                int hata = -2146233033;
                if (ex.HResult == hata)
                {
                    MessageBox.Show("Müşteri numarası boş olamaz");
                }
                else
                    MessageBox.Show(ex.Message);
            }
        }   //Müşteri silmek için

        private void btnYenile_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection("Server = FURKAN; Database = stajFaizDeneme; Trusted_Connection = True; MultipleActiveResultSets = True");  //Datagrid view ı yenilemek için
            
            con.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from tblMusteri", con);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dgwMusteri.DataSource = table;*/

            //this.tblMusteriTableAdapter.Fill(this.musteriData.tblMusteri);  //Datagridview'ı yenilemek için daha basit kod

            /******YENİLE BUTONUNA GEREK OLMADIĞINI FARK ETTİM******/

        }   //Gerek kalmadı

        private void yetkiSeviyesiSil_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                int seviyeTipSil = 0;

                if (comboBox1.SelectedItem.ToString() == "Şube (0)") { seviyeTipSil = 0; } //Seçilen seviye tiplerini sayı olarak tutabilmek için
                if (comboBox1.SelectedItem.ToString() == "Bölge (1)") { seviyeTipSil = 1; }
                if (comboBox1.SelectedItem.ToString() == "Birim (2)") { seviyeTipSil = 2; }

                SqlConnection con = new SqlConnection("Server = .\\; Database = stajFaizDeneme; Trusted_Connection = True; MultipleActiveResultSets = True");
                SqlCommand cmd = new SqlCommand("FYZ_D_yetkiSeviyeSil", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    cmd.Parameters.AddWithValue("@seviyeTip", seviyeTipSil);
                    cmd.ExecuteNonQuery();
                    txtSeviyeMin.Clear();                                   //textbaoxların içi siliniyor
                    txtSeviyeMax.Clear();
                    comboBox1.SelectedText = "";
                    this.tblYetkiSeviyesiTableAdapter.Fill(this.dataSetYetkiSeviyesi.tblYetkiSeviyesi);  //Datagridview güncelleniyor

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + a++);
                }

                if (a == 0)
                    MessageBox.Show("Yetki Seviyesi Silindi.");
            }
            catch (Exception ex)
            {
                int hata = -2146233033;
                if (ex.HResult == hata)
                {
                    MessageBox.Show("Yetki seviyesi seçilmeli");
                }
                else
                    MessageBox.Show(ex.Message);
            }
            
        }   //Yetki seviyelerini seviye tipine göre siliyor

        private void dgwYetkiSeviye_CellDoubleClick(object sender, DataGridViewCellEventArgs e)  //Yetki Seviye datagridview'e double click eventi
        {
            int cellSeviyeTip = Convert.ToInt32(dgwYetkiSeviye.Rows[e.RowIndex].Cells[1].Value);     
            string cellSeviyeMin = dgwYetkiSeviye.Rows[e.RowIndex].Cells[2].Value.ToString();
            string cellSeviyeMax = dgwYetkiSeviye.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (cellSeviyeTip == 0)
                comboBox1.SelectedItem = "Şube (0)";     //atılan değişkenlerden de textbox a yazılıyor
            if (cellSeviyeTip == 1)
                comboBox1.SelectedItem = "Bölge (1)";
            if (cellSeviyeTip == 2)
                comboBox1.SelectedItem = "Birim (2)";
            txtSeviyeMax.Text = cellSeviyeMax;
            txtSeviyeMin.Text = cellSeviyeMin;
        }

        private void dgwKullanici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)  //Kullanıcı datagridview'e double click eventi
        {
            int cellSicilNo = Convert.ToInt32(dgwKullanici.Rows[e.RowIndex].Cells[1].Value);
            string cellSifre = dgwKullanici.Rows[e.RowIndex].Cells[2].Value.ToString();
            int cellYoneticiMi = Convert.ToInt32(dgwKullanici.Rows[e.RowIndex].Cells[3].Value);

            if (cellYoneticiMi == 1)
                chkYonetici.Checked = true;
            if (cellYoneticiMi == 0)
                chkYonetici.Checked = false;

            txtSicilNo.Text = cellSicilNo.ToString();
            txtKullaniciSifre.Text = cellSifre;
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {

            try
            {
                int sicilNo = Convert.ToInt32(txtSicilNo.Text); //sileceğimiz kullanıcı sicil numarası
                int a = 0;

                SqlConnection con = new SqlConnection("Server = .\\; Database = stajFaizDeneme; Trusted_Connection = True; MultipleActiveResultSets = True");
                SqlCommand cmd = new SqlCommand("FYZ_D_kullaniciSil", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    cmd.Parameters.AddWithValue("@kulSicilNo", sicilNo);  //hangi sicil no yu arıyorsak sp'ye o değeri yolluyoruz. Sp ile de Delete komutu çalışıyor
                    cmd.ExecuteNonQuery();
                    txtSicilNo.Clear();                                   //textbaoxların içi siliniyor
                    txtKullaniciSifre.Clear();
                    chkYonetici.Checked = false;

                    this.tblKullaniciTableAdapter.Fill(this.kullaniciData.tblKullanici); //Datagridview güncelleniyor

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + a++);
                }

                if (a == 0)
                    MessageBox.Show("Kullanıcı Silindi.");
            }
            catch (Exception ex)
            {
                int hata = -2146233033;
                if ( ex.HResult == hata)
                    MessageBox.Show("Sicil numarası boş olamaz");
                else
                    MessageBox.Show(ex.Message);
            }
            
        }   //Kullanıcı siliyor

        private void txtFaizOrani_TextChanged(object sender, EventArgs e)
        {          
            if (txtFaizOrani.Text != "")        //3 tane seviye tipimiz var. Textbox içine yazılan faiz oranı sayesinde hangi aralıkta olduğunu bulup textbox'ları
            {                                   //gerekli bilgiler ile dolduruyoruz.
                
                if (Convert.ToInt32(txtFaizOrani.Text) >= Convert.ToInt32(dgwYetkiSeviye.Rows[0].Cells[2].Value.ToString()) &&
                                    Convert.ToInt32(txtFaizOrani.Text) <= Convert.ToInt32(dgwYetkiSeviye.Rows[0].Cells[3].Value.ToString()))
                {
                    txtYetkiSeviye.Text = "Şube";
                    txtYetkiSeviyeMin.Text = dgwYetkiSeviye.Rows[0].Cells[2].Value.ToString();
                    txtYetkiSeviyeMax.Text = dgwYetkiSeviye.Rows[0].Cells[3].Value.ToString();
                    lblYetkiSeviyeOnay.Text = txtYetkiSeviye.Text + " onayı gerekli.";

                }
                else if (Convert.ToInt32(txtFaizOrani.Text) >= Convert.ToInt32(dgwYetkiSeviye.Rows[1].Cells[2].Value.ToString()) &&
                                    Convert.ToInt32(txtFaizOrani.Text) <= Convert.ToInt32(dgwYetkiSeviye.Rows[1].Cells[3].Value.ToString()))
                {
                    txtYetkiSeviye.Text = "Bölge";
                    txtYetkiSeviyeMin.Text = dgwYetkiSeviye.Rows[1].Cells[2].Value.ToString();
                    txtYetkiSeviyeMax.Text = dgwYetkiSeviye.Rows[1].Cells[3].Value.ToString();
                    lblYetkiSeviyeOnay.Text = txtYetkiSeviye.Text + " onayı gerekli.";
                }
                else if (Convert.ToInt32(txtFaizOrani.Text) >= Convert.ToInt32(dgwYetkiSeviye.Rows[2].Cells[2].Value.ToString()) &&
                                    Convert.ToInt32(txtFaizOrani.Text) <= Convert.ToInt32(dgwYetkiSeviye.Rows[2].Cells[3].Value.ToString()))
                {
                    txtYetkiSeviye.Text = "Birim";
                    txtYetkiSeviyeMin.Text = dgwYetkiSeviye.Rows[2].Cells[2].Value.ToString();
                    txtYetkiSeviyeMax.Text = dgwYetkiSeviye.Rows[2].Cells[3].Value.ToString();
                    lblYetkiSeviyeOnay.Text = txtYetkiSeviye.Text + " onayı gerekli.";
                }

                else
                {
                    txtYetkiSeviye.Text = "Uygun aralıkta değilsiniz";                 
                }

            }
            else
            {
                txtYetkiSeviye.Text = "";
                txtYetkiSeviyeMin.Text = "";
                txtYetkiSeviyeMax.Text = "";
                lblYetkiSeviyeOnay.Text = "";
            }
        
        }

        private void btnVadeSonuDeger_Click(object sender, EventArgs e)
        {

            int paraMiktari = Convert.ToInt32(txtMiktar.Text);      //Faiz hesaplamak için gerekli işlemler
            int vadeGun = Convert.ToInt32(txtTalepVade.Text);
            int faizOrani = Convert.ToInt32(txtFaizOrani.Text);

            int vadeSonuDeger = 0;

            vadeSonuDeger = paraMiktari*vadeGun*faizOrani / 100;

            txtVadeSonuDeger.Text = vadeSonuDeger.ToString();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int a = 0; //Kaydın başırılı olup olmadığını tutabilmek için
            SqlConnection con = new SqlConnection("Server = .\\; Database = stajFaizDeneme; Trusted_Connection = True; MultipleActiveResultSets = True"); //Connection String
            con.Open(); //Veritabanı bağlantısı açıldı

            try
            {
                int seviyeTip = 0;

                if (txtYetkiSeviye.Text == "Şube") { seviyeTip = 0; }   //Seçilen seviye tiplerini sayı olarak tutabilmek için
                if (txtYetkiSeviye.Text == "Bölge") { seviyeTip = 1; }
                if (txtYetkiSeviye.Text == "Birim") { seviyeTip = 2; }

                SqlCommand cmd = con.CreateCommand(); //Komut oluşturuluyor. Store procedure'ü belirtmek için
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FYZ_I_faizYetki";

                cmd.Parameters.AddWithValue("@musNo", Convert.ToInt32(txtMusteriNoKontrol.Text));  //Store procedure'de oluşturulan değişkenlere
                cmd.Parameters.AddWithValue("@musAd", txtMusteriAdKontrol.Text);                  //Textboxlarda oluşturulan değerler atanıyor.
                cmd.Parameters.AddWithValue("@musSoyad", txtMusteriSoyadKontrol.Text);
                cmd.Parameters.AddWithValue("@vadeGun", Convert.ToInt32(txtTalepVade.Text));
                cmd.Parameters.AddWithValue("@miktar", Convert.ToInt32(txtMiktar.Text));
                cmd.Parameters.AddWithValue("@faizOrani", Convert.ToInt32(txtFaizOrani.Text));
                cmd.Parameters.AddWithValue("@seviyeTip", seviyeTip);
                cmd.Parameters.AddWithValue("@vadeSonu", Convert.ToInt32(txtVadeSonuDeger.Text));
                cmd.Parameters.AddWithValue("@onayDurumu", "Onay Bekleniyor");
                cmd.Parameters.AddWithValue("@sicilNo", 0);

                cmd.ExecuteNonQuery();                                                  //Store procedure çalıştırılıp ekleme işleminin yapması sağlanıyor
                this.tblFaizYetkiTableAdapter.Fill(this.stajFaizDenemeDataSet.tblFaizYetki);          //Datagridview'ı yenilemek için
                con.Close();                                                            //Veritabanı bağlantısı kapatıldı
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + a++);                                      //Hata varsa hata mesajı gösteriliyor ve doğru giriş yapılmadığın                                                                                      // anlayabilmek için a arttırılıyor
            }                                                                           //anlayabilmek için a arttırılıyor

            if (a == 0) { MessageBox.Show("Kayıt başarıyla oluşturuldu"); }             //a eğer arttırılmamışsa catch'e girmemiş demektir ve kayıt başarılıdır.
        }

        private void dgwOnay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            yonetici = lblYonetici.Text;    //Çift tıklayan kişi yöneticiyse

            if (yonetici == "True")
            {
                grpOnay.Visible = true;     //Onaylama ekranı görünür oluyor
                
            }

            cbxOnayDurumu.Text = dgwOnay.Rows[e.RowIndex].Cells[8].Value.ToString();    //Onay Datagridview ına çift tıklayınca müşteri numarası update sp'sini
            musteriNo = Convert.ToInt32(dgwOnay.Rows[e.RowIndex].Cells[0].Value);       //çalıştırabilmek için bir değişkene atılıyor
                                                                                        //Onay durumu da combobox'ta gösteriliyor
        }

        private void btnOnayKaydet_Click(object sender, EventArgs e)
        {
            sicilNo = Convert.ToInt32(label7.Text);

            //MessageBox.Show(sicilNo.ToString());
            SqlConnection con = new SqlConnection("Server = .\\; Database = stajFaizDeneme; Trusted_Connection = True; MultipleActiveResultSets = True"); //Connection String

            con.Open(); //Veritabanı bağlantısı açıldı

            try
            {
                SqlCommand cmd = con.CreateCommand(); //Komut oluşturuluyor. Store procedure'ü belirtmek için
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FYZ_U_faizYetkiGuncelle";

                cmd.Parameters.AddWithValue("@sicilNo", sicilNo);
                cmd.Parameters.AddWithValue("@musNo", musteriNo);
                
                cmd.Parameters.AddWithValue("@onayDurumu", cbxOnayDurumu.SelectedItem.ToString());  //Onaylama ve reddetme işlemleri db'ye kaydediliyor sp ile

                cmd.ExecuteNonQuery();
                this.tblFaizYetkiTableAdapter.Fill(this.stajFaizDenemeDataSet.tblFaizYetki);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
