# Ticket-BE
ASP.NET CORE 3.1 ve Entity Framework Code First kullanarak geliştirdiğim projedir. 

# Projenin çalıştırılması

1.API içerisindeki **appsettings.json ve Startup.cs'de** ** ile işaretlenmiş olan yerlere bilgisayara özel ilgili değerlerin yazılması ve
**DataAccess** katmanındaki **TicketContext** içerisinde bilgisayara özel veritabanı konfigürasyonunun yapılması gerekmetedir.

2.Projede Entity Framework Code First yaklaşımı kullanılmıştır. Bu nedenle **Package Manager Console'da DataAccess** katmanı seçildikten sonra;

```
add-migration migrationIsmi
update-database
```
işlemlerinin gerçekleştirilmesi gerekmektedir.
