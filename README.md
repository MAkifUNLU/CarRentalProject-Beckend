# Car Rental Project - Araba Kiralama Projesi
## Getting Started - Başlarken
:point_right: Go To Frontend [ReCap-Frontend](https://github.com/MAkifUNLU/ReCap-Frontend)<br/>

     The project was developed in C#, in accordance with the multi-layered architecture and SOLID principles.
CRUD operations were performed using the Entity Framework. MSSQL Localdb was used for database in the project.
This system includes authentication and authorization. Users can only perform transactions for which they are authorized.
Implementations of JWT; Transaction, Cache, Validation and Performance aspects have been implemented.
Fluent Validation support for Validation, Autofac support for IoC added.
The project includes CRUD operations for car, brand, color, car images, user, operations claim, user operation claims, customer, credit card and rental.
Car rental is carried out according to certain business rules.
In addition, findeks scores increase according to the users' car rentals.
Each car has its own findeks score. The user must have enough Findeks points to rent a car.

     Proje, çok katmanlı mimari ve SOLID ilkelerine uygun olarak C # ile geliştirilmiştir.
CRUD işlemleri Entity Framework kullanılarak gerçekleştirildi.
Projede veritabanı için MSSQL Localdb kullanılmıştır.
Bu sistem, kimlik doğrulama ve yetkilendirmeyi içerir.
Kullanıcılar yalnızca yetkili oldukları işlemleri gerçekleştirebilirler.
JWT Uygulamaları; İşlem, Önbellek, Doğrulama ve Performans konuları uygulandı.
Doğrulama için Akıcı Doğrulama desteği, IoC için Autofac desteği eklendi.
Proje, araba, marka, renk, araba resimleri, kullanıcı, operasyon talepleri, kullanıcı operasyon talepleri, müşteri, kredi kartı ve kiralama için CRUD operasyonlarını içermektedir.
Araç kiralama belirli iş kurallarına göre yapılmaktadır.
Ayrıca kullanıcıların araç kiralamalarına göre de findeks puanları yükseliyor.
Her arabanın kendi findeks puanı vardır.
Kullanıcı, araba kiralamak için yeterli Findeks puanına sahip olmalıdır.

## 	:computer:Built With These Technology and Techniques - Kullanılan Teknoloji ve Teknikler
* C#
* ASP.NET
* .NET CORE
* AOP
* JWT
* IOC
* SQL Server
* Aspects
* File Upload

## :books:Layers - Katmanlar
* [Business](https://github.com/MAkifUNLU/MyReCapProject/tree/master/Business)
   * It is where we manage the business rules of our project. Data controls, Validations, IoC Containers and authority controls
   * Projemizin iş kurallarını yönettiğimiz yerdir. Veri kontrolleri, Validasyonlar, IoC Container'lar ve yetki kontrolleri
* [ConsoleUI](https://github.com/MAkifUNLU/MyReCapProject/tree/master/ConsoleUI)
   * It is where we test our project on the console.
   * Projemizi konsolda test ettiğimiz yerdir.
* [Core](https://github.com/MAkifUNLU/MyReCapProject/tree/master/Core) </br>
   * The core layer of the project. I can also integrate it into my other projects. </br> 
   * Projenin çekirdek katmanı. Diğer projelerime de entegre edebilirim.
* [DataAccess](https://github.com/MAkifUNLU/MyReCapProject/tree/master/DataAccess)
   * It is the layer that connects the project with the Database.
   * Projenin, Veritabanı ile bağını kuran katmandır.
* [Entities](https://github.com/MAkifUNLU/MyReCapProject/tree/master/Entities)
   * It was created to use our tables in the database as objects in our project.
   * Veritabanındaki tablolarımızın projemizde nesne olarak kullanılması için oluşturulmuştur.
* [WebAPI](https://github.com/MAkifUNLU/MyReCapProject/tree/master/WebAPI)
   * It is the part of our project that opens to Frontend. Controllers are located here.
   * Projemizin Frontend'e açılan kısmıdır. Controllerlar burada yer alır.
## :e-mail:Contact - İletişim
<a href="https://www.linkedin.com/in/mehmet-akif-%C3%BCnl%C3%BC/" target="_blank" rel="nofollow"><img alt="Akif's Linkedin" src="https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white" /></a>
<a href="mailto:akif.unlu44@gmail.com" target="_blank" rel="nofollow"><img alt="Akif's Mail Address" src="https://img.shields.io/badge/Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white" /></a>
