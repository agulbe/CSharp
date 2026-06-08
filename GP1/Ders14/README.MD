# Ders14

Bu proje, SQL Server'dan fatura verilerini okuyup `DataGridView` üzerinde gösteren Windows Forms uygulamasıdır.

## Görev

- `invoicedb` veritabanındaki `Invoices` tablosundan fatura kayıtlarını okumak.
- Kayıtları `Invoice` modeli ve `InvoiceStatus` enum'u ile temsil etmek.
- Faturaları `DataGridView` kontrolüne bağlamak.
- Tabloda seçilen faturanın detaylarını form alanlarına aktarmak.

## Not

Bağlantı dizesi yerel SQL Server için ayarlanmıştır: `(local)`, `invoicedb` veritabanı ve `Invoices` tablosu gerekir.

## Teknolojiler

- C#
- .NET Windows Forms
- Microsoft.Data.SqlClient
- SQL Server
- `DataGridView`

