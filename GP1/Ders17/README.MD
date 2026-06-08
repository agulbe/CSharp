# Ders17

## Görev

Bu proje, CSV dosyasından öğrenci nesneleri oluşturup `DataGridView` üzerinde listelemeyi gösterir.

## İşlenen konular

- `Ogrenci` sınıfı ile öğrenci bilgilerini temsil etme.
- `File.ReadAllLines` ile CSV dosyasını okuma.
- Satırları `Split(';')` ile parçalama ve listeye nesne olarak ekleme.
- `BindingSource` kullanarak `DataGridView` veri kaynağı oluşturma.
- İlk/son okunan öğrenci değerlerini form alanlarına aktarma.

## Not

Kodda `D:\Code\C#\GP1\prog.csv` dosya yolu kullanılır. Uygulamanın çalışması için bu dosyanın mevcut olması gerekir.

## Kullanılan kontroller

- `Label` (`label1`, `label2`, `label3`, `label4`, `label5`, `lblOrtalama`)
- `TextBox` (`txtNumara`, `txtAd`, `txtSoyad`)
- `NumericUpDown` (`nudVize`, `nudFinal`)
- `DataGridView` (`dgvOgrenci`)
- `BindingSource` (`ogrenciBindingSource`)

