namespace Sinema_Seans_Takip_Uygulaması_Güncel
{
    // Form1 sınıfının kısmi bir tanımı
    partial class Form1
    {
        // Form üzerindeki bileşenlerin yönetilmesi için gerekli nesnelerin tanımlanması
        private System.ComponentModel.IContainer components = null;

        // Form nesnesi yok edildiğinde veya kapatıldığında çağrılan metot
        protected override void Dispose(bool disposing)
        {
            // Eğer disposing true ise ve bileşenler kullanımdaysa
            if (disposing && (components != null))
            {
                // Bileşenleri serbest bırak
                components.Dispose();
            }
            // Temel sınıfın Dispose metodu çağrılıyor
            base.Dispose(disposing);
        }


        

        private void InitializeComponent()
{
    // components nesnesinin oluşturulması
    this.components = new System.ComponentModel.Container();

    // tabControl1 nesnesinin oluşturulması ve ayarlanması
    this.tabControl1 = new System.Windows.Forms.TabControl();
    this.tabPage1 = new System.Windows.Forms.TabPage();
    this.button4 = new System.Windows.Forms.Button();
    this.label5 = new System.Windows.Forms.Label();
    this.label4 = new System.Windows.Forms.Label();
    this.label3 = new System.Windows.Forms.Label();
    this.label2 = new System.Windows.Forms.Label();
    this.textBox5 = new System.Windows.Forms.TextBox();
    this.textBox4 = new System.Windows.Forms.TextBox();
    this.textBox3 = new System.Windows.Forms.TextBox();
    this.textBox2 = new System.Windows.Forms.TextBox();
    // tabPage2 nesnesinin oluşturulması ve ayarlanması
    this.tabPage2 = new System.Windows.Forms.TabPage();
    this.dataGridView2 = new System.Windows.Forms.DataGridView();
    this.button5 = new System.Windows.Forms.Button();
    this.label6 = new System.Windows.Forms.Label();
    this.comboBox3 = new System.Windows.Forms.ComboBox();
    // tabPage3 nesnesinin oluşturulması ve ayarlanması
    this.tabPage3 = new System.Windows.Forms.TabPage();
    this.label10 = new System.Windows.Forms.Label();
    this.label8 = new System.Windows.Forms.Label();
    this.comboBox6 = new System.Windows.Forms.ComboBox();
    this.comboBox5 = new System.Windows.Forms.ComboBox();
    this.label7 = new System.Windows.Forms.Label();
    // tabPage4 nesnesinin oluşturulması ve ayarlanması
    this.tabPage4 = new System.Windows.Forms.TabPage();
    this.comboBox4 = new System.Windows.Forms.ComboBox();
    this.button3 = new System.Windows.Forms.Button();
    this.button2 = new System.Windows.Forms.Button();
    this.dataGridView1 = new System.Windows.Forms.DataGridView();
    this.comboBox2 = new System.Windows.Forms.ComboBox();
    this.comboBox1 = new System.Windows.Forms.ComboBox();
    this.splitter1 = new System.Windows.Forms.Splitter();
    this.label1 = new System.Windows.Forms.Label();
    // tabPage5 nesnesinin oluşturulması ve ayarlanması
    this.tabPage5 = new System.Windows.Forms.TabPage();
    this.button1 = new System.Windows.Forms.Button();
    this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
    this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
    this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
    // tabControl1 için ayarlamaların yapılması
    this.tabControl1.SuspendLayout();
    this.tabPage1.SuspendLayout();
    this.tabPage2.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
    this.tabPage3.SuspendLayout();
    this.tabPage4.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
    this.tabPage5.SuspendLayout();
    this.SuspendLayout();
        

// tabControl1 nesnesinin oluşturulması ve ayarlanması
this.tabControl1 = new System.Windows.Forms.TabControl();

// Sekmelerin eklenmesi
this.tabControl1.Controls.Add(this.tabPage1); // Film ekleme sekmesi
this.tabControl1.Controls.Add(this.tabPage2); // Salon kontrol sekmesi
this.tabControl1.Controls.Add(this.tabPage3); // Seans kontrolü sekmesi
this.tabControl1.Controls.Add(this.tabPage4); // Bilet satışı sekmesi
this.tabControl1.Controls.Add(this.tabPage5); // Çıkış sekmesi

// Tab kontrolünün konumu, adı, boyutu ve seçili sekmesinin indeksi belirleniyor
this.tabControl1.Location = new System.Drawing.Point(40, 12);
this.tabControl1.Name = "tabControl1";
this.tabControl1.SelectedIndex = 0;
this.tabControl1.Size = new System.Drawing.Size(721, 401);
this.tabControl1.TabIndex = 0;
            
            
//tabPage1 kontrolleri            
this.tabPage1.Controls.Add(this.button4); // tabPage1'e button4 kontrolünü ekler
this.tabPage1.Controls.Add(this.label5); // tabPage1'e label5 kontrolünü ekler
this.tabPage1.Controls.Add(this.label4); // tabPage1'e label4 kontrolünü ekler
this.tabPage1.Controls.Add(this.label3); // tabPage1'e label3 kontrolünü ekler
this.tabPage1.Controls.Add(this.label2); // tabPage1'e label2 kontrolünü ekler
this.tabPage1.Controls.Add(this.textBox5); // tabPage1'e textBox5 kontrolünü ekler
this.tabPage1.Controls.Add(this.textBox4); // tabPage1'e textBox4 kontrolünü ekler
this.tabPage1.Controls.Add(this.textBox3); // tabPage1'e textBox3 kontrolünü ekler
this.tabPage1.Controls.Add(this.textBox2); // tabPage1'e textBox2 kontrolünü ekler
this.tabPage1.Location = new System.Drawing.Point(4, 29); // tabPage1'in konumunu belirler
this.tabPage1.Name = "tabPage1"; // tabPage1'in adını belirler
this.tabPage1.Padding = new System.Windows.Forms.Padding(3); // tabPage1'in dolgusunu ayarlar
this.tabPage1.Size = new System.Drawing.Size(713, 368); // tabPage1'in boyutunu belirler
this.tabPage1.TabIndex = 0; // tabPage1'in sekmeye olan dizin numarasını belirler
this.tabPage1.Text = "tabPage1"; // tabPage1'in metin öğesini belirler
this.tabPage1.UseVisualStyleBackColor = true; // tabPage1'in kullanılabilirliğini belirler
this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click); // tabPage1'e tıklandığında gerçekleşecek olayı belirler

// tabPage1
// 
// button4 kontrolü
this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))); // button4'ün yazı tipini, boyutunu ve diğer özelliklerini belirler
this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))); // button4'ün metin rengini belirler
this.button4.Location = new System.Drawing.Point(248, 174); // button4'ün konumunu belirler
this.button4.Name = "button4"; // button4'ün adını belirler
this.button4.Size = new System.Drawing.Size(178, 80); // button4'ün boyutunu belirler
this.button4.TabIndex = 8; // button4'ün sekmeye olan dizin numarasını belirler
this.button4.Text = "EKLE"; // button4'ün metnini belirler
this.button4.UseVisualStyleBackColor = true; // button4'ün standart düğme davranışını etkinleştirir
this.button4.Click += new System.EventHandler(this.button4_Click); // button4'ün tıklama olayı için bir olay işleyicisi belirler

// label5 kontrolü
this.label5.AutoSize = true; // label5'in otomatik boyutlandırılmasını sağlar
this.label5.Location = new System.Drawing.Point(475, 43); // label5'in konumunu belirler
this.label5.Name = "label5"; // label5'in adını belirler
this.label5.Size = new System.Drawing.Size(116, 20); // label5'in boyutunu belirler
this.label5.TabIndex = 7; // label5'in sekmeye olan dizin numarasını belirler
this.label5.Text = "Salon Kapasite"; // label5'in metnini belirler

// label4 kontrolü
this.label4.AutoSize = true; // label4'ün otomatik boyutlandırılmasını sağlar
this.label4.Location = new System.Drawing.Point(366, 43); // label4'ün konumunu belirler
this.label4.Name = "label4"; // label4'ün adını belirler
this.label4.Size = new System.Drawing.Size(74, 20); // label4'ün boyutunu belirler
this.label4.TabIndex = 6; // label4'ün sekmeye olan dizin numarasını belirler
this.label4.Text = "Salon No"; // label4'ün metnini belirler

// label3 kontrolü
this.label3.AutoSize = true; // label3'ün otomatik boyutlandırılmasını sağlar
this.label3.Location = new System.Drawing.Point(226, 43); // label3'ün konumunu belirler
this.label3.Name = "label3"; // label3'ün adını belirler
this.label3.Size = new System.Drawing.Size(96, 20); // label3'ün boyutunu belirler
this.label3.TabIndex = 5; // label3'ün sekmeye olan dizin numarasını belirler
this.label3.Text = "Seans Saati"; // label3'ün metnini belirler

// label2 kontrolü
this.label2.AutoSize = true; // label2'nin otomatik boyutlandırılmasını sağlar
this.label2.Location = new System.Drawing.Point(110, 43); // label2'nin konumunu belirler
this.label2.Name = "label2"; // label2'nin adını belirler
this.label2.Size = new System.Drawing.Size(65, 20); // label2'nin boyutunu belirler
this.label2.TabIndex = 4; // label2'nin sekmeye olan dizin numarasını belirler
this.label2.Text = "Film Adı"; // label2'nin metnini belirler

// textBox5 kontrolü
this.textBox5.Location = new System.Drawing.Point(479, 66); // textBox5'in konumunu belirler
this.textBox5.Name = "textBox5"; // textBox5'in adını belirler
this.textBox5.Size = new System.Drawing.Size(100, 26); // textBox5'in boyutunu belirler
this.textBox5.TabIndex = 3; // textBox5'in sekmeye olan dizin numarasını belirler

// textBox4 kontrolü
this.textBox4.Location = new System.Drawing.Point(353, 66); // textBox4'un konumunu belirler
this.textBox4.Name = "textBox4"; // textBox4'un adını belirler
this.textBox4.Size = new System.Drawing.Size(100, 26); // textBox4'un boyutunu belirler
this.textBox4.TabIndex = 2; // textBox4'un sekmeye olan dizin numarasını belirler
this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged); // textBox4'un metin değişikliği olayı için bir olay işleyicisi belirler

// textBox3 kontrolü
this.textBox3.Location = new System.Drawing.Point(222, 66); // textBox3'ün konumunu belirler
this.textBox3.Name = "textBox3"; // textBox3'ün adını belirler
this.textBox3.Size = new System.Drawing.Size(100, 26); // textBox3'ün boyutunu belirler
this.textBox3.TabIndex = 1; // textBox3'ün sekmeye olan dizin numarasını belirler
this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged); // textBox3'ün metin değişikliği olayı için bir olay işleyicisi belirler

// textBox2 kontrolü
this.textBox2.Location = new System.Drawing.Point(90, 66); // textBox2'nin konumunu belirler
this.textBox2.Name = "textBox2"; // textBox2'nin adını belirler
this.textBox2.Size = new System.Drawing.Size(100, 26); // textBox2'nin boyutunu belirler
this.textBox2.TabIndex = 0; // textBox2'nin sekmeye olan dizin numarasını belirler

// tabPage2
// 
// dataGridView2 kontrolü
this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize; // dataGridView2'nin hücrelerinin düzenini belirler
this.dataGridView2.Location = new System.Drawing.Point(413, 173); // dataGridView2'nin konumunu belirler
this.dataGridView2.Name = "dataGridView2"; // dataGridView2'nin adını belirler
this.dataGridView2.RowHeadersWidth = 62; // dataGridView2'nin satır başlıklarının genişliğini belirler
this.dataGridView2.RowTemplate.Height = 28; // dataGridView2'nin satır yüksekliğini belirler
this.dataGridView2.Size = new System.Drawing.Size(240, 150); // dataGridView2'nin boyutunu belirler
this.dataGridView2.TabIndex = 3; // dataGridView2'nin sekmeye olan dizin numarasını belirler

// button5 kontrolü
this.button5.Location = new System.Drawing.Point(214, 99); // button5'in konumunu belirler
this.button5.Name = "button5"; // button5'in adını belirler
this.button5.Size = new System.Drawing.Size(116, 51); // button5'in boyutunu belirler
this.button5.TabIndex = 2; // button5'in sekmeye olan dizin numarasını belirler
this.button5.Text = "Kontrol Et"; // button5'in metnini belirler
this.button5.UseVisualStyleBackColor = true; // button5'in standart düğme davranışını etkinleştirir
this.button5.Click += new System.EventHandler(this.button5_Click); // button5'in tıklama olayı için bir olay işleyicisi belirler

// label6 kontrolü
this.label6.AutoSize = true; // label6'nin otomatik boyutlandırılmasını sağlar
this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))); // label6'nın yazı tipini, boyutunu ve diğer özelliklerini belirler
this.label6.Location = new System.Drawing.Point(27, 57); // label6'nın konumunu belirler
this.label6.Name = "label6"; // label6'nın adını belirler
this.label6.Size = new System.Drawing.Size(592, 29); // label6'nın boyutunu belirler
this.label6.TabIndex = 1; // label6'nın sekmeye olan dizin numarasını belirler
this.label6.Text = "Kaç Numaralı Salonu Kontrol Etmek İstiyorsunuz ?"; // label6'nın metnini belirler

// comboBox3 kontrolü
this.comboBox3.FormattingEnabled = true; // comboBox3'ün açılır menü olarak görüntülenmesini sağlar
this.comboBox3.Location = new System.Drawing.Point(57, 111); // comboBox3'ün konumunu belirler
this.comboBox3.Name = "comboBox3"; // comboBox3'ün adını belirler
this.comboBox3.Size = new System.Drawing.Size(121, 28); // comboBox3'ün boyutunu belirler
this.comboBox3.TabIndex = 0; // comboBox3'ün sekmeye olan dizin numarasını belirler

// tabPage3
// 
// label10 kontrolü
this.label10.AutoSize = true; // label10'un otomatik boyutlandırılmasını sağlar
this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))); // label10'un yazı tipini, boyutunu ve diğer özelliklerini belirler
this.label10.Location = new System.Drawing.Point(407, 115); // label10'un konumunu belirler
this.label10.Name = "label10"; // label10'un adını belirler
this.label10.Size = new System.Drawing.Size(118, 20); // label10'un boyutunu belirler
this.label10.TabIndex = 7; // label10'un sekmeye olan dizin numarasını belirler
this.label10.Text = "Seans Seçimi"; // label10'un metnini belirler

// label8 kontrolü
this.label8.AutoSize = true; // label8'in otomatik boyutlandırılmasını sağlar
this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))); // label8'in yazı tipini, boyutunu ve diğer özelliklerini belirler
this.label8.Location = new System.Drawing.Point(145, 115); // label8'in konumunu belirler
this.label8.Name = "label8"; // label8'in adını belirler
this.label8.Size = new System.Drawing.Size(100, 20); // label8'in boyutunu belirler
this.label8.TabIndex = 5; // label8'in sekmeye olan dizin numarasını belirler
this.label8.Text = "Film Seçimi"; // label8'in metnini belirler

// comboBox6 kontrolü
this.comboBox6.FormattingEnabled = true; // comboBox6'nın açılır menü olarak görüntülenmesini sağlar
this.comboBox6.Location = new System.Drawing.Point(380, 147); // comboBox6'nın konumunu belirler
this.comboBox6.Name = "comboBox6"; // comboBox6'nın adını belirler
this.comboBox6.Size = new System.Drawing.Size(171, 28); // comboBox6'nın boyutunu belirler
this.comboBox6.TabIndex = 4; // comboBox6'nın sekmeye olan dizin numarasını belirler

// comboBox5 kontrolü
this.comboBox5.FormattingEnabled = true; // comboBox5'in açılır menü olarak görüntülenmesini sağlar
this.comboBox5.Location = new System.Drawing.Point(95, 147); // comboBox5'in konumunu belirler
this.comboBox5.Name = "comboBox5"; // comboBox5'in adını belirler
this.comboBox5.Size = new System.Drawing.Size(226, 28); // comboBox5'in boyutunu belirler
this.comboBox5.TabIndex = 3; // comboBox5'in sekmeye olan dizin numarasını belirler

// label7 kontrolü
this.label7.AutoSize = true; // label7'nin otomatik boyutlandırılmasını sağlar
this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))); // label7'nin yazı tipini, boyutunu ve diğer özelliklerini belirler
this.label7.Location = new System.Drawing.Point(6, 34); // label7'nin konumunu belirler
this.label7.Name = "label7"; // label7'nin adını belirler
this.label7.Size = new System.Drawing.Size(628, 52); // label7'nin boyutunu belirler
this.label7.TabIndex = 2; // label7'nin sekmeye olan dizin numarasını belirler
this.label7.Text = "Hangi Filmin Hangi Seansı'nın Salon Kapasitesini Görmek\r\nİstiyorsunuz ?"; // label7'nin metnini belirler

// tabPage4
// 
// comboBox4 kontrolü
this.comboBox4.FormattingEnabled = true; // comboBox4'ün açılır menü olarak görüntülenmesini sağlar
this.comboBox4.Location = new System.Drawing.Point(281, 55); // comboBox4'ün konumunu belirler
this.comboBox4.Name = "comboBox4"; // comboBox4'ün adını belirler
this.comboBox4.Size = new System.Drawing.Size(191, 28); // comboBox4'ün boyutunu belirler
this.comboBox4.TabIndex = 12; // comboBox4'ün sekmeye olan dizin numarasını belirler
this.comboBox4.Text = "Salon Seçimi"; // comboBox4'ün varsayılan metnini belirler

// button3 kontrolü
this.button3.Location = new System.Drawing.Point(548, 274); // button3'ün konumunu belirler
this.button3.Name = "button3"; // button3'ün adını belirler
this.button3.Size = new System.Drawing.Size(133, 61); // button3'ün boyutunu belirler
this.button3.TabIndex = 10; // button3'ün sekmeye olan dizin numarasını belirler
this.button3.Text = "Sil"; // button3'ün metnini belirler
this.button3.UseVisualStyleBackColor = true; // button3'ün standart düğme davranışını etkinleştirir
this.button3.Click += new System.EventHandler(this.button3_Click); // button3'ün tıklama olayı için bir olay işleyicisi belirler

// button2 kontrolü
this.button2.Location = new System.Drawing.Point(548, 124); // button2'nin konumunu belirler
this.button2.Name = "button2"; // button2'nin adını belirler
this.button2.Size = new System.Drawing.Size(133, 63); // button2'nin boyutunu belirler
this.button2.TabIndex = 9; // button2'nin sekmeye olan dizin numarasını belirler
this.button2.Text = "Bileti Kontrol Et Yer Varsa Satın Al"; // button2'nin metnini belirler
this.button2.UseVisualStyleBackColor = true; // button2'nin standart düğme davranışını etkinleştirir

// dataGridView1 kontrolü
this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize; // dataGridView1'in hücrelerinin düzenini belirler
this.dataGridView1.Location = new System.Drawing.Point(20, 124); // dataGridView1'in konumunu belirler
this.dataGridView1.Name = "dataGridView1"; // dataGridView1'in adını belirler
this.dataGridView1.RowHeadersWidth = 62; // dataGridView1'in satır başlıklarının genişliğini belirler
this.dataGridView1.RowTemplate.Height = 28; // dataGridView1'in satır yüksekliğini belirler
this.dataGridView1.Size = new System.Drawing.Size(486, 225); // dataGridView1'in boyutunu belirler
this.dataGridView1.TabIndex = 8; // dataGridView1'in sekmeye olan dizin numarasını belirler

// comboBox2 kontrolü
this.comboBox2.FormattingEnabled = true; // comboBox2'nin açılır menü olarak görüntülenmesini sağlar
this.comboBox2.Location = new System.Drawing.Point(498, 55); // comboBox2'nin konumunu belirler
this.comboBox2.Name = "comboBox2"; // comboBox2'nin adını belirler
this.comboBox2.Size = new System.Drawing.Size(183, 28); // comboBox2'nin boyutunu belirler
this.comboBox2.TabIndex = 7; // comboBox2'nin sekmeye olan dizin numarasını belirler
this.comboBox2.Text = "Saat Seçimi"; // comboBox2'nin varsayılan metnini belirler

// comboBox1 kontrolü
this.comboBox1.FormattingEnabled = true; // comboBox1'in açılır menü olarak görüntülenmesini sağlar
this.comboBox1.Location = new System.Drawing.Point(20, 55); // comboBox1'in konumunu belirler
this.comboBox1.Name = "comboBox1"; // comboBox1'in adını belirler
this.comboBox1.Size = new System.Drawing.Size(230, 28); // comboBox1'in boyutunu belirler
this.comboBox1.TabIndex = 6; // comboBox1'in sekmeye olan dizin numarasını belirler
this.comboBox1.Text = "Film Seçimi"; // comboBox1'in varsayılan metnini belirler
this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged); // comboBox1'in seçili dizin değişikliği olayı için bir olay işleyicisi belirler

// splitter1 kontrolü
this.splitter1.Location = new System.Drawing.Point(3, 3); // splitter1'in konumunu belirler
this.splitter1.Name = "splitter1"; // splitter1'in adını belirler
this.splitter1.Size = new System.Drawing.Size(3, 362); // splitter1'in boyutunu belirler
this.splitter1.TabIndex = 5; // splitter1'in sekmeye olan dizin numarasını belirler
this.splitter1.TabStop = false; // splitter1'in tıklanabilir olmasını sağlar

// label1 kontrolü
this.label1.AutoSize = true; // label1'in otomatik boyutlandırılmasını sağlar
this.label1.Location = new System.Drawing.Point(149, 12); // label1'in konumunu belirler
this.label1.Name = "label1"; // label1'in adını belirler
this.label1.Size = new System.Drawing.Size(80, 20); // label1'in boyutunu belirler
this.label1.TabIndex = 4; // label1'in sekmeye olan dizin numarasını belirler
this.label1.Text = "Bilet Satış"; // label1'in metnini belirler

// tabPage5
// 
// button1 kontrolü
this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))); // button1'in yazı tipini, boyutunu ve diğer özelliklerini belirler
this.button1.ForeColor = System.Drawing.Color.Red; // button1'in metin rengini belirler
this.button1.Location = new System.Drawing.Point(193, 74); // button1'in konumunu belirler
this.button1.Name = "button1"; // button1'in adını belirler
this.button1.Size = new System.Drawing.Size(311, 178); // button1'in boyutunu belirler
this.button1.TabIndex = 0; // button1'in sekmeye olan dizin numarasını belirler
this.button1.Text = "ÇIKIŞ"; // button1'in metnini belirler
this.button1.UseVisualStyleBackColor = true; // button1'in standart düğme davranışını etkinleştirir
this.button1.Click += new System.EventHandler(this.button1_Click); // button1'in tıklama olayı için bir olay işleyicisi belirler

// ContextMenuStrip bileşeninin özelliklerinin tanımlanması.
// Bu bileşen, sağ tık menüsü öğelerini içerir.
this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
this.contextMenuStrip1.Name = "contextMenuStrip1";
this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);

// Form1 bileşeninin özelliklerinin tanımlanması.
// Formun boyutu ve diğer özellikleri burada belirlenir.
this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
this.ClientSize = new System.Drawing.Size(798, 425);
this.Controls.Add(this.tabControl1);
this.Name = "Form1";
this.Text = "Form1";
// Form yüklenirken gerçekleşecek olayın belirlenmesi.
this.Load += new System.EventHandler(this.Form1_Load);

// Diğer bileşenlerin tanımlandığı ve özelliklerinin belirlendiği bölüm.
// Detaylı açıklamalar için yukarıdaki yorum satırlarına bakabilirsiniz.
this.tabControl1.ResumeLayout(false);
this.tabPage1.ResumeLayout(false);
this.tabPage1.PerformLayout();
this.tabPage2.ResumeLayout(false);
this.tabPage2.PerformLayout();
((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
this.tabPage3.ResumeLayout(false);
this.tabPage3.PerformLayout();
this.tabPage4.ResumeLayout(false);
this.tabPage4.PerformLayout();
((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
this.tabPage5.ResumeLayout(false);
this.ResumeLayout(false);

#endregion
 private System.Windows.Forms.TabControl tabControl1;
 private System.Windows.Forms.TabPage tabPage1;
private System.Windows.Forms.TabPage tabPage2;
private System.Windows.Forms.TabPage tabPage3;
private System.Windows.Forms.TabPage tabPage4;
private System.Windows.Forms.TabPage tabPage5;
private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
private System.Windows.Forms.TextBox textBox2;
private System.Windows.Forms.Label label5;
private System.Windows.Forms.Label label4;
private System.Windows.Forms.Label label3;
private System.Windows.Forms.Label label2;
private System.Windows.Forms.TextBox textBox5;
private System.Windows.Forms.TextBox textBox4;
private System.Windows.Forms.TextBox textBox3;
private System.Windows.Forms.Label label6;
private System.Windows.Forms.ComboBox comboBox3;
private System.Windows.Forms.Label label7;
private System.Windows.Forms.Button button4;
private System.Windows.Forms.DataGridView dataGridView2;
private System.Windows.Forms.Button button5;
private System.Windows.Forms.Button button3;
private System.Windows.Forms.Button button2;
private System.Windows.Forms.DataGridView dataGridView1;
private System.Windows.Forms.ComboBox comboBox2;
private System.Windows.Forms.ComboBox comboBox1;
private System.Windows.Forms.Splitter splitter1;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.Button button1;
private System.ComponentModel.BackgroundWorker backgroundWorker1;
private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
private System.Windows.Forms.ComboBox comboBox4;
private System.Windows.Forms.Label label8;
private System.Windows.Forms.ComboBox comboBox6;
private System.Windows.Forms.ComboBox comboBox5;
private System.Windows.Forms.Label label10;
    }
}
