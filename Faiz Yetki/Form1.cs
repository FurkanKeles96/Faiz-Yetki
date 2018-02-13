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
    

    public partial class Giris : Form
    {
        public bool yoneticiMi;

        public Giris()
        {
            InitializeComponent();
            
        }

        private void btnGiris_Click(object sender, EventArgs e) 
        {
            int i = 0;
            string kullanici;
            string sifre;
            //bool yoneticiMi;
            int a = 0;
            


            SqlConnection con = new SqlConnection("Server = .\\; Database = stajFaizDeneme; Trusted_Connection = True; MultipleActiveResultSets = True");
            SqlCommand cmd = new SqlCommand("FYZ_S_kulGiris", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            var myHashMap = new Dictionary<string, string>();       //db'den okuduğumuz kullanıcı bilgilerini tutmak için oluşturulan hashmap
            

            while (dr.Read())
            {

                myHashMap.Add("kullanici" + i, dr["kulSicilNo"].ToString());        //Kullanıcı sicil numarası, şifresi ve yönetici olup olmadığı
                myHashMap.Add("sifre" + i, dr["kulSifre"].ToString());              //hashmapte tutuluyor
                myHashMap.Add("yonetici" + i, dr["kulYonetici"].ToString());

                i++;        //db'den ne kadar değer okuduğunu tutuyor ve hashmap'lerde ayrı ayrı kullanıcı bilgilerine ulaşmamızı sağlıyor
            }

            for (int y = 0; y < i; y++)     //db'den okuduğu veri kadar dönen bir for
            {
                
                kullanici = myHashMap["kullanici" + y];     //kullanıcı sicil numarasını ve
                sifre = myHashMap["sifre" + y];             //kullanıcının şifresini alıyor
                if (txtSicil.Text == kullanici && txtSifre.Text == sifre)   //Textbox'lara girilen bilgiler ile db'dekiler eşleştiriliyor.
                {                                                           
                    
                    yoneticiMi = Convert.ToBoolean(myHashMap["yonetici" + y]);      //Bilgisi alınan kullanıcının yönetici olup olmadığına dair bilgi değişkene atanıyor
                    MessageBox.Show("Başarılı şekilde giriş yaptınız.");
                    a++;
                    AnaMenu ana2 = new AnaMenu();       //Ana menüye geçiş için
                    ana2.Show();        //ana menü gösteriliyor
                    ana2.lblYonetici.Text = yoneticiMi.ToString();
                    ana2.label7.Text = txtSicil.Text;       //Giriş yapan kişinin sicil numarasını diğer forma aktarmak için
                    ana2.kullanıcıToolStripMenuItem.Text = "Sicil: " + txtSicil.Text;       //Üst menüde giriş yapanın sicil numarasını gösteriypr
                    if (yoneticiMi == false)        //Yönetici değilse bazı kısımlara erişim engelleniyor
                    {
                        ana2.yetkiTanımlaToolStripMenuItem.Enabled = false;
                        //ana2.onayToolStripMenuItem.Enabled = false;
                        ana2.kullanıcıTanımlaToolStripMenuItem.Enabled = false;
                    }

                    
                    this.Hide();        //Bu form gizleniyor
                    
                }


            }

            
                a++;
                if (a == 1)
                    MessageBox.Show("Hatalı giriş");

            //FORMLAR ARASI YONETİCİ KONTROLÜ GÖNDERİLMELİ  -- Gönderildi



            /*SqlDataAdapter dr = new SqlDataAdapter(cmd);          //DatagridView'a veri yazma örneği
            DataSet ds = new DataSet();
            dr.Fill(ds, "bilgi");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
            try
            {
                for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                {
                    for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
                    {
                        if (dataGridView1.Rows.Count != 0 && dataGridView1.Rows != null)
                        {
                            MessageBox.Show(dataGridView1.Rows[rows].Cells[col].Value.ToString());
                        }
                            
                        

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }*/


            /*FormManager.openNewForm();
            this.Hide();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //uygulamayı kapatması için 
        }
    }
}
