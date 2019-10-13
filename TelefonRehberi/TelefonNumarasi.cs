using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberi
{
    public partial class TelefonNumarasi : Form
    {
        private int Id;
        private bool updateIcin;
        public TelefonNumarasi()
        {
            InitializeComponent();
        }
        public TelefonNumarasi(int id)
        {
            InitializeComponent();
            Id = id;
            updateIcin = true;

            SqlConnection sqlBaglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlBaglanti"].ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("select top 1 [Id], [AdSoyad], [EMail], [TelefonNo] from Numaralar where Id = @id", sqlBaglanti);
            sqlCommand.Parameters.AddWithValue("@id", Id);
            try
            {
                sqlBaglanti.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    textBoxAdSoyad.Text = sqlDataReader.GetString(1);
                    textBoxMail.Text = sqlDataReader.GetString(2);
                    maskedTextBoxTelefon.Text = sqlDataReader.GetString(3);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Telefon numrası alınamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlBaglanti.State != ConnectionState.Closed)
                {
                    sqlBaglanti.Close();
                }
            }
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            int sonuc = -1;
            string baglantiCumlesi = ConfigurationManager.ConnectionStrings["SqlBaglanti"].ConnectionString;

            SqlConnection sqlBaglanti = new SqlConnection(baglantiCumlesi);
            SqlCommand sqlCommand;
            if (updateIcin)
            {
                sqlCommand = new SqlCommand("update Numaralar set AdSoyad = @a, EMail = @e, TelefonNo = @t where Id = @id", sqlBaglanti);
                sqlCommand.Parameters.AddWithValue("@id", Id);
            }
            else
            {
                 sqlCommand = new SqlCommand("INSERT INTO Numaralar([AdSoyad], [EMail], [TelefonNo]) VALUES (@a, @e, @t)", sqlBaglanti);
            }
            
            sqlCommand.Parameters.AddWithValue("@a", textBoxAdSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@e", textBoxMail.Text);
            sqlCommand.Parameters.AddWithValue("@t", maskedTextBoxTelefon.Text);

            try
            {
                sqlBaglanti.Open();
                sonuc = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Bağlantıda hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (sqlBaglanti.State != ConnectionState.Closed)
                {
                    sqlBaglanti.Close();
                }
            }

            if (sonuc > 0)
            {
                MessageBox.Show("Telefon numarası kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Telefon numarası kaydedilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
