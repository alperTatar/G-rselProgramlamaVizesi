using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;




namespace Sinema_Seans_Takip_Uygulaması_Güncel
{
    public partial class Form1 : Form
    {
        public object ConfigurationManager { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "ALPER SİNEMA";

            // tabPage isimlerinin yazdığı kısım.
            tabPage1.Text = "Film Ekle";
            tabPage2.Text = "Salon Kontrol";
            tabPage3.Text = "Seans Kontrol ve Salon Takip";
            tabPage4.Text = "Bilet Satışı";
            tabPage5.Text = "Çıkış";

            // Filmlerin Sıralandığı ve gösterildiği kısım.
            comboBox1.Items.Add("İron Man (Standart)");
            comboBox1.Items.Add("Recep İvedik (Standart)");
            comboBox1.Items.Add("Osman Pazarlama (Standart)");
            comboBox1.Items.Add("The Godfather (Standart)");

            //comboBox5 filmlerin sıralndığı yer.
            comboBox5.Items.Add("İron Man (Standart)");
            comboBox5.Items.Add("Recep İvedik (Standart)");
            comboBox5.Items.Add("Osman Pazarlama (Standart)");
            comboBox5.Items.Add("The Godfather (Standart)");

            // Seans Saatlerinin Gösterildiği Kısım.
            comboBox2.Items.Add("12:00 (Standart)");

            // Salon Kapasite Kontrol İşlemleri Bu Kısımda Yapılıyor.
            //  comboBox3.Items.Add("Salon 1");
            //comboBox3.Items.Add("Salon 2");
            // comboBox3.Items.Add("Salon 3");
            // comboBox3.Items.Add("Salon 4");
            // comboBox3.Items.Add("Salon 5");

            //Bilet Satış combobox4 salon seçimleri
            comboBox4.Items.Add("Salon 1");
            //comboBox4.Items.Add("Salon 2");
            //comboBox4.Items.Add("Salon 3");
            //comboBox4.Items.Add("Salon 4");
            //comboBox4.Items.Add("Salon 5");

            // Film ekle tabında textbox'ları temizle
            TemizleTextboxlar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // TextBox3'teki metni kontrol et
            string text = textBox3.Text;

            // Metni kontrol et
            if (text == "23:00" || text == "24:00")
            {
                // Hata mesajı göster
                MessageBox.Show("Geçersiz saat girildi. Lütfen başka bir saat girin.");
                // TextBox3'ü temizle
                textBox3.Text = "";
            }
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox4.Text, out int value) || value < 2 || value > 5)
            {
                MessageBox.Show("Lütfen 2, 3, 4 veya 5 numaralı salonlardan birini girin.");
                textBox4.Clear();
            }
            else
            {
                // Salon numarasını belirle
                string salonNumarasi = textBox4.Text;

                // Salon numarasına göre kapasiteyi belirle
                int kapasite = 0;
                switch (salonNumarasi)
                {
                    case "1":
                        kapasite = 140;
                        break;
                    case "2":
                        kapasite = 220;
                        break;
                    case "3":
                        kapasite = 324;
                        break;
                    case "4":
                        kapasite = 76;
                        break;
                    case "5":
                        kapasite = 90;
                        break;
                    default:
                        MessageBox.Show("Geçersiz salon numarası!");
                        textBox4.Text = ""; // Geçersiz salon numarası girildiğinde textBox4'ü temizle
                        break;
                }

                // ComboBox'a salon numarasını ekle
                if (!comboBox3.Items.Contains(salonNumarasi))
                {
                    comboBox3.Items.Add(salonNumarasi); // Yeni değeri ekle
                }

                // ComboBox'ta seçili olanı güncelle
                comboBox3.SelectedItem = salonNumarasi;

                // Kapasiteyi textBox5'e yazdır
                textBox5.Text = kapasite.ToString();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
        }

        private void VerileriComboBoxaEkle()
        {
            // Bağlantı dizesini alın
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // SQL sorgusunu hazırlayın
            string query = "SELECT FilmAdi FROM Filmler";

            // Bağlantıyı oluşturun
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Komut ve bağlantıyı oluşturun
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    try
                    {
                        // Bağlantıyı açın
                        connection.Open();

                        // Verileri okuyun
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            // ComboBox'ı temizleyin
                            comboBox5.Items.Clear();

                            // Her satır için verileri ComboBox'a ekle
                            while (reader.Read())
                            {
                                string filmAdi = reader["FilmAdi"].ToString();
                                comboBox5.Items.Add(filmAdi);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda hata mesajını gösterin
                        MessageBox.Show("Veriler alınırken bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }




        private void button4_Click(object sender, EventArgs e)
        {
            // Film adı, seans saati ve salon numarasını alın
            string filmAdi = textBox2.Text;
            string seansSaati = textBox3.Text;
            string salonNo = textBox4.Text;

            // SQL komutunu hazırlayın (parametreler kullanarak SQL enjeksiyonunu önlemek için)
            string query = "INSERT INTO Filmler (FilmAdi, SeansSaati, SalonNo) VALUES (@FilmAdi, @SeansSaati, @SalonNo)";

            // Bağlantı dizesini alın
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Bağlantıyı oluşturun
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Komut ve bağlantıyı oluşturun
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@Filmler", filmAdi);
                    command.Parameters.AddWithValue("@salonNumarası", seansSaati);
                    command.Parameters.AddWithValue("@salonKapasitesi", salonNo);

                    try
                    {
                        // Bağlantıyı açın
                        connection.Open();
                        // Komutu çalıştırın
                        int rowsAffected = command.ExecuteNonQuery();

                        // Eğer satır etkilendiyse, bilgi mesajı gösterin
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Film başarıyla eklendi.");
                        }
                        else
                        {
                            MessageBox.Show("Film eklenirken bir hata oluştu.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda hata mesajını gösterin
                        MessageBox.Show("Film eklenirken bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }




        private void button5_Click(object sender, EventArgs e)
        {
            // Bağlantı dizesini alın
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Salon numarasını alın
            string salonNo = comboBox4.Text;

            // SQL komutunu hazırlayın (parametreler kullanarak SQL enjeksiyonunu önlemek için)
            string query = "SELECT SalonKapasitesi FROM salonKapasitesi WHERE SalonNo = @SalonNo";

            // Bağlantıyı oluşturun
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Komut ve bağlantıyı oluşturun
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Parametreyi ekle
                    command.Parameters.AddWithValue("@SalonNo", salonNo);

                    try
                    {
                        // Bağlantıyı açın
                        connection.Open();

                        // Veriyi okuyun
                        object result = command.ExecuteScalar();

                        // Eğer veri varsa, mevcut kapasiteyi göster
                        if (result != null)
                        {
                            // Kapasiteyi dataGridView2'ye göster
                            dataGridView2.Rows.Clear();
                            dataGridView2.Rows.Add("Mevcut Salon Kapasitesi:", result.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Salon kapasitesi bulunamadı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda hata mesajını gösterin
                        MessageBox.Show("Salon kapasitesi alınırken bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }



        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            // Film ekleme butonuna tıklandığında
            string filmAdi = comboBox1.Text;
            string seansSaati = comboBox2.Text;
            int salonNo;
            int salonKapasitesi;

            // Salon numarası için giriş kontrolü
            if (!int.TryParse(comboBox3.Text.Replace("Salon ", ""), out salonNo) || salonNo <= 0 || salonNo > 5)
            {
                MessageBox.Show("Geçersiz salon numarası. Lütfen 1 ile 5 arasında bir sayı girin.");
                return;
            }

            // Salon kapasitesi için giriş kontrolü
            if (!int.TryParse(comboBox4.Text, out salonKapasitesi) || salonKapasitesi <= 0)
            {
                MessageBox.Show("Geçersiz salon kapasitesi. Lütfen pozitif bir sayı girin.");
                return;
            }

            // Film bilgilerini kullanarak combobox'ları güncelle
            comboBox1.Items.Add(filmAdi);
            comboBox2.Items.Add(seansSaati);

            // TextBox'ları temizle
            TemizleTextboxlar();

            MessageBox.Show("Film başarıyla eklendi.");
        }

        private void TemizleTextboxlar()
        {
            // TextBox'ları temizle
            textBox2.Clear();
            textBox3.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen film adını alın
            string selectedFilm = comboBox1.SelectedItem.ToString();

            // Bağlantı dizesini alın
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // SQL sorgusunu hazırlayın (parametreler kullanarak SQL enjeksiyonunu önlemek için)
            string query = "SELECT DISTINCT SalonNo FROM Filmler WHERE FilmAdi = @FilmAdi";

            // Bağlantıyı oluşturun
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Komut ve bağlantıyı oluşturun
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Parametreyi ekle
                    command.Parameters.AddWithValue("@FilmAdi", selectedFilm);

                    try
                    {
                        // Bağlantıyı açın
                        connection.Open();

                        // Veriyi okuyun
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            // ComboBox4'ü temizleyin
                            comboBox4.Items.Clear();

                            // Veri varsa, salon numaralarını comboBox4'e ekleyin
                            while (reader.Read())
                            {
                                comboBox4.Items.Add(reader["SalonNo"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda hata mesajını gösterin
                        MessageBox.Show("Salonlar alınırken bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Seçilen film, salon ve saat bilgilerini alın
            string filmAdi = comboBox1.SelectedItem.ToString();
            string salonNo = comboBox4.SelectedItem.ToString();
            string seansSaati = comboBox2.SelectedItem.ToString();

            // Mevcut salon kapasitesini kontrol edin
            int mevcutKapasite = GetMevcutKapasite(salonNo);

            // Mevcut kapasite 0'dan büyükse yer ayırma işlemi yapın
            if (mevcutKapasite > 0)
            {
                // Bilet satışı başarılı, mevcut kapasiteyi güncelle
                UpdateMevcutKapasite(salonNo, mevcutKapasite - 1);

                MessageBox.Show("Bilet satışı başarılı! Yer ayırtıldı.");
            }
            else
            {
                // Mevcut kapasite 0'a ulaştı, bilet satışını iptal edin
                MessageBox.Show("Bu salonda bu film için yer kalmamıştır, lütfen diğer seanslara bakınız.");
            }
        }


        private int GetMevcutKapasite(string salonNo)
        {
            // Bağlantı dizesini alın
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Mevcut kapasiteyi saklayacak değişken
            int mevcutKapasite = 0;

            // SQL sorgusunu hazırlayın (parametreler kullanarak SQL enjeksiyonunu önlemek için)
            string query = "SELECT MevcutKapasite FROM salonKapasitesi WHERE SalonNo = @SalonNo";

            // Bağlantıyı oluşturun
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Komut ve bağlantıyı oluşturun
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Parametreyi ekle
                    command.Parameters.AddWithValue("@SalonNo", salonNo);

                    try
                    {
                        // Bağlantıyı açın
                        connection.Open();

                        // Veriyi okuyun
                        object result = command.ExecuteScalar();

                        // Eğer veri varsa, mevcut kapasiteyi alın
                        if (result != null && int.TryParse(result.ToString(), out mevcutKapasite))
                        {
                            return mevcutKapasite;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda hata mesajını gösterin
                        MessageBox.Show("Mevcut kapasite alınırken bir hata oluştu: " + ex.Message);
                    }
                }
            }

            return mevcutKapasite;
        }


        private void UpdateMevcutKapasite(string salonNo, int yeniKapasite)
        {
            // Bağlantı dizesini alın
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // SQL sorgusunu hazırlayın (parametreler kullanarak SQL enjeksiyonunu önlemek için)
            string query = "UPDATE salonKapasitesi SET MevcutKapasite = @YeniKapasite WHERE SalonNo = @SalonNo";

            // Bağlantıyı oluşturun
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                // Komut ve bağlantıyı oluşturun
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@SalonNo", salonNo);
                    command.Parameters.AddWithValue("@YeniKapasite", yeniKapasite);

                    try
                    {
                        // Bağlantıyı açın
                        connection.Open();

                        // Komutu çalıştırın
                        int rowsAffected = command.ExecuteNonQuery();

                        // Eğer satır etkilendiyse, başarı mesajı gösterin
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Mevcut kapasite başarıyla güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Mevcut kapasite güncellenirken bir hata oluştu.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata durumunda hata mesajını gösterin
                        MessageBox.Show("Mevcut kapasite güncellenirken bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }

    }
}
