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
using EntityLayer;
using DataAccesLayer3;
using LogicLayer;

namespace NkatmanlıApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SqlConnection
        }

        private void Btn_Listele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> Perlist = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = Perlist;
        
        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Name = Txt_Ad.Text;
            ent.Surname =Txt_Soyad.Text;
            ent.City = Txt_Sehir.Text;
            ent.Maas = short.Parse(Txt_Maas.Text);
            ent.Gorev=Txt_Gorev.Text;
            LogicPersonel.LLPersonelEkle(ent);
        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {
            
                EntityPersonel ent = new EntityPersonel();
                ent.Id = Convert.ToInt32(Txt_Id.Text);
            ent.Name = Txt_Ad.Text;
            ent.Surname=Txt_Soyad.Text;
            ent.City=Txt_Sehir.Text;
            ent.Gorev = Txt_Gorev.Text;
            ent.Maas = short.Parse(Txt_Maas.Text);
            LogicPersonel.LLPersonelGuncelle(ent);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(Txt_Id.Text);
            LogicPersonel.LLPersonelSil(ent.Id);

        }
    }
}
