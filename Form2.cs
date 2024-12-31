using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeodev
{
    public partial class Form2 : Form
    {
        public int SecilenOgrenciId { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void btnderssec_Click(object sender, EventArgs e)
        {
            using (var cn = new OkulContext())
            {
                
                var secilenDersler = dgvDersler.Rows.Cast<DataGridViewRow>()
                                      .Where(row => Convert.ToBoolean(row.Cells["Secim"].Value) == true)
                                      .Select(row => (int)row.Cells["DersId"].Value)
                                      .ToList();

                
                var mevcutDersler= cn .OgrenciDersleri
                    .Where(od => od.OgrenciId == SecilenOgrenciId);
                cn.OgrenciDersleri.RemoveRange(mevcutDersler);

                
                foreach (var dersId in secilenDersler)
                {
                    cn.OgrenciDersleri.Add(new OgrenciDers
                    {
                        OgrenciId = SecilenOgrenciId,
                        DersId = dersId
                    });
                }

                    cn.SaveChanges();
                MessageBox.Show("Dersler başarıyla güncellendi.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (var cn = new OkulContext())
            {
                
                var ogrenci = cn.Ogrenciler
                    .Include(o => o.Sinif)
                    .FirstOrDefault(o => o.OgrenciId == SecilenOgrenciId);

                if (ogrenci != null)
                {
                    lblOgrenciBilgi.Text = $"Adı: {ogrenci.Adi} Soyadı: {ogrenci.Soyadi} Numara: {ogrenci.Numara} Sınıf: {ogrenci.Sinif.Adi}";
                }

                
                var tumDersler = cn.Dersler
                    .Select(d => new
                    {
                        d.DersId,
                        d.Baslik
                    }).ToList();

                
                var ogrenciDersler = cn.OgrenciDersleri
                    .Where(od => od.OgrenciId == SecilenOgrenciId)
                    .Select(od => od.DersId)
                    .ToList();

                
                dgvDersler.DataSource = tumDersler;

                
                if (!dgvDersler.Columns.Contains("Secim"))
                {
                    var checkboxColumn = new DataGridViewCheckBoxColumn
                    {
                        HeaderText = "Seç",
                        Name = "Secim",
                        Width = 50
                    };
                    dgvDersler.Columns.Add(checkboxColumn);
                }

                
                foreach (DataGridViewRow row in dgvDersler.Rows)
                {
                    int dersId = (int)row.Cells["DersId"].Value;
                    if (ogrenciDersler.Contains(dersId))
                    {
                        row.Cells["Secim"].Value = true;
                    }
                }
            }
        }

       
    }
}
