# Web2

## Proje Temasi
ASP.NET Core MVC ile gider/finans kaydi uygulamasi.

## Proje Turu
ASP.NET Core web projesi.

## Kullanilan OOP Kavramlari
MVC deseni, Controller, Model, View, DbContext, migration ve sorumluluk ayrimi.

Bu projede kodun ana fikri, veriyi ve davranisi ilgili siniflar icinde toplamak ve uygulama akisinda bu nesneleri kullanmaktir. Form, web veya konsol yapisina gore kullanici etkilesimi ayri bir katmanda tutulurken model siniflari uygulamanin temel kavramlarini temsil eder.

## Onemli Dosyalar
- `Web2\Controllers\ExpensesController.cs`
- `Web2\Controllers\HomeController.cs`
- `Web2\Data\FinanceAppContext.cs`
- `Web2\Migrations\20260420183606_initial migration.cs`
- `Web2\Migrations\20260420183606_initial migration.Designer.cs`
- `Web2\Migrations\FinanceAppContextModelSnapshot.cs`
- `Web2\Models\ErrorViewModel.cs`
- `Web2\Models\Expense.cs`
- `Web2\Program.cs`

## Calistirma
```bash
dotnet run --project "Web2\Web2.csproj"
```
## Not
Bu projede wwwroot/lib altindaki vendor dosyalari repo boyutunu kucultmek icin kaldirilmistir. Bootstrap, jQuery ve dogrulama kutuphaneleri calisma aninda CDN uzerinden yuklenir.
