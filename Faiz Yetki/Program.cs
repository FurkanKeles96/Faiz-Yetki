using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public static class FormManager   //Formlar arası geçiş için
    {
        public static AnaMenu anaMenu = new AnaMenu();

        public static void openNewForm()
        {

            anaMenu.Show();

        }
    }


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Giris());


        }

        

    }

    /*public class VeriTabaniBaglanti
    {
        public static SqlConnection conn = null;

        public void baglantiKur()
        {
            
            //SqlDataReader rdr = null;
            conn = new SqlConnection("Server = FURKAN; Database = stajFaizDeneme; Trusted_Connection = True; MultipleActiveResultSets=True");
            conn.Open();

        }

        
    }*/

    /*public static class musEkle
    {
        

        public static string S_FYZ_I_musEkle(TextBox txtMusNo, TextBox txtMusAd, TextBox txtMusSoyad)
        {
            int a = 0;
            
            SqlConnection connect = VeriTabaniBaglanti.conn;
            try
            {
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "FYZ_I_musEkle";

                cmd.Parameters.AddWithValue("@musNo", Convert.ToInt32(txtMusNo.Text));
                cmd.Parameters.AddWithValue("@musAdi", txtMusAd.Text);
                cmd.Parameters.AddWithValue("@musSoyadi", txtMusSoyad.Text);

                //connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            if (a == 0) { MessageBox.Show("Kayıt başarıyla oluşturuldu"); }
            return "";
        }

        

        
    }*/

    


}
