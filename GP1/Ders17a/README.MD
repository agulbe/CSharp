# Ders17a

## Görev

Bu proje, CSV dosyasından öğrenci listesi okuyup `DataGridView` üzerinde gösterir ve seçilen öğrencinin detaylarını forma aktarır.

## İşlenen konular

- Property kullanan `Ogrenci` sınıfı tanımlama.
- CSV dosyasından öğrenci listesi oluşturma.
- Listeyi doğrudan `DataGridView.DataSource` özelliğine bağlama.
- `DataGridView.CellContentClick` olayında seçilen satırın indeksini alma.
- Seçilen öğrencinin bilgilerini form alanlarına doldurma.
- Vize ve final notundan ağırlıklı ortalama hesaplama.

## Not

Kodda `D:\Code\C#\GP1\prog.csv` dosya yolu kullanılır. Uygulamanın çalışması için bu dosyanın mevcut olması gerekir.

## Kullanılan kontroller

- `SplitContainer` (`splitContainer1`)
- `Label` (`label1`, `label2`, `label3`, `label4`, `label5`, `lblOrtalama`)
- `TextBox` (`txtAd`, `txtSoyad`)
- `NumericUpDown` (`nudNumara`, `nudVize`, `nudFinal`)
- `DataGridView` (`dgvOgrenciler`)

