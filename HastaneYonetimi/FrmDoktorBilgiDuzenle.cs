using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneYonetimi
{
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl=new Sqlbaglantisi();
        public string TC;

        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTc.Text = TC;

            SqlCommand cmd = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTc=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",mskTc.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtAd.Text = reader[1].ToString();
                txtSoyad.Text = reader[2].ToString();
                cmbBrans.Text = reader[3].ToString();
                txtSifre.Text = reader[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DOktorSifre=@p4 where DoktorTc=@p5", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtAd.Text);
            cmd.Parameters.AddWithValue("@p1",txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p1",cmbBrans.Text);
            cmd.Parameters.AddWithValue("@p1",txtSifre.Text);
            cmd.Parameters.AddWithValue("@p1",mskTc.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi");
        }
    }
}
