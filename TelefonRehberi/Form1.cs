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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numaraEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelefonNumarasi telefonNumarasi = new TelefonNumarasi();
            telefonNumarasi.ShowDialog();
            TelefonNumaralariniAl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TelefonNumaralariniAl();
        }

        void TelefonNumaralariniAl()
        {
            string sqlBaglantiCumlesi = ConfigurationManager.ConnectionStrings["SqlBaglanti"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(sqlBaglantiCumlesi);
            SqlCommand sqlCommand = new SqlCommand("select [Id], [AdSoyad], [EMail], [TelefonNo] from Numaralar", sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                dataGridViewNumaralar.Rows.Clear();
                while (sqlDataReader.Read())
                {
                    dataGridViewNumaralar.Rows.Add(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2), sqlDataReader.GetString(3));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Numaralar alınamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
        }

        private void seciliNumarayiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sonuc = -1;
            if (dataGridViewNumaralar.SelectedRows.Count == 0)
            {
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Numara silinecek, onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            object value = dataGridViewNumaralar.SelectedRows[0].Cells[0].Value;
            int id = (int)value;

            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlBaglanti"].ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("delete Numaralar where Id = @id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);

            try
            {
                sqlConnection.Open();
                sonuc = sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"Telefon numarası sili{(sonuc > 0 ? "ndi" : "nemedi")}.",
                    sonuc > 0 ? "Bilgilendirme" : "Hata", MessageBoxButtons.OK,
                    sonuc > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            catch (Exception)
            {

            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }

            if (sonuc > 0)
            {
                TelefonNumaralariniAl();
            }
        }

        private void seciliNumarayiGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sonuc = -1;
            if (dataGridViewNumaralar.SelectedRows.Count == 0)
            {
                return;
            }
            
            object value = dataGridViewNumaralar.SelectedRows[0].Cells[0].Value;
            int id = (int)value;

            TelefonNumarasi telefonNumarasi = new TelefonNumarasi(id);
            telefonNumarasi.ShowDialog();
            TelefonNumaralariniAl();
        }
    }
}
