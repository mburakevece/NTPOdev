using Microsoft.EntityFrameworkCore;

namespace denemeodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnderssec_Click(object sender, EventArgs e)
        {
            using (var context = new OkulContext())
            {
                var ogrenci = context.Ogrenciler.Include(o => o.OgrenciDersleri).FirstOrDefault(o => o.Numara == txtno.Text);

                if (ogrenci != null)
                {
                    
                    var dersSecimForm = new Form2();
                    dersSecimForm.SecilenOgrenciId = ogrenci.OgrenciId; 
                    dersSecimForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("L�tfen �nce bir ��renci bulun!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new OkulContext())
            {
                cboxs�n�f.DataSource = context.Siniflar.ToList();
                cboxs�n�f.DisplayMember = "Adi";
                cboxs�n�f.ValueMember = "SinifId";
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            using (var context = new OkulContext())
            {
                string adi = txtad.Text.Trim();
                string soyadi = txtsoyad.Text.Trim();
                string numara = txtno.Text.Trim();

                try
                {
                    
                    if (cboxs�n�f.SelectedValue == null)
                    {
                        MessageBox.Show("L�tfen bir s�n�f se�in.");
                        return;
                    }

                    int sinifId = (int)cboxs�n�f.SelectedValue;
                    var sinif = context.Siniflar.Include(s => s.Ogrenciler).FirstOrDefault(s => s.SinifId == sinifId);

                    if (sinif == null)
                    {
                        MessageBox.Show("Se�ilen s�n�f bulunamad�.");
                        return;
                    }

                    var mevcutOgrenci = context.Ogrenciler.FirstOrDefault(o => o.Adi == adi && o.Soyadi == soyadi && o.Numara == numara);
                    if (mevcutOgrenci != null)
                    {
                        MessageBox.Show("Bu ��renci zaten kay�tl�!");
                        return;
                    }

                    
                    if (sinif.Ogrenciler.Count >= sinif.Kapasite)
                    {
                        MessageBox.Show("Se�ilen s�n�f�n kapasitesi dolmu�!");
                        return;
                    }

                    
                    if (string.IsNullOrWhiteSpace(txtad.Text) || string.IsNullOrWhiteSpace(txtsoyad.Text) || string.IsNullOrWhiteSpace(txtno.Text))
                    {
                        MessageBox.Show("L�tfen t�m alanlar� doldurun.");
                        return;
                    }

                    var yeniOgrenci = new Ogrenci
                    {
                        Adi = txtad.Text,
                        Soyadi = txtsoyad.Text,
                        Numara = txtno.Text,
                        SinifId = sinifId
                    };

                    context.Ogrenciler.Add(yeniOgrenci);
                    context.SaveChanges();

                    MessageBox.Show("��renci ba�ar�yla kaydedildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata olu�tu: {ex.Message}");
                }
            }
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            using (var context = new OkulContext())
            {
                int numara;
                if (int.TryParse(txtno.Text, out numara))
                {
                    var ogrenci = context.Ogrenciler.Include(o => o.Sinif).FirstOrDefault(o => o.Numara == txtno.Text);

                    if (ogrenci != null)
                    {
                        txtad.Text = ogrenci.Adi;
                        txtsoyad.Text = ogrenci.Soyadi;
                        cboxs�n�f.SelectedValue = ogrenci.SinifId;

                        MessageBox.Show("��renci bilgileri y�klendi.");
                    }
                    else
                    {
                        MessageBox.Show("��renci bulunamad�.");
                    }
                }
                else
                {
                    MessageBox.Show("Ge�erli bir ��renci numaras� girin.");
                }
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            using (var context = new OkulContext())
            {
                int numara;
                if (int.TryParse(txtno.Text, out numara))
                {
                    var ogrenci = context.Ogrenciler.FirstOrDefault(o => o.Numara == txtno.Text);

                    if (ogrenci != null)
                    {
                        ogrenci.Adi = txtad.Text;
                        ogrenci.Soyadi = txtsoyad.Text;
                        ogrenci.SinifId = (int)cboxs�n�f.SelectedValue;

                        context.SaveChanges();
                        MessageBox.Show("��renci bilgileri ba�ar�yla g�ncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("��renci bulunamad�.");
                    }
                }
                else
                {
                    MessageBox.Show("Ge�erli bir ��renci numaras� girin.");
                }
            }
        }
    }
}
