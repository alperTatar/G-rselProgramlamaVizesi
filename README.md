# GorselProgramlamaVizesi/Ödevi

Basit bir tanımla bu program , bir sinema rezervasyon programıdır. Kullanıcı film , seans ve salon seçebilir ve bilet alabilir. Salonlardaki kapasite durumunu kontrol edebilir.

/// DETAYLI ANLATIM ///

İlk olarak program çalıştırıldığında karşımıza gelen ekranda bizi 4 adet textBox karşılıyor. Bunlar film adı , seans saati , salon no ve salon kapasiteleri bilgilerinin girilmesi için tasarlanmıştır. Bu kısımda film adı, seans saati ve salon no kullanıcı tarafından girilecektir. Seans saati ve Salon no isimli textBox'larda çeşitli kontroller sağlanmaktadır. Seans saati kısmına 23:00 veya 24:00 saatleri yazıldığında program bunu tespit edecek ve bu saatleri kabul etmeyecektır. Kullanıcıya bir hata mesajı gösterilecek ve ilgili textBox otomatik temizlecekdir. Salon no kısmında ise minimum 1 , maksimum 5 rakamları girilecektir. Bu rakamlar haricinde girilen veriler kabul edilmeyecek ve yine kullanıcıya bir hata mesajı verilerek ilgili textBox otomatik temizlenecektir. Ayrıca , her salonun kapasitesi programın kodları yazılırken belirlenmiştir. Her salonun kapasitesi vardır ve salon no adlı textBox'a 1 ile 5 arasındaki verilerden birisi girildiğinde , girilen salon numarası ne ise o salonun mevcut kapasitesi salon kapasite adlı textBox'a otomatik atanacak ve salon kapasite adlı textBox otomatik doldurulacaktır.Tüm bilgiler eksiksiz ve doğru şekilde girildikten sonra ekle butonuna tıklandığında , girilen veriler veritabanına'na(SQLİTE) gönderilecektir.(Resimli Anlatımlar Alt Kısımdadır)

2.Component ise salonların mevcut kapasitesini kontrol etmek için oluşturulmuştur. Bir adet comboBox tipinde veri seçiçi , bir adet buton ve datagridView kullanılmıştır. Bu kısımda kullanıcı, veritabanından gelen salon numaralarından birisini seçtikten sonra kontrol et adlı butona tıkladığında o salonun mevcut kapasitesi dataGridView üzerinde sayı olarak gösterilecektir.(Resimlerle anlatılmıştır)

3.Component'de ise seans kontrol ve salon takip bölümü vardır. Burada kullanıcı 2 adet comboBox'dan birinde filmi diğerinde ise seansı seçer ve o seanstaki mevcut kapasiteyi hem de o salondaki mevcut durumu görüntüleyebilir.(resimli analtımlar alt kısımdadır)

4. component'de ise 3 adet combobox,2 adet button ve bir adet dataGridView kullanılmıştır. Burada kullanıcı film seçimini yapar , filmi hangi salonda izlemek istediğini belirtir ve saat seçimi yapar. Daha sonra Bileti kontrol et yer varsa satın al butonuna bastığı an hem salonun mevcut kapasitesi ve anlık durumu gösterilir hem de otomatik bilet alma işlemi gerçekleşir. Bilet alma işlemi gerçekleştiği an o salonun mevcut kapasitesinden 1 kişilik yer azaltılır ve eğer kapasite bitmişse kullanıcıya hata mesajı verilir ve bilet satılmaz. Eğer kullanıcı bilgileri girdikten sonra vazgeçip sil butonuna basarsa , bilgileri girilen tüm textBoxlar otomatik silinecektir.(resimlerle anlatılmıştır)

5. Component'de ise çıkış işlemleri ve programı sonlarndırma işlemleri yapılmıştır.



