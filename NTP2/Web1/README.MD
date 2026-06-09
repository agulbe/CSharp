# Web1

## Proje Temasi
Razor Pages ve Entity Framework ile fatura yonetimi uygulamasi.

## Proje Turu
ASP.NET Core web projesi.

## Kullanilan OOP Kavramlari
CRUD, DbContext, migration, entity/DTO ayrimi, model binding ve sayfa modelleri.

Bu projede kodun ana fikri, veriyi ve davranisi ilgili siniflar icinde toplamak ve uygulama akisinda bu nesneleri kullanmaktir. Form, web veya konsol yapisina gore kullanici etkilesimi ayri bir katmanda tutulurken model siniflari uygulamanin temel kavramlarini temsil eder.

## Onemli Dosyalar
- `Web1\Migrations\20260505075640_FirstMigration.cs`
- `Web1\Migrations\20260505075640_FirstMigration.Designer.cs`
- `Web1\Migrations\ApplicationDbContextModelSnapshot.cs`
- `Web1\Models\Invoice.cs`
- `Web1\Models\InvoiceDto.cs`
- `Web1\Pages\Error.cshtml.cs`
- `Web1\Pages\Index.cshtml.cs`
- `Web1\Pages\Invoices\Create.cshtml.cs`
- `Web1\Pages\Invoices\Delete.cshtml.cs`
- `Web1\Pages\Invoices\Details.cshtml.cs`
- `Web1\Pages\Invoices\Edit.cshtml.cs`
- `Web1\Pages\Invoices\Index.cshtml.cs`

## Calistirma
```bash
dotnet run --project "Web1\Web1.csproj"
```
