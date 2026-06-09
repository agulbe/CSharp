# InvoiceApp

## Proje Temasi
ASP.NET Core Razor Pages ve Entity Framework ile fatura CRUD uygulamasi.

## Proje Turu
ASP.NET Core web projesi.

## Kullanilan OOP Kavramlari
Entity, DTO, DbContext, migration, CRUD, repository benzeri veri erisimi ve ayrik katmanlar.

Bu projede kodun ana fikri, veriyi ve davranisi ilgili siniflar icinde toplamak ve uygulama akisinda bu nesneleri kullanmaktir. Form, web veya konsol yapisina gore kullanici etkilesimi ayri bir katmanda tutulurken model siniflari uygulamanin temel kavramlarini temsil eder.

## Onemli Dosyalar
- `InvoiceApp\Migrations\20260422212904_FirstMigration.cs`
- `InvoiceApp\Migrations\20260422212904_FirstMigration.Designer.cs`
- `InvoiceApp\Migrations\ApplicationDbContextModelSnapshot.cs`
- `InvoiceApp\Models\Invoice.cs`
- `InvoiceApp\Models\InvoiceDto.cs`
- `InvoiceApp\Pages\Error.cshtml.cs`
- `InvoiceApp\Pages\Index.cshtml.cs`
- `InvoiceApp\Pages\Invoices\Create.cshtml.cs`
- `InvoiceApp\Pages\Invoices\Delete.cshtml.cs`
- `InvoiceApp\Pages\Invoices\Details.cshtml.cs`
- `InvoiceApp\Pages\Invoices\Edit.cshtml.cs`
- `InvoiceApp\Pages\Invoices\Index.cshtml.cs`

## Calistirma
```bash
dotnet run --project "InvoiceApp\InvoiceApp.csproj"
```
## Not
Bu projede wwwroot/lib altindaki vendor dosyalari repo boyutunu kucultmek icin kaldirilmistir. Bootstrap, jQuery ve dogrulama kutuphaneleri calisma aninda CDN uzerinden yuklenir.
